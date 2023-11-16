namespace EShopApi.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Brand? ParentBrand { get; set; } = null;
        public List<Brand>? ChildBrands { get; set; }

        public void UpdateBrand(string? name, Brand? parentBrand, List<Brand>? childBrands)
        {
            Name = name;
            ParentBrand = parentBrand;
            ChildBrands = childBrands;
        }
    }
}