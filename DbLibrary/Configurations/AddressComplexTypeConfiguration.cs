using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Configurations
{
    /// <summary>
    /// 值对象列的名字默认是值对象类的名字+“_”+值对象属性的名字。可以主动改变这些默认配置
    /// </summary>
    public class AddressComplexTypeConfiguration : ComplexTypeConfiguration<Address>
    {
        public AddressComplexTypeConfiguration()
        {
            Property(a => a.Country).HasColumnName("Country").HasMaxLength(100);
            Property(a => a.Province).HasColumnName("Province").HasMaxLength(100);
            Property(a => a.City).HasColumnName("City").HasMaxLength(100);
            Property(a => a.StreetAddress).HasColumnName("StreetAddress").HasMaxLength(500);
            Property(a => a.ZipCode).HasColumnName("ZipCode").HasMaxLength(6);
        }
    }
}
