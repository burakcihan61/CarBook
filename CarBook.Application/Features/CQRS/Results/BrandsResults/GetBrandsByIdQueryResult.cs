using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.BrandsResults
{
    public class GetBrandsByIdQueryResult
    {
        public int BrandID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
