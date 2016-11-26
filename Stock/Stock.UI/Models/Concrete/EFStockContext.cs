using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Stock.UI.Models.Entities;

namespace Stock.UI.Models.Concrete
{
    public class EFStockContext : DbContext
    {
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}