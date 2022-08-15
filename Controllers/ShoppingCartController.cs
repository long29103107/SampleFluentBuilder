using FluentBuilder.Builders;
using FluentBuilder.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FluentBuilder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<ShoppingCart>> GetUsingBuilder()
        {
            var shoppingCartBuilder = new ShoppingCartBuilder();
            shoppingCartBuilder.AddId(Guid.NewGuid());
            shoppingCartBuilder.AddItems(new List<Product>());
            shoppingCartBuilder.AddDiscount(2.0);
            shoppingCartBuilder.AddUser(new User());
            var shoppingCart = shoppingCartBuilder.GetShoppingCart();

            return Ok(shoppingCart);
        }
        
        [HttpGet]
        public async Task<ActionResult<ShoppingCart>> GetUsingPluentBuilder()
        {
            var shoppingCart = new ShoppingCartFluentBuilder()
                .WithId(Guid.NewGuid())
                .WithItems(new List<Product>())
                .WithDiscount(3.0)
                .WithUser(new User())
                .Build();
            return Ok(shoppingCart);
        }

        [HttpGet]
        public async Task<ActionResult<Product>> GetProductUsingBuilder()
        {
            var productBuilder = new ProductBuilder();
            productBuilder.AddId(Guid.NewGuid());
            productBuilder.AddName("Lotus");
            productBuilder.AddPrice(20000);
            var product = productBuilder.GetProduct();

            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<Product>> GetProductUsingFluentBuilder()
        {
            var product = new ProductFluentBuilder()
                .WithId(Guid.NewGuid())
                .WithName("Lotus")
                .WithPrice(20000)
                .Build();

            return Ok(product);
        }
    }
}
