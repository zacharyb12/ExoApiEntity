using Dal.Repository.userRepo;
using Models.UserModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Services.UserServ
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository repository)
        {
                _userRepository = repository;
        }
        public void Create(User user)
        {
            try
            { 
            _userRepository.Create(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Bll Create", ex);
            }
        }

        public void Delete(Guid id)
        {
            try
            {

            _userRepository.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Bll Delete", ex);
            }
        }

        public IEnumerable<User> GetAll()
        {
            try
            { 
            return _userRepository.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Bll GetAll", ex);
            }
        }

        public User GetById(Guid id)
        {
            try
            { 
            return _userRepository.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Bll GetbyId", ex);
            }
        }

        public void Update(User user)
        {
            try
            { 
            _userRepository.Update(user);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Bll update", ex);
            }
        }
    }
}
