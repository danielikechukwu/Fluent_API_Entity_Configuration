namespace EF_FluentAPIEntityConfiguration.Entities;

public class Address
{
    public int id { get; set; }
    
    public int customer_id { get; set; }
    
    public Customer customer { get; set; } = null!;
    
    public string line1 { get; set; } = null!;
    
    public string? line2 { get; set; }
    
    public string city { get; set; } = null!;
    
    public string state { get; set; } = null!;
    
    public string zip_code { get; set; } = null!;
    
    public string country { get; set; } = null!;
    
    public bool is_active { get; set; }
    
    public bool is_default_shipping { get; set; } = false;
    
    public bool is_default_billing { get; set; } = false;
}