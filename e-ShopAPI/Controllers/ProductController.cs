using eShopBusiness.Services;
using eShopEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productservice;
        public ProductController(ProductService productservice)
        {
            _productservice = productservice;
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
           object result= _productservice.Add(product);
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            object result = _productservice.GetAll();
            return Ok(result);
        }
    }
}
