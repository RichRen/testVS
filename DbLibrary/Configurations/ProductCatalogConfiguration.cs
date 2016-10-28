using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Configurations
{
    public class ProductCatalogConfiguration : EntityTypeConfiguration<ProductCatalog>
    {
        public ProductCatalogConfiguration()
        {
            this.Property(p => p.ProductCatalogId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
