using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class LocationMapping : Profile
{
    public LocationMapping()
    {
        CreateMap<CreateLocationCommandDto, Location>().ReverseMap();
        CreateMap<UpdateLocationCommandDto, Location>().ReverseMap();
        CreateMap<Location, LocationQueryDto>().ReverseMap();
    }
} 