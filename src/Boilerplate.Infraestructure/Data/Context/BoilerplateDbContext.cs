using Boilerplate.Core.Models;
using Boilerplate.Infraestructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Infraestructure.Context
{
    public class BoilerplateDbContext : DbContext
    {
        public BoilerplateDbContext(DbContextOptions<BoilerplateDbContext> options) : base(options)
        {}

        public DbSet<Customer> Customer {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMapConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}