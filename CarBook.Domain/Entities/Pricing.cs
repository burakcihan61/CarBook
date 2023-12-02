namespace CarBook.Domain.Entities;

public class Pricing
{
    public int PricingID { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<CarPricing> CarPricings { get; set; } = new List<CarPricing>();
}
