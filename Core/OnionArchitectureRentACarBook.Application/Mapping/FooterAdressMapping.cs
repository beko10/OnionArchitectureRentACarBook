using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class FooterAdressMapping : Profile
{
    public FooterAdressMapping()
    {
        CreateMap<CreateFooterAdressCommandDto, FooterAdress>().ReverseMap();
        CreateMap<UpdateFooterAdressCommandDto, FooterAdress>().ReverseMap();
        CreateMap<FooterAdress, FooterAdressQueryDto>().ReverseMap();
    }
} 