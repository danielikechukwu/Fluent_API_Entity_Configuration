namespace EF_FluentAPIEntityConfiguration.Entities;

public class Customer
{
    public int id { get; set; }

    public string customer_number { get; set; }

    public string email { get; set; }

    public string phone_number { get; set; }

    public string first_name { get; set; }

    public string last_name { get; set; }

    public bool is_active { get; set; }

    public DateTime created_at { get; set; } = DateTime.UtcNow;

    public ICollection<Address> addresses { get; set; }
    
    public CustomerProfile  profile { get; set; }
}