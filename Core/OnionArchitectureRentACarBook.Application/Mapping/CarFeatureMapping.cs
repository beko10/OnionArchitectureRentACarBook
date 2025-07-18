using AutoMapper;
using OnionArchitectureRentACarBook.Application.Common.Validators.CarFeatureValidator;
using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class CarFeatureMapping : Profile
{
    public CarFeatureMapping()
    {
        CreateMap<CarFeature, CarFeatureQueryDto>().ReverseMap();
        CreateMap<CarFeature,CreateCarFeatureDtoValidator>().ReverseMap();
        CreateMap<CarFeature, UpdateCarFeatureDto>().ReverseMap();
    }
}

