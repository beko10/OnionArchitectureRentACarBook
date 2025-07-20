using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.TestimonialCommands.UpdateTestimonialCommand;

public class UpdateTestimonialCommandRequest : IRequest<UpdateTestimonialCommandResponse>
{
    public UpdateTestimonialCommandDto UpdateTestimonialCommandDtoRequest { get; set; } = null!;
} 