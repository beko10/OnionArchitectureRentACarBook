using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class FeatureMapping : Profile
{
    public FeatureMapping()
    {
        CreateMap<CreateFeatureCommandDto, Feature>().ReverseMap();
        CreateMap<UpdateFeatureCommandDto, Feature>().ReverseMap();
        CreateMap<Feature, FeatureQueryDto>().ReverseMap();
    }
} 