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
    public class CreateBrandsCommandHandler
    {
        private readonly IRepository<Brand> _repository;

        public CreateBrandsCommandHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBrandsCommand command)
        {
            await _repository.CreateAsync(new Brand { Name = command.Name, });
        }
    }
}
