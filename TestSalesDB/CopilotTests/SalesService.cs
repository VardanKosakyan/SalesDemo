using System.Collections.Generic;
using System.Linq;
using TestSalesDB.Model;

namespace TestSalesDB.CopilotTests
{
    public class SalesService
    {
        private readonly SalesContext ctx;
    
        public SalesService(SalesContext cntx)
        {
            ctx = cntx;
        }

        public List<SaleItem> GetSales()
        {
            return ctx.Sales.ToList();
        }
        
        //get sales by product name
        //WRONG CONDITION
        /*
        public List<SaleItem> GetSalesByProductName(string productName)
        {
            return ctx.Sales.Where(s => s.ProductName == productName).ToList();
        }
        */
        
        //get sales monthly report
        //WRONG should be group by month
        public List<SaleItem> GetSalesByMonth(int month)
        {
            return ctx.Sales.Where(s => s.Date.Month == month).ToList();
        }
        
        //get sales grouped by month
        //wrong
        public List<SaleItem> GetSalesByMonthGrouped(int month)
        {
            return ctx.Sales.Where(s => s.Date.Month == month)
                .GroupBy(s => s.Date.Month)
                .Select(s => s.First()).ToList();
        }
        
       //get summary sales by monthes
       //current structure is not considered there is no Quntity and Total fields
       //try same in LINK2 objects
       /*
        public List<SaleItem> GetSalesByMonthGroupedSummary(int month)
        {
            return ctx.Sales.Where(s => s.Date.Month == month)
                .GroupBy(s => s.Date.Month)
                .Select(s => new SaleItem
                {
                    Date = s.First().Date,
                    ProductName = s.First().ProductName,
                    Quantity = s.Sum(q => q.Quantity),
                    Total = s.Sum(t => t.Total)
                }).ToList();
        }
        */
       
       //get customers created in last year
        //wrong field names
        /*
        public List<Customer> GetCustomersCreatedLastYear()
        {
            return ctx.Customers.Where(c => c.DateCreated.Year == DateTime.Now.Year - 1).ToList();
        }*/
       
        
    }
}