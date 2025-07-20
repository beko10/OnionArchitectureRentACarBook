using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class SocialMediaMapping : Profile
{
    public SocialMediaMapping()
    {
        CreateMap<CreateSocialMediaCommandDto, SocialMedia>().ReverseMap();
        CreateMap<UpdateSocialMediaCommandDto, SocialMedia>().ReverseMap();
        CreateMap<SocialMedia, SocialMediaQueryDto>().ReverseMap();
    }
} 