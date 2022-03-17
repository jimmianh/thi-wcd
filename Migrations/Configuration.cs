namespace thi_wcd.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using thi_wcd.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<thi_wcd.Data.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(thi_wcd.Data.Context context)
        {
            var products = new List<Product>
            {
                new Product { ProductName = "Áo kid UNIQLO",   SupplierId = 1, CategoryId=1, QuantityPerUnit=12, UnitPrice=10000, UnitslnStock=10000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=1  },
                new Product { ProductName = " UNIQLO kid shoe", SupplierId =2, CategoryId=2 , QuantityPerUnit=13, UnitPrice=20000, UnitslnStock=20000,UnitsOnOrder=1000, ReorderLevel=2,Discontinued=1},
                new Product { ProductName = "Giày Dolce & Gabbana",   SupplierId = 3, CategoryId=3 , QuantityPerUnit=14, UnitPrice=30000, UnitslnStock=10000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=1},
                new Product { ProductName = " God Of War",    SupplierId = 4, CategoryId=4, QuantityPerUnit=15, UnitPrice=40000, UnitslnStock=40000,UnitsOnOrder=1000, ReorderLevel=1,Discontinued=0},
            };
            products.ForEach(s => context.Product.AddOrUpdate(s));

            var categories = new List<Category>
            {
                new Category { CategoryName = "Áo", Description="ABC1", Picture="Anh1" },
                new Category { CategoryName = "Quần Jeans", Description="ABC2", Picture="Anh2"},
                new Category { CategoryName = "Giày", Description="ABC3", Picture="Anh3"},
                new Category { CategoryName = "Áo vest", Description="ABC4", Picture="Anh4"},
            };
            categories.ForEach(s => context.Category.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
