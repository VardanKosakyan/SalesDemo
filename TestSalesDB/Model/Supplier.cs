using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesDB.Model
{
    public class Supplier
    {
        public int Id { get;  set; }
        public String Name { get; set; }
        /*
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        */
        public MetaInfo CreationInfo { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<ProductSupply> ProductSupplies { get; set; }
    }
}
