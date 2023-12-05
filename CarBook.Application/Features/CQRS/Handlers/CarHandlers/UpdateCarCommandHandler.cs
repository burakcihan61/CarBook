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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.BrandID);
            value.BigImageUrl = command.BigImageUrl;
            value.BrandID = command.BrandID;
            value.Km = command.Km;
            value.Fuel = command.Fuel;
            value.Luggage = command.Luggage;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Seat = command.Seat;
            value.Transmission = command.Transmission;
            value.Model = command.Model;
            await _repository.UpdateAsync(value);
        }
    }
}
