using System;
using System.Collections.Generic;
using System.Text;
using TestSalesDB.Model.Enums;

namespace TestSalesDB.Model
{
    public class Order
    {
        public int Id { get; set; }
        
        public DateTime CreatedDate { get; set; }
        
        public DateTime ModifiedDate { get; set; }

        public  List<OrderItem> Items { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        
        public OrderStatus Status { get; set; }

        public Order SetItems(List<OrderItem> OrderItems)
        {
            Items = OrderItems;
            return this;
        }

    }
}
