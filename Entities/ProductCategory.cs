namespace EF_FluentAPIEntityConfiguration.Entities;

public class ProductCategory
{
    public int product_id { get; set; }
    
    public int category_id { get; set; }

    public DateTime assigned_at { get; set; } = DateTime.UtcNow;

    public Product product { get; set; } = null!;

    public Category category { get; set; } = null!;
}