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
            var db = new OrderSystemContext();

            var catalogs = db.ProductCatalogs.Where(c => c.ProductCatalogId == 1).ToList();
            var customs = db.Customers.ToList();

            ProductCatalog pc = new ProductCatalog();
            pc.CatalogName = "CatalogName";
            pc.ListPrice = 100;
            pc.Manufactory = "Manufactory";
            pc.NetPrice = 200;

            db.ProductCatalogs.Add(pc);

            int count = db.SaveChanges();

            Console.ReadKey();
        }

        public static void TestAdd()
        {

        }
    }
}
