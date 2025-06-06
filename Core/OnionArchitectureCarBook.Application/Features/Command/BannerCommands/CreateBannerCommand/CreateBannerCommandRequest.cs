using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.BannerDto;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.CreateBannerCommand;

public class CreateBannerCommandRequest : IRequest<CreateBannerCommandResponse>
{
    public CreateBannerCommandDto CreateBannerCommandDto { get; set; } = null!;
}
