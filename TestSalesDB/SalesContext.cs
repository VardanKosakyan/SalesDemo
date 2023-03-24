using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestSalesDB.Model;

namespace TestSalesDB
{
    public class SalesContext : DbContext
    {

        #region Model
        public DbSet<Product> Products { get; set; }       
        public DbSet<Category> Categories { get; set; }
        //TODO For hiearrchi demo
        public DbSet<OptionalProduct> OptionalProducts { get; set; }
        
        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<SaleItem> Sales { get; set; }

        #region Persons
        public DbSet<Person> Persons { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        
        #endregion

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Credit> Credits { get; set; }
       
        #endregion

        #region config
         private const string connectionString = "Data Source=sql-students.volo.local,1466;Initial Catalog=SalesDemo;persist security info=True;User id=vardan.kosakyan;Password=vcurr@456!;TrustServerCertificate=True";
        //private const string connectionString = "Data Source=10.11.36.21;Initial Catalog=SalesDemo;persist security info=True;Integrated Security=true";// User id=tc_general_login;Password=Aa!12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().UseTptMappingStrategy().ToTable("Products");
            modelBuilder.Entity<Product>().OwnsOne(p => p.Price,
                bld =>
                {
                    //  bld.UsePropertyAccessMode(PropertyAccessMode.Field)
                    //bld.Property("Value");
                    //bld.Property("Unit");
                    //bld.ToJson(); allowed ionly in TPH
                    bld.ToTable("Products");

                });

            modelBuilder.Entity<Product>()
                .HasMany<Supplier>(p => p.Suppliers)
                .WithMany(s => s.Products)                
                .UsingEntity<ProductSupply>(                     
                        ps => ps.HasOne(ps => ps.Supplier)
                            .WithMany( s=>s.ProductSupplies)
                            .HasForeignKey( ps=>ps.SupplierId),
                        ps => ps.HasOne(ps => ps.Product)
                            .WithMany(p=>p.ProductSupplies)
                            .HasForeignKey( ps=>ps.ProductId )                       
                       );
                
            //TODO For hiearrchi demo
            modelBuilder.Entity<OptionalProduct>().ToTable("OptionalProducts");


            modelBuilder.Entity<Supplier>().OwnsOne(s => s.CreationInfo, 
                
                bld =>
                {
                    bld.ToJson();
                });

        }
        #endregion

    }
}
