using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Stock.UI.Models.Abstract;
using Stock.UI.Models.Concrete;
using Stock.UI.Models.Entities;
using Stock.UI.Models.ViewModel;


namespace Stock.UI.Controllers
{
    [RoutePrefix("Shop")]
    public class ShopController : ApiController
    {
        private IShopRepository shopRepository;

        public ShopController(IShopRepository repo)
        {
            shopRepository = repo;
        }

        [Route("")]
        public IEnumerable<ShopViewModel> GetAll()
        {
            var shops = shopRepository.Shops.Select(s => new ShopViewModel()
            {
                ShopId = s.ShopId,
                Name = s.Name,
                Address = s.Address,
                Mode = s.Mode
            });
            return shops;
        }

        [Route("{shopId}/Products")]
        public IHttpActionResult GetProducts(Int32 shopId)
        {
            var shop = shopRepository.Shops.FirstOrDefault(p => p.ShopId == shopId);
            if (shop == null)
            {
                return BadRequest();
            }

            var products = shopRepository.Shops.FirstOrDefault(p => p.ShopId == shopId).Products.Select(
                p => new ProductViewModel()
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Description = p.Description
                });
            return Ok(products);
        }
    }
}
