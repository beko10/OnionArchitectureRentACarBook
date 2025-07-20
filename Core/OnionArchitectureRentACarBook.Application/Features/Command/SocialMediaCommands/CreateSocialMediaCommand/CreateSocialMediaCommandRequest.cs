using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.SocialMediaCommands.CreateSocialMediaCommand;

public class CreateSocialMediaCommandRequest : IRequest<CreateSocialMediaCommandResponse>
{
    public CreateSocialMediaCommandDto CreateSocialMediaCommandDtoRequest { get; set; } = null!;
} 