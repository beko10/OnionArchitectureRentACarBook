using AutoMapper;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class CarPricingMapping : Profile
{
    public CarPricingMapping()
    {
        CreateMap<CarPricing, DTOs.CarPricingDtos.CarPricingQueryDto>().ReverseMap();
        CreateMap<CarPricing, DTOs.CarPricingDtos.CreateCarPricingCommandDto>().ReverseMap();
        CreateMap<CarPricing, DTOs.CarPricingDtos.UpdateCarPricingCommandDto>().ReverseMap();
    }
}
