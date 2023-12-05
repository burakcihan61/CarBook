using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Application.Features.CQRS.Commands.BannerCommands;
using CarBook.Application.Features.CQRS.Commands.BrandsCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.BrandsHandlers
{
    public class UpdateBrandsCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public UpdateBrandsCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBrandsCommand command)
        {
            var value = await _repository.GetByIdAsync(command.BrandID);
            value.Name = command.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
