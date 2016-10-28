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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProductCatalog>().Property(p => p.ProductCatalogId)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

        }
    }
}
