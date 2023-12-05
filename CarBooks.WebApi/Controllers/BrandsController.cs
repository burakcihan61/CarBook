using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Features.CQRS.Commands.BrandsCommands;
using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandsHandlers;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Queries.BrandsQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBooks.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly CreateBrandsCommandHandler _createBrandsCommandHandler;
        private readonly GetBrandsByIdQueryHandler _getBrandsByIdQueryHandler;
        private readonly GetBrandsQueryHandler _getBrandsQueryHandler;
        private readonly UpdateBrandsCommandHandler _updateBrandsCommandHandler;
        private readonly RemoveBrandsCommandHandler _removeBrandsCommandHandler;

        public BrandsController(
            CreateBrandsCommandHandler createBrandsCommandHandler,
            GetBrandsByIdQueryHandler getBrandsByIdQueryHandler,
            GetBrandsQueryHandler getBrandsQueryHandler,
            UpdateBrandsCommandHandler updateBrandsCommandHandler,
            RemoveBrandsCommandHandler removeBrandsCommandHandler
        )
        {
            _createBrandsCommandHandler = createBrandsCommandHandler;
            _getBrandsByIdQueryHandler = getBrandsByIdQueryHandler;
            _getBrandsQueryHandler = getBrandsQueryHandler;
            _updateBrandsCommandHandler = updateBrandsCommandHandler;
            _removeBrandsCommandHandler = removeBrandsCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var result = await _getBrandsQueryHandler.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrand(int id)
        {
            var result = await _getBrandsByIdQueryHandler.Handle(new GetBrandsByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandsCommand command)
        {
            await _createBrandsCommandHandler.Handle(command);
            return Ok("Hakkımda Bilgisi Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            await _removeBrandsCommandHandler.Handle(new RemoveBrandsCommand(id));
            return Ok("Hakkımda Bilgisi Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateBrandsCommand command)
        {
            await _updateBrandsCommandHandler.Handle(command);
            return Ok("Hakkımda Bilgisi Güncellendi");
        }
    }
}
