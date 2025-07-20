using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class ServiceMapping : Profile
{
    public ServiceMapping()
    {
        CreateMap<CreateServiceCommandDto, Service>().ReverseMap();
        CreateMap<UpdateServiceCommandDto, Service>().ReverseMap();
        CreateMap<Service, ServiceQueryDto>().ReverseMap();
    }
} 