using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Results.BrandsResults;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResult>> Handle()
        {
            var result = await _repository.GetAllAsync();
            return result
                .Select(
                    x =>
                        new GetCarQueryResult
                        {
                            BigImageUrl = x.BigImageUrl,
                            BrandID = x.BrandID,
                            CarID = x.CarID,
                            CoverImageUrl = x.CoverImageUrl,
                            Fuel = x.Fuel,
                            Km = x.Km,
                            Luggage = x.Luggage,
                            Model = x.Model,
                            Seat = x.Seat,
                            Transmission = x.Transmission,
                        }
                )
                .ToList();
        }
    }
}
