﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestSalesDB.Model
{
    public class Customer
    {
       public  int Id { get; set; }
       public String FirstName { get; set; }
       public String LastName { get; set; }
       public int RewardPoints { get; set; }
       public DateTime CreatedDate { get; set; }
       public DateTime ModifiedDate { get; set; }
       public string GetFullName() => FirstName + " " + LastName;
    }
}
