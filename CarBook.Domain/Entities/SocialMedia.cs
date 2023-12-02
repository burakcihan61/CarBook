namespace CarBook.Domain.Entities;

public class SocialMedia
{
    public int SocialMediaID { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}
