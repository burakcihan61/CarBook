using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Commands.BrandsCommands;
using CarBook.Application.Features.CQRS.Commands.CarCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(
                new Car
                {
                    Km = command.Km,
                    CoverImageUrl = command.CoverImageUrl,
                    Fuel = command.Fuel,
                    Luggage = command.Luggage,
                    BigImageUrl = command.BigImageUrl,
                    BrandID = command.BrandID,
                    Seat = command.Seat,
                    Transmission = command.Transmission,
                    Model = command.Model,
                }
            );
        }
    }
}
