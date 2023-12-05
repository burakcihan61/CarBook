using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.BrandsCommands
{
    public class RemoveBrandsCommand
    {
        public int Id { get; set; }

        public RemoveBrandsCommand(int id)
        {
            Id = id;
        }
    }
}
