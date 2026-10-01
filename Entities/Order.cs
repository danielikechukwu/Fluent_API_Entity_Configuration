using EF_FluentAPIEntityConfiguration.Enums;

namespace EF_FluentAPIEntityConfiguration.Entities;

public class Order
{
    
    public long id { get; set; }

    public string order_number { get; set; }

    public int customer_id { get; set; }

    public DateTime order_date { get; set; }

    public decimal total_amount { get; set; }

    public bool is_deleted { get; set; }

    public OrderStatus status { get; set; }

    public string shipping_address { get; set; } = null!;

    public string billing_address { get; set; } = null!;

    public Customer customer { get; set; } = null!;

    public ICollection<OrderItem> order_items { get; set; } = new List<OrderItem>();

    public Payment? payment { get; set; }
    
}