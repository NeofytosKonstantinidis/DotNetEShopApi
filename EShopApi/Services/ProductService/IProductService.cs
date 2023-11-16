using EShopApi.Models;

namespace EShopApi.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsList();

        Task<Product?> GetProduct (int id);

        Task<List<Product>> AddProduct(Product product);

        Task<List<Product>?> UpdateProduct(int id, Product request);

        Task<List<Product>?> DeleteProduct(int id);
    }
}
