using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class AboutMapping : Profile 
{
    public AboutMapping()
    {
        CreateMap<About, CreateAboutCommandDto>().ReverseMap();
        CreateMap<About, UpdateAboutCommandDto>().ReverseMap();
        CreateMap<About, GetAllAboutDto>().ReverseMap();
        CreateMap<About, GetByIdAboutDto>().ReverseMap();
    }
}
