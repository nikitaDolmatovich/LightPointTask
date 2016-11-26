using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stock.UI.Models.Entities
{
    public class Product
    {
        public Int32 ProductId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public ICollection<Shop> Shops { get; set; }
    }
}