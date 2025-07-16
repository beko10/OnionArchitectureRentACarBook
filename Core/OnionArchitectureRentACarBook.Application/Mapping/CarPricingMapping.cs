using AutoMapper;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class CarPricingMapping : Profile
{
    public CarPricingMapping()
    {
        CreateMap<CarPricing, DTOs.CarPricingDto.CarPricingQueryDto>().ReverseMap();
        CreateMap<CarPricing, DTOs.CarPricingDto.CreateCarPricingCommandDto>().ReverseMap();
        CreateMap<CarPricing, DTOs.CarPricingDto.UpdateCarPricingCommandDto>().ReverseMap();
    }
}
