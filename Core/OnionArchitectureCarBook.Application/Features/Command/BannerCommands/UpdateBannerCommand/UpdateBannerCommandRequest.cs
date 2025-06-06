using MediatR;
using OnionArchitectureCarBook.Application.DTOs.BannerDto;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.UpdateBannerCommand;

public class UpdateBannerCommandRequest : IRequest<UpdateBannerCommandResponse>
{
    public string? Id { get; set; }
}
