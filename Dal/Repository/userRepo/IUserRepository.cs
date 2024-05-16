using Microsoft.EntityFrameworkCore;
using Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Repository.userRepo
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();

        public User GetById(Guid id);

        public void Update(User user);

        public void Create(User user);

        public void Delete(Guid id);

    }
}
