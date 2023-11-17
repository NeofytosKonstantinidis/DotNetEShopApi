namespace EShopApi.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Brand? ParentBrand { get; set; } = null;


        public void UpdateBrand(string? name, Brand? parentBrand)
        {
            Name = name;
            ParentBrand = parentBrand;
        }
    }
}