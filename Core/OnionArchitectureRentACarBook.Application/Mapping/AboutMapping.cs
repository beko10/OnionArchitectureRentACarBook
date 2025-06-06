using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class AboutMapping : Profile 
{
    public AboutMapping()
    {
        CreateMap<About, CreateAboutDto>().ReverseMap();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<About, GetAllAboutDto>().ReverseMap();
        CreateMap<About, GetByIdAboutDto>().ReverseMap();
    }
}
