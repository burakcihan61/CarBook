namespace CarBook.Domain.Entities;

public class CarFeature
{
    public int CarFeatureID { get; set; }
    public int CarID { get; set; }
    public Car Car { get; set; } = new Car();
    public int FeatureID { get; set; }
    public Feature Feature { get; set; } = new Feature();
    public bool Available { get; set; }
}
