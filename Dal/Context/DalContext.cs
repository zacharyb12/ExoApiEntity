using Microsoft.EntityFrameworkCore;
using Models.UserModels;
using System;

namespace Dal.Context
{
    public class DalContext : DbContext
    {
        public DalContext(DbContextOptions<DalContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DalContext).Assembly);

        }

    }
}
