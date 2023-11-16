using EShopApi.Models;

namespace EShopApi.Services.BrandService
{
    public interface IBrandService
    {
        Task<List<Brand>> GetBrandList();

        Task<Brand?> GetBrand(int id);

        Task<List<Brand>> AddBrand(Brand brand);

        Task<List<Brand>?> UpdateBrand(int id, Brand brand);

        Task<List<Brand>?> DeleteBrand(int id);
    }
}
