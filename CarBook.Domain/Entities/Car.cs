namespace CarBook.Domain.Entities;

public class Car
{
    public int CarID { get; set; }
    public int BrandID { get; set; }
    public Brand Brand { get; set; } = new Brand();
    public string Model { get; set; } = string.Empty;
    public string CoverImageUrl { get; set; } = string.Empty;
    public int Km { get; set; }
    public string Transmission { get; set; } = string.Empty;
    public byte Seat { get; set; }
    public byte Luggage { get; set; }
    public string Fuel { get; set; } = string.Empty;
    public string BigImageUrl { get; set; } = string.Empty;
    public List<CarFeature> CarFeatures { get; set; } = new List<CarFeature>();
    public List<CarDescription> CarDescriptions { get; set; } = new List<CarDescription>();
    public List<CarPricing> CarPricings { get; set; } = new List<CarPricing>();
}
