using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.SocialMediaCommands.UpdateSocialMediaCommand;

public class UpdateSocialMediaCommandRequest : IRequest<UpdateSocialMediaCommandResponse>
{
    public UpdateSocialMediaCommandDto UpdateSocialMediaCommandDtoRequest { get; set; } = null!;
} 