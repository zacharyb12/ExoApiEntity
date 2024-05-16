using Microsoft.EntityFrameworkCore;
using Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Context
{
    public class DalContext : DbContext
    {
        public DalContext(DbContextOptions<DalContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

    }
}
