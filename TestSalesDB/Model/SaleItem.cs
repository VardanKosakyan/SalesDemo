using System;
using System.Collections.Generic;
using System.Text;

namespace TestSalesDB.Model
{
    public class SaleItem
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public int BranchId { get; set; }
        public Branch Branch{ get; set; }


    }
}
