using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
	public class OrderUpContext : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=OrderUp;User=SA;Password=y0sTP4sswd;Encrypt=False;");
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Entities.Concrete.Type> Types { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}

