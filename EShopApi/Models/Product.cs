namespace EShopApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; } = 0;

        public Brand? Brand { get; set; }

        public List<Category>? Categories { get; set; }

        public void UpdateProduct(string? Name, string? Description, float Price, Brand? Brand, List<Category>? Categories)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Brand = Brand;
            this.Categories = Categories;
        }
    }
}
