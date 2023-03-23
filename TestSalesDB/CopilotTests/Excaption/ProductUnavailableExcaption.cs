using System;

namespace TestSalesDB.CopilotTests.Excaption
{
    //create ProductUnavailableExcaption class
    public class ProductUnavailableExcaption : Exception
    {
        public ProductUnavailableExcaption(string message) : base(message)
        {
        }
    }
}