using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stock.UI.Models.Abstract;
using Stock.UI.Models.Entities;


namespace Stock.UI.Models.Concrete
{
    public class EFShopRepository : IShopRepository
    {
        private EFStockContext context = new EFStockContext();

        public IQueryable<Shop> Shops
        {
            get { return context.Shop; }
        }
    }
}