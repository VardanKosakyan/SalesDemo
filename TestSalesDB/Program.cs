using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TestSalesDB.Model;

namespace TestSalesDB
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*test
            using (var ctx = new SalesContext())
            {
                var t = ctx.Orders.Where(o=>o.Id<2000).ToList();
            }
            */

            //ex1
            using (var ctx = new SalesContext())
            {
                string IsConnected(object Entity) => ctx.Entry(Entity).State == EntityState.Detached ? "Disconnected" : "Connected";

                //New Creted Object is Disconnected
                var NewProduct = new Product { Name = "Orange", CategoryId = 4 };
                Console.WriteLine($"Just created object : {IsConnected(NewProduct)}");

                //Loaded Entity Is Connected
                var ExistingProduct = ctx.Products.Where(p => p.Id == 1).FirstOrDefault();
                Console.WriteLine($"Loaded entity : {IsConnected(ExistingProduct)}");               

                //AsNoTracking Disconnects Entities
                var ExistingProductNotTracked = ctx.Products.Where(p => p.Id == 2).AsNoTracking().FirstOrDefault();
                Console.WriteLine($"Loaded AsNoTracking : {IsConnected(ExistingProductNotTracked)}");              

                //Connect Entity
                ctx.Attach(NewProduct);
                Console.WriteLine($"Attached : {IsConnected(NewProduct)}");
              
            }


        }
    }
}
