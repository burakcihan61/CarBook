namespace CarBook.Application.Features.CQRS.Results.BrandsResults
{
    public class GetBrandsQueryResult
    {
        public int BrandID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
