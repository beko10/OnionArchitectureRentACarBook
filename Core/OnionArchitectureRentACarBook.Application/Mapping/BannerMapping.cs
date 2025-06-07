using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.BannerDto;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class BannerMapping : Profile
{
    public BannerMapping()
    {
        CreateMap<CreateBannerCommandDto,Banner>().ReverseMap();
        CreateMap<UpdateBannerCommandDtoValidator,Banner>().ReverseMap();
        CreateMap<BannerQueryDto,Banner>().ReverseMap();
    }
}
