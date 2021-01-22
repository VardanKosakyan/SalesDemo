using System;
using System.Collections.Generic;
using System.Text;

namespace TestSalesDB.Model
{
    public class Credit
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal Amount { get; set; }
    }
}
