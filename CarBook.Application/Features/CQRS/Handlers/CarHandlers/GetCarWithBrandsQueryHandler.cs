using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces.CarInterfaces;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithBrandsQueryHandler
    {
        private readonly ICarRepository _repository;

        public GetCarWithBrandsQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<GetCarWithBrandsResult> Handle()
        {
            var result = _repository.GetCarsListWithBrands();
            return result
                .Select(
                    x =>
                        new GetCarWithBrandsResult
                        {
                            BrandName = x.Brand.Name,
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
