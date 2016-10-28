using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLibrary;

namespace Show
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new OrderSystemContext();

            var catalogs = context.ProductCatalogs.Where(c => c.ProductCatalogId == 1).ToList();

            ProductCatalog pc = new ProductCatalog();
            pc.CatalogName = "CatalogName";
            pc.ListPrice = 100;
            pc.Manufactory = "Manufactory";
            pc.NetPrice = 200;

            context.ProductCatalogs.Add(pc);

            int count = context.SaveChanges();

            Console.ReadKey();
        }

        public static void TestAdd()
        {

        }
    }
}
