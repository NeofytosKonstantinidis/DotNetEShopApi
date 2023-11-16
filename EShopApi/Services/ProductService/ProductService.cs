using EShopApi.Data;
using EShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EShopApi.Services.ProductService
{
    public class ProductService : IProductService
    {
        List<Product> products = new List<Product>();
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> AddProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>?> DeleteProduct(int id)
        {
            Product? product = await _context.Products.FindAsync(id);
            if (product == null) return null;

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProduct(int id)
        {
            Product? product = await _context.Products.FindAsync(id);
            if (product == null) return null;

            return product;
        }

        public async Task<List<Product>> GetProductsList()
        {
            List<Product> p = await _context.Products.ToListAsync();
            return p;
        }
        public async Task<List<Product>> GetProductsList(int pg, int fitInPage)
        {
            List<Product> p = await _context.Products.Skip(pg* fitInPage).Take(fitInPage).ToListAsync();
            return p;
        }

        public async Task<List<Product>?> UpdateProduct(int id, Product request)
        {
            Product? product = await _context.Products.FindAsync(id);
            if (product == null) return null;

            product.UpdateProduct(request.Name, request.Description, request.Price, request.Brand, request.Categories);

            await _context.SaveChangesAsync();

            return await _context.Products.ToListAsync();
        }
    }
}
