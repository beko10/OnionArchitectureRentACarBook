using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class ContactMapping : Profile
{
    public ContactMapping()
    {
        CreateMap<CreateContactCommandDto, Contact>().ReverseMap();
        CreateMap<UpdateContactCommandDto, Contact>().ReverseMap();
        CreateMap<Contact, ContactQueryDto>().ReverseMap();
    }
} 