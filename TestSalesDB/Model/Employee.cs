using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesDB.Model
{
    public class Employee : Person
    {
        public int BranchId { get; set; }
        public  Branch Branch { get; set; }
    }
}
