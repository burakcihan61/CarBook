namespace CarBook.Domain.Entities;

public class FooterAdress
{
    public int FooterAdressID { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Adress { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
