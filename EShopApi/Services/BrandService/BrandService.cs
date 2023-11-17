using EShopApi.Data;
using EShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EShopApi.Services.BrandService
{
    public class BrandService:IBrandService
    {
        List<Brand> brands = new List<Brand>();
        private readonly DataContext _context;

        public BrandService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Brand>> AddBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();
            return await _context.Brands.ToListAsync();
        }

        public async Task<List<Brand>?> DeleteBrand(int id)
        {
            Brand? brand = await _context.Brands.FindAsync(id);
            if (brand == null) return null;

            _context.Brands.Remove(brand);
            await _context.SaveChangesAsync();
            return await _context.Brands.ToListAsync();
        }

        public async Task<Brand?> GetBrand(int id)
        {
            Brand? brand = await _context.Brands.FindAsync(id);
            if (brand == null) return null;

            return brand;
        }

        public async Task<List<Brand>> GetBrandList()
        {
            List<Brand> b = await _context.Brands.ToListAsync();
            return b;
        }
        public async Task<List<Brand>> GetBrandList(int pg, int fitInPage)
        {
            List<Brand> b = await _context.Brands.Skip(pg * fitInPage).Take(fitInPage).ToListAsync();
            return b;
        }

        public async Task<List<Brand>?> UpdateBrand(int id, Brand request)
        {
            Brand? brand = await _context.Brands.FindAsync(id);
            if (brand == null) return null;

            brand.UpdateBrand(request.Name, request.ParentBrand);

            await _context.SaveChangesAsync();

            return await _context.Brands.ToListAsync();
        }
    }
}

