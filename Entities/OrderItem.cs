namespace EF_FluentAPIEntityConfiguration.Entities;

public class OrderItem
{
    public long order_id { get; set; }

    public int product_id { get; set; }

    public string product_name { get; set; } = null!;

    public string product_sku { get; set; } = null!;

    public string? brand { get; set; }

    public decimal quantity { get; set; }

    public decimal base_price { get; set; }

    public decimal discount_amount { get; set; }

    public decimal tax_amount { get; set; }

    public decimal unit_price { get; set; }

    public decimal line_total { get; set; }

    public Order order { get; set; } = null!;

    public Product product { get; set; } = null!;
    
}