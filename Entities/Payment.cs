using EF_FluentAPIEntityConfiguration.Enums;

namespace EF_FluentAPIEntityConfiguration.Entities;

public class Payment
{
    
    public long id { get; set; }
    
    public long order_id { get; set; } // FK, also unique – 1:1
    
    public decimal amount { get; set; }
    
    public DateTime paid_at { get; set; }
    
    public PaymentStatus status { get; set; }
    
    public string payment_reference { get; set; } = null!; // Alternate key
    
    public string provider { get; set; } = null!;
    
    public Order order { get; set; } = null!;
    
}