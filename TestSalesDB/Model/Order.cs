using System;
using System.Collections.Generic;
using System.Text;

namespace TestSalesDB.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public  List<OrderItem> Items { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; }

        public Order SetItems(List<OrderItem> OrderItems)
        {
            Items = OrderItems;
            return this;
        }

    }
}
