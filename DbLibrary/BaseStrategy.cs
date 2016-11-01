using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary
{
    //SetInitializer方法的参数可以使以下三个泛型类的对象：
    //CreateDatabaseIfNotExists<>：只有在没有数据库的时候才会根据数据库连接配置创建新的数据库
    //DropCreateDatabaseIfModelChanges<>：只要Fluent API配置的数据库映射发生变化或者domain中的model发生变化了，就把以前的数据库删除掉，根据新的配置重新建立数据库
    //DropCreateDatabaseAlways<>：不管数据库映射或者model是否发生变化，每次都重新删除并根据配置重建数据库

    public class DropCreateOrderDatabaseWithSeedValueAlways : DropCreateDatabaseAlways<OrderSystemContext>
    {
        protected override void Seed(OrderSystemContext context)
        {
            context.ProductCatalogs.Add(new ProductCatalog { CatalogName = "DELL E6400", Manufactory = "DELL", ListPrice = 5600, NetPrice = 4300 });
            context.ProductCatalogs.Add(new ProductCatalog { CatalogName = "DELL E6410", Manufactory = "DELL", ListPrice = 6500, NetPrice = 5100 });
            context.ProductCatalogs.Add(new ProductCatalog { CatalogName = "DELL E6420", Manufactory = "DELL", ListPrice = 7000, NetPrice = 5400 });

            context.Products.Add(new Product { Catalog = new ProductCatalog { CatalogName = "DELL E6400", Manufactory = "DELL", ListPrice = 5600, NetPrice = 4300 }, CreateDate = DateTime.Parse("2010-1-20"), ExpireDate = DateTime.Parse("2013-1-20") });
            context.Customers.Add(new Customer { IDCardNumber = "rj", CustomerName = "Alex", Gender = "M", PhoneNumber = "test", Address = new Address { Country = "China", Province = "Tianjin", City = "Tianjin", StreetAddress = "Crown Plaza", ZipCode = "300308" } });
        }
    }
}
