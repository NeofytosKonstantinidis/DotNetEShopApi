using EShopApi.Models;
using EShopApi.Services.CategoryService;
using Microsoft.AspNetCore.Mvc;

namespace EShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategoryList()
        {
            return await _categoryService.GetCategoryList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            Category? result = await _categoryService.GetCategory(id);
            if (result == null) return NotFound("Category not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Category>>> AddCategory(Category category)
        {
            List<Category> result = await _categoryService.AddCategory(category);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Category>>> UpdateCategoryt(int id, Category request)
        {
            List<Category>? result = await _categoryService.UpdateCategory(id, request);
            if (result == null) return NotFound("Category not found.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Category>>> DeleteCategory(int id)
        {
            List<Category>? result = await _categoryService.DeleteCategory(id);
            if (result == null) return NotFound("Category not found.");

            return Ok(result);
        }
    }
}
