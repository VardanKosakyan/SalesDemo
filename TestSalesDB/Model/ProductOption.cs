using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesDB.Model
{
    public class ProductOption
    {
        public int Id { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public decimal Price { get; set; }
    }
}
