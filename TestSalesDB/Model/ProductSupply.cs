using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesDB.Model
{
    public class ProductSupply
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int ProductId { get; set; }
        
        public bool IsPrimary { get; set; }
        public Product Product { get; set; }
        public Supplier Supplier { get; set; }
    }
}
