using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Features.CQRS.Results.BrandsResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandsHandlers
{
    public class GetBrandsQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandsQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBrandsQueryResult>> Handle()
        {
            var result = await _repository.GetAllAsync();
            return result
                .Select(x => new GetBrandsQueryResult { BrandID = x.BrandID, Name = x.Name, })
                .ToList();
        }
    }
}
