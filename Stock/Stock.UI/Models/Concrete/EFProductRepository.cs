using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stock.UI.Models.Abstract;
using Stock.UI.Models.Entities;

namespace Stock.UI.Models.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFStockContext context = new EFStockContext();

        public IQueryable<Product> Products
        {
            get { return context.Product; }
        }
    }
}