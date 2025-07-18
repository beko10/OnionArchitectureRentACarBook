using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class CarMapping : Profile
{
    public CarMapping()
    {
        CreateMap<Car, CreateCarCommandDto>().ReverseMap();
        CreateMap<Car,UpdateCarCommandDto>().ReverseMap();
        CreateMap<Car,CarQueryDto>().ReverseMap();
    }
}
