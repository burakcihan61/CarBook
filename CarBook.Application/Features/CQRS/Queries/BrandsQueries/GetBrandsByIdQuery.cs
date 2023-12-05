using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.BrandsQueries
{
    public class GetBrandsByIdQuery
    {
        public int Id { get; set; }

        public GetBrandsByIdQuery(int id)
        {
            Id = id;
        }
    }
}
