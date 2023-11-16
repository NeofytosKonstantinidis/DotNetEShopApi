using EShopApi.Models;

namespace EShopApi.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoryList();

        Task<Category?> GetCategory(int id);

        Task<List<Category>> AddCategory(Category category);

        Task<List<Category>?> UpdateCategory(int id, Category category);

        Task<List<Category>?> DeleteCategory(int id);
    }
}
