namespace EF_FluentAPIEntityConfiguration.Entities;

public class CustomerProfile
{
    public int customer_id { get; set; }
    
    public DateTime date_of_birth { get; set; }
    
    public string? gender { get; set; }
    
    public string? profile_picture_url { get; set; }
    
    public int loyality_points { get; set; }
    
    public int total_orders_placed { get; set; }
    
    public DateTime?  last_order_date { get; set; }
    
    public bool is_email_verified { get; set; }
    
    public bool is_phone_verified { get; set; }
    
    public DateTime? last_login_at { get; set; }
    
    public DateTime? registered_at { get; set; }

    public Customer customer { get; set; } = null!;
}