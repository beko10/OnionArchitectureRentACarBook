using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.BannerDto;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDto;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class BrandMapping : Profile
{
    public BrandMapping()
    {
        CreateMap<Brand,BannerQueryDto>().ReverseMap();
        CreateMap<Brand,CreateBannerCommandDtoValidator>().ReverseMap();
        CreateMap<Brand,UpdateBannerCommandDto>().ReverseMap();
    }
}
