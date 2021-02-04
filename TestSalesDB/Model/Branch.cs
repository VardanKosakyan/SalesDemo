using System;
using System.Collections.Generic;
using System.Text;

namespace TestSalesDB.Model
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Decimal MinTemperature { get; set; }
        public Decimal MaxTemperature { get; set; }
    }
}
