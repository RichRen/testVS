using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Configurations
{
    public class CustomerEntityConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerEntityConfiguration()
        {
            HasKey(c => c.IDCardNumber).Property(c => c.IDCardNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(c => c.IDCardNumber).HasMaxLength(20);
            this.Property(c => c.CustomerName).IsRequired().HasMaxLength(50);
            this.Property(c => c.Gender).IsRequired().HasMaxLength(1);
            this.Property(c => c.PhoneNumber).HasMaxLength(20);
        }
    }
}
