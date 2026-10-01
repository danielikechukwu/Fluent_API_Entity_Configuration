namespace EF_FluentAPIEntityConfiguration.Entities;

public class Product
{
    public int id { get; set; }

    public string name { get; set; }
    
    public string sku { get; set; }
    
    public decimal price { get; set; }

    public bool is_active { get; set; } = true;

    public bool is_deleted { get; set; } = false; // Soft delete flag

    public DateTime created_at { get; set; } = DateTime.UtcNow;
    
    public DateTime? updated_at { get; set; }

    public PriceDetail pricing { get; set; } = null!;
    
    public string? short_description { get; set; }
    
    public string? long_description { get; set; }
    
    public string? brand { get; set; }
    
    public string? main_image_url { get; set; }
    
    public ICollection<ProductCategory> product_categories { get; set; } = new List<ProductCategory>();
    
    public ICollection<OrderItem> order_items { get; set; } = new List<OrderItem>();

}