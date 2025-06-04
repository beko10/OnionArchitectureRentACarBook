using AutoMapper;
using OnionArchitectureCarBook.Application.DTOs.About;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Application.Mapping;

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
