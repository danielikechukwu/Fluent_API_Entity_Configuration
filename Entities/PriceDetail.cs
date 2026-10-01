namespace EF_FluentAPIEntityConfiguration.Entities;

public class PriceDetail
{
    public decimal base_price { get; set; }
    
    public decimal discount_amount { get; set; }
    
    public decimal tax_amount { get; set; }
    
    public decimal final_price { get; set; }

    public string? currency { get; set; } = "NGN";
}