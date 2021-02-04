using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSalesDB.Model
{
    public class Person
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }       
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string GetFullName() => FirstName + " " + LastName;
    }
}
