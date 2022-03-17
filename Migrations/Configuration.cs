using FinalTestWCD.Models;

namespace FinalTestWCD.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalTestWCD.Data.DBProductContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalTestWCD.Data.DBProductContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var categories = new List<Category>
            {
                new Category {CategoryName = "USA" },
                new Category {CategoryName = "RUS"},
                new Category {CategoryName = "VN"},
                new Category {CategoryName = "CN"},
            };
            categories.ForEach(s => context.Categories.AddOrUpdate(s));

            var products = new List<Product>
            {
                new Product { ProductName = "햛 001",   SupplierId = 1, CategoryId=1, QuantityPerUnit=12, UnitPrice=10000, UnitslnStock=10000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=1  },
                new Product { ProductName = "햛 002", SupplierId =2, CategoryId=2 , QuantityPerUnit=13, UnitPrice=20000, UnitslnStock=20000,UnitsOnOrder=1000, ReorderLevel=2,Discontinued=1},
                new Product { ProductName = "햛 003",   SupplierId = 3, CategoryId=3 , QuantityPerUnit=14, UnitPrice=30000, UnitslnStock=10000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=1},
                new Product { ProductName = "햛 004",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
                new Product { ProductName = "햛 005",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
                new Product { ProductName = "햛 006",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
                new Product { ProductName = "햛 007",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
                new Product { ProductName = "햛 008",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
                new Product { ProductName = "햛 009",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
                new Product { ProductName = "햛 010",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
            };
            products.ForEach(s => context.Products.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
