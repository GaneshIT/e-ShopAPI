using eShopBusiness.Services;
using eShopEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService category)
        {
            _categoryService = category;
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            return Ok(_categoryService.Add(category));
        }
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            return Ok(_categoryService.Get(id));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_categoryService.GetAll());
        }
        [HttpPut]
        public IActionResult Update(Category category)
        {
            return Ok(_categoryService.Update(category));
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(_categoryService.Delete(id));
        }
    }
}
