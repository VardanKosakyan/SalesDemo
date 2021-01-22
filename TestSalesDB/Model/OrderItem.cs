using System;
using System.Collections.Generic;
using System.Text;

namespace TestSalesDB.Model
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        public Decimal Price { get; set; }
       // public Price Price { get; set; }
    }
}
