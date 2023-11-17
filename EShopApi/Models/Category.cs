namespace EShopApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Category? ParentCategory { get; set; } = null;
        public List<Category>? ChildCategories { get; set; }

        public List<Product>? Products { get; set; }

        public void UpdateCategory(string? Name, Category? ParentCategory, List<Category>? ChildCategories,List<Product>? Products)
        {
            this.Name = Name;
            this.ParentCategory = ParentCategory;
            this.ChildCategories = ChildCategories;
            this.Products = Products;
        }
    }
}