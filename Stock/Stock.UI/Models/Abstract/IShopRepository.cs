using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.UI.Models.Entities;

namespace Stock.UI.Models.Abstract
{
    public interface IShopRepository
    {
        IQueryable<Shop> Shops { get; }
    }
}
