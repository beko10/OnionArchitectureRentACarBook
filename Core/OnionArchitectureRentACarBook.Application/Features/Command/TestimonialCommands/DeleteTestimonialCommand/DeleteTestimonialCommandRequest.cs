using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.TestimonialCommands.DeleteTestimonialCommand;

public class DeleteTestimonialCommandRequest : IRequest<DeleteTestimonialCommandResponse>
{
    public string Id { get; set; } = null!;
} 