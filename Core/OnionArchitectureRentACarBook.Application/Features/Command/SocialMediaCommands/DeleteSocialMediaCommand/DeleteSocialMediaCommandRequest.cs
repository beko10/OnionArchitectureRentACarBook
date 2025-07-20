using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.SocialMediaCommands.DeleteSocialMediaCommand;

public class DeleteSocialMediaCommandRequest : IRequest<DeleteSocialMediaCommandResponse>
{
    public string Id { get; set; } = null!;
} 