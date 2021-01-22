using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesDB.Model
{
    public class OptionalProduct : Product
    {
        public string OptionsDescription { get; set; }
        public ICollection<ProductOption> Options { get; set; }
    }
}
