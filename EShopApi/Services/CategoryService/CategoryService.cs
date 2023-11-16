using EShopApi.Data;
using EShopApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EShopApi.Services.CategoryService
{
    public class CategoryService:ICategoryService
    {
        List<Category> categories = new List<Category>();
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> AddCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return await _context.Categories.ToListAsync();
        }

        public async Task<List<Category>?> DeleteCategory(int id)
        {
            Category? category = await _context.Categories.FindAsync(id);
            if (category == null) return null;

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetCategory(int id)
        {
            Category? category = await _context.Categories.FindAsync(id);
            if (category == null) return null;

            return category;
        }

        public async Task<List<Category>> GetCategoryList()
        {
            List<Category> c = await _context.Categories.ToListAsync();
            return c;
        }
        public async Task<List<Category>> GetCategoryList(int pg, int fitInPage)
        {
            List<Category> p = await _context.Categories.Skip(pg * fitInPage).Take(fitInPage).ToListAsync();
            return p;
        }

        public async Task<List<Category>?> UpdateCategory(int id, Category request)
        {
            Category? category = await _context.Categories.FindAsync(id);
            if (category == null) return null;

            category.UpdateCategory(request.Name, request.ParentCategory, request.ChildCategories);

            await _context.SaveChangesAsync();

            return await _context.Categories.ToListAsync();
        }
    }
}

