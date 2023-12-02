namespace CarBook.Domain.Entities;

public class CarDescription
{
    public int CarDescriptionID { get; set; }
    public int CarID { get; set; }
    public Car Car { get; set; } = new Car();
    public string Details { get; set; } = string.Empty;
}
