using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.TestimonialCommands.CreateTestimonialCommand;

public class CreateTestimonialCommandRequest : IRequest<CreateTestimonialCommandResponse>
{
    public CreateTestimonialCommandDto CreateTestimonialCommandDtoRequest { get; set; } = null!;
} 