namespace EF_FluentAPIEntityConfiguration.Entities;

public class Category
{
    public int id { get; set; }
    
    public string name { get; set; }
    
    public string description { get; set; }
    
    public bool is_active { get; set; }
    
    public ICollection<ProductCategory> product_categories { get; set; } = new List<ProductCategory>();
}