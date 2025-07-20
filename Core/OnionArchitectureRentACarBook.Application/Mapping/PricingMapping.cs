using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class PricingMapping : Profile
{
    public PricingMapping()
    {
        CreateMap<CreatePricingCommandDto, Pricing>().ReverseMap();
        CreateMap<UpdatePricingCommandDto, Pricing>().ReverseMap();
        CreateMap<Pricing, PricingQueryDto>().ReverseMap();
    }
} 