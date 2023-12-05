using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarResults
{
    public class GetCarWithBrandsResult
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public string BrandName { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string CoverImageUrl { get; set; } = string.Empty;
        public int Km { get; set; }
        public string Transmission { get; set; } = string.Empty;
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; } = string.Empty;
        public string BigImageUrl { get; set; } = string.Empty;
    }
}
