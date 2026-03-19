using AlışVerişş;
using Microsoft.AspNetCore.Mvc;

namespace AlışVeriş_API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IOrderMediator _mediator;
        public ProductController(IOrderMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
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
            Product? p = id switch
            {
                1 => new Product("Laptop", 15000),
                2 => new Product("Mouse", 2500),
                3 => new Product("Klavye", 4000),
                _ => null
            };

            if (p == null)
                return BadRequest("Geçersiz Ürün");

            OrderMediator mediator = new OrderMediator();
            _mediator.AddProduct(p);

            return Ok("Ürün Başarıyla Eklendi");

        }

        [HttpPost("remove")]
        public IActionResult RemoveProduct(int id)
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

            _mediator.RemoveProduct(p);

            return Ok("Ürün Çıkarıldı");
        }
        [HttpGet("cart")]
        public IActionResult GetCart()
        {
            var cart = CartManager.Instance.Cart;
            return Ok(cart.Products);
        }

        [HttpPost("pay")]
        public IActionResult Pay(int method)
        {
            _mediator.MakePayment(method);
            return Ok("Ödeme Tamamlandı");
        }
    }
}
