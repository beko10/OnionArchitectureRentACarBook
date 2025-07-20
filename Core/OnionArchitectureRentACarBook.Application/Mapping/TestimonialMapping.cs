using AutoMapper;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Mapping;

public class TestimonialMapping : Profile
{
    public TestimonialMapping()
    {
        CreateMap<CreateTestimonialCommandDto, Testimonial>().ReverseMap();
        CreateMap<UpdateTestimonialCommandDto, Testimonial>().ReverseMap();
        CreateMap<Testimonial, TestimonialQueryDto>().ReverseMap();
    }
} 