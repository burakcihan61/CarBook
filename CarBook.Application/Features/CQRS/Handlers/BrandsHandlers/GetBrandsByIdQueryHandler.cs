using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Application.Features.CQRS.Queries.BrandsQueries;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Features.CQRS.Results.BrandsResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandsHandlers
{
    public class GetBrandsByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandsByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandsByIdQueryResult> Handle(GetBrandsByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            if (value is null)
            {
                return null;
            }
            return new GetBrandsByIdQueryResult { BrandID = value.BrandID, Name = value.Name, };
        }
    }
}
