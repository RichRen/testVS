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
            //Database.SetInitializer<OrderSystemContext>(new CreateDatabaseIfNotExists<OrderSystemContext>());
            //Database.SetInitializer<OrderSystemContext>(new DropCreateOrderDatabaseWithSeedValueAlways());
        }

        public DbSet<ProductCatalog> ProductCatalogs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductCatalogConfiguration());
            modelBuilder.Configurations.Add(new CustomerEntityConfiguration());
            modelBuilder.Configurations.Add(new AddressComplexTypeConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());

            //值对象的类必须具备三个条件。
            //1.值对象类不能有主键。
            //2.值对象类只能包含.net基础类型的属性。
            //3.使用值对象的类，只能包含值对象的一个实例，不能使用值对象的集合。
            //如果值对象不满足条件，需要手动注册
            //modelBuilder.ComplexType<Address>();
        }
    }


}
