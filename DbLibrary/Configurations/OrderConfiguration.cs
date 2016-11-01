using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Configurations
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            this.HasMany(order => order.OrderItems)
                .WithRequired(item => item.Order)
                .Map(o => o.MapKey("OrderId"))
                .WillCascadeOnDelete(true);
        }
    }
}
