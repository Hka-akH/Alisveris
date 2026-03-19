using AlışVerişş;
using Microsoft.AspNetCore.Mvc;

namespace AlışVeriş_API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        public IActionResult GetProducts()
        {

            var products = new List<string>
            {
                "Laptop",
                "Mouse",
                "Klavye"
            };

            return Ok(products);
        }


        [HttpPost("add")]

        public IActionResult AddProduct(int id)
        {
            Product p = id switch
            {
                1 => new Product("Laptop", 15000),
                2 => new Product("Mouse", 2500),
                3 => new Product("Klavye", 4000),
                _ => null
            };

            if (p == null)
                return BadRequest("Geçersiz Ürün");

            OrderMediator mediator = new OrderMediator();
            mediator.AddProduct(p);

            return Ok("Ürün Başarıyla Eklendi");



        }
    }
}
