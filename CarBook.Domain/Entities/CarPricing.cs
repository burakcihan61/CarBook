namespace CarBook.Domain.Entities;

public class CarPricing
{
    public int CarPricingID { get; set; }
    public int CarID { get; set; }
    public Car Car { get; set; } = new Car();
    public int PricingID { get; set; }
    public Pricing Pricing { get; set; } = new Pricing();
    public decimal Amount { get; set; }
}
