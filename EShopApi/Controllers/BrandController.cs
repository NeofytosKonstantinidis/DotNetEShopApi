using EShopApi.Models;
using EShopApi.Services.BrandService;
using Microsoft.AspNetCore.Mvc;

namespace EShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Brand>>> GetBrandList()
        {
            return await _brandService.GetBrandList();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            Brand? result = await _brandService.GetBrand(id);
            if (result == null) return NotFound("Brand not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Brand>>> AddBrand(Brand brand)
        {
            List<Brand> result = await _brandService.AddBrand(brand);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Brand>>> UpdateBrandt(int id, Brand request)
        {
            List<Brand>? result = await _brandService.UpdateBrand(id, request);
            if (result == null) return NotFound("Brand not found.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Brand>>> DeleteBrand(int id)
        {
            List<Brand>? result = await _brandService.DeleteBrand(id);
            if (result == null) return NotFound("Brand not found.");

            return Ok(result);
        }
    }
}
