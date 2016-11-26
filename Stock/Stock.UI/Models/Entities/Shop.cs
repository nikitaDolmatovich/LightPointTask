using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock.UI.Models.Entities
{
    public class Shop
    {
        public Int32 ShopId { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Mode { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}