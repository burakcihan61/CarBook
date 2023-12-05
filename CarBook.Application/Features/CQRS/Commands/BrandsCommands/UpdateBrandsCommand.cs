using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.BrandsCommands
{
    public class UpdateBrandsCommand
    {
        public int BrandID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
