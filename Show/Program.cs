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
            OrderSystemContext db = new OrderSystemContext();

            #region 1.查询测试
            //var products = db.ProductCatalogs.ToList();
            #endregion

            #region 2.值对象测试

            //Customer newCustomer = new Customer() { IDCardNumber = "120104198106072518", CustomerName = "Alex", Gender = "M", PhoneNumber = "test" };
            //Address customerAddress = new Address { Country = "China", Province = "Tianjin", City = "Tianjin", StreetAddress = "Crown Plaza", ZipCode = "300308" };

            //newCustomer.Address = customerAddress;
            //db.Customers.Add(newCustomer);

            //db.SaveChanges(); 
            #endregion

            #region 添加一对多映射
            Order order = new Order();
            order.CreatedDate = DateTime.Now;


            order.Customer = db.Customers.FirstOrDefault(item => item.IDCardNumber == "rj");

            OrderItem oi = new OrderItem();
            oi.Order = order;
            oi.Products = db.Products.ToList();

            order.OrderItems = new List<OrderItem>() { oi };

            db.Orders.Add(order);

            try
            {
                int i = db.SaveChanges();

            }
            catch (Exception ex)
            {

            } 
            #endregion

            Console.ReadKey();
        }
    }
}
