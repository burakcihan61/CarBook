using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Queries.BrandsQueries;
using CarBook.Application.Features.CQRS.Queries.CarQueries;
using CarBook.Application.Features.CQRS.Results.BrandsResults;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            if (value is null)
            {
                return null;
            }
            return new GetCarByIdQueryResult()
            {
                BrandID = value.BrandID,
                Km = value.Km,
                Model = value.Model,
                Seat = value.Seat,
                Transmission = value.Transmission,
                BigImageUrl = value.BigImageUrl,
                CarID = value.CarID,
                CoverImageUrl = value.CoverImageUrl,
                Fuel = value.Fuel,
                Luggage = value.Luggage,
            };
        }
    }
}
