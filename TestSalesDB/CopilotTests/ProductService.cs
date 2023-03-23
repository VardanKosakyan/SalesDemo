using System;
using System.Collections.Generic;
using System.Linq;
using TestSalesDB.CopilotTests.Excaption;
using TestSalesDB.Model;

namespace TestSalesDB.CopilotTests
{
    public class ProductService
    {
        //field sales context
        private SalesContext context;
       //ctor inject SalesContext
        public ProductService(SalesContext context)
        {
            this.context = context;
        }
        
        //ctor inject SalesContext and SalesService
        public ProductService(SalesContext context, SalesService salesService)
        {
            this.context = context;
        }
        
        //validate product (all fields are requred) return error code
        /* structure not consiidered*/
        public int ValidateProduct(Product product)
        {
            if (product.Name == null)
            {
                return 1;
            }
            
            if (product.Price == 0)
            {
                return 2;
            }
            if (product.Quantity == 0)
            {
                return 3;
            }
            if (product.Category == null)
            {
                return 4;
            }
            return 0;
        }
        
        //create product (validate and check name uniqueness)
        public void CreateProduct(Product product)
        {
            //check name uniqueness
            if (context.Products.Any(p => p.Name == product.Name))
            {
                throw new Exception("Product with this name already exists");
            }
            int errorCode = ValidateProduct(product);
            if (errorCode == 0)
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Product validation failed");
            }
        }
        
        //Sell product (check quantity)
        //structure is not considered,  products does not added to sales
        public void SellProduct(Product product, int quantity)
        {
            if (product.Quantity < quantity)
            {
                throw new Exception("Not enough products");
            }
            product.Quantity -= quantity;
            context.SaveChanges();
        }
        
        //create saes BL based on generated lcode
        public void SellProductBL(Product product, int quantity)
        {
            //validate product
            int errorCode = ValidateProduct(product);
            if (errorCode != 0)
            {
                throw new Exception("Product validation failed");
            }
            //check product existance by id
            if (!context.Products.Any(p => p.Id == product.Id))
            {
                throw new ProductUnavailableExcaption("Product does not exist");
            }
            //check product quantity in stock
            if (product.Quantity < quantity)
            {
                throw new Exception("Not enough products");
            }
            
           
            //transaction start
            using (var transaction = context.Database.BeginTransaction())
            {

                product.Quantity -= quantity;
                context.SaveChanges();
                
                //add product sale
                var sale = new Sale()
                {
                    ProductId = product.Id,
                    Quantity = quantity,
                    Date = DateTime.Now
                };
                context.Sales.Add(sale);
                
                //commit transaction
                transaction.Commit();
            }
        }
        
        //get products by category and subcategory
        //incorrect structure
        public IEnumerable<Product> GetProductsByCategory(string category, string subcategory)
        {
            return context.Products.Where(p => p.Category == category && p.Subcategory == subcategory);
        }
        
        //get products inside category branch
        //incorrect structure
        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return context.Products.Where(p => p.Category == category);
        }
        
        
    }
}