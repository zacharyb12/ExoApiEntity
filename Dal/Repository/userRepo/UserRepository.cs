using Dal.Context;
using Dal.Repository.userRepo;
using Microsoft.EntityFrameworkCore;
using Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal.Repository.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly DalContext _context;

        public UserRepository(DalContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            try
            {
                return _context.User.AsNoTracking().ToList();
            }
            catch (Exception ex)
            {
                // Log exception here
                throw new Exception("An error occurred while retrieving all users.", ex);
            }
        }

        public User GetById(Guid id)
        {
            try
            {
                return _context.User.AsNoTracking().FirstOrDefault(u => u.Id == id);
            }
            catch (Exception ex)
            {
                // Log exception here
                throw new Exception($"An error occurred while retrieving the user with ID {id}.", ex);
            }
        }

        public void Update(User user)
        {
            try
            {
                _context.User.Update(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log exception here
                throw new Exception("An error occurred while updating the user.", ex);
            }
        }

        public void Create(User user)
        {
            try
            {
                _context.User.Add(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log exception here
                throw new Exception("An error occurred while creating the user.", ex);
            }
        }

        public void Delete(Guid id)
        {
            try
            {
                var user = _context.User.Find(id);
                if (user != null)
                {
                    _context.User.Remove(user);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log exception here
                throw new Exception($"An error occurred while deleting the user with ID {id}.", ex);
            }
        }
    }
}
