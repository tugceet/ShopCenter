using Microsoft.EntityFrameworkCore;
using ShopCenter.Domain.Entities;

namespace ShopCenter.Infrastructure.Context 
{ 
    public class ShopCenterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DESKTOP-944RVAP;initial Catalog=ShopCenterDb;integrated Security=true;TrustServerCertificate= true;");//BURANIN İÇİNE CONN STRİNG YAZILACAK
        }

        public DbSet<Admin> Admins{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<CustomerDebt> CustomerDebts{ get; set; }

    }
}
