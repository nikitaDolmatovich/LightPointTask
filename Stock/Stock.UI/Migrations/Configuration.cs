namespace Stock.UI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Stock.UI.Models.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<Stock.UI.Models.Concrete.EFStockContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private List<Product> GetProducts(Int32 count, String namePrefix)
        {
            List<Product> products = new List<Product>();

            for (int i = 0; i < count; i++)
            {
                products.Add(new Product()
                {
                    Name = namePrefix + i,
                    Description = "description for " + namePrefix + i
                });
            }

            return products;
        }

        private List<Shop> GetShops()
        {
            List<Shop> shops = new List<Shop>();
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                shops.Add(new Shop()
                {
                    Name = "shop " + i,
                    Address = "Address for " + i,
                    Products = GetProducts(rnd.Next(100), i + " shopProduct"),
                    Mode = "9.00 - 18.00 everyday"
                });
            }

            return shops;
        }

        protected override void Seed(Stock.UI.Models.Concrete.EFStockContext context)
        {
            context.Shop.AddRange(GetShops());
            context.SaveChanges();
        }
    }
}
