using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLibrary.Configurations;

namespace DbLibrary
{
    public class OrderSystemContext : DbContext
    {
        public OrderSystemContext()
            : base("name=OrderSystemContext")
        {
            Database.SetInitializer<OrderSystemContext>(null);
            //Database.SetInitializer<OrderSystemContext>(new DropCreateOrderDatabaseWithSeedValueAlways());
        }

        public DbSet<ProductCatalog> ProductCatalogs { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductCatalogConfiguration());
            modelBuilder.Configurations.Add(new CustomerEntityConfiguration());

        }        
    }

    
}
