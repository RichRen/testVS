using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary
{
    public class OrderSystemContext : DbContext
    {
        public OrderSystemContext()
            : base("name=OrderSystemContext")
        {
            //Database.SetInitializer<OrderSystemContext>(null);
        }

        public DbSet<ProductCatalog> ProductCatalogs { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductCatalog>().Property(p => p.ProductCatalogId)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<ProductCatalog>().ToTable("ProductCatalogs");

            modelBuilder.Entity<Customer>().HasKey(c => c.IDCardNumber).Property(item => item.IDCardNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Customer>().Property(c => c.CustomerName).IsRequired().HasMaxLength(10);

        }
    }
}
