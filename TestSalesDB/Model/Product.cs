using System;
using System.Collections.Generic;
using System.Text;

namespace TestSalesDB.Model
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category  { get; set;}
        public Decimal StorageTemperature { get; set; }
      //  public Decimal Price { get; set; }
        public Price Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<Supplier> Suppliers { get; set; }
        public ICollection<ProductSupply> ProductSupplies { get; set; }
    }
}
