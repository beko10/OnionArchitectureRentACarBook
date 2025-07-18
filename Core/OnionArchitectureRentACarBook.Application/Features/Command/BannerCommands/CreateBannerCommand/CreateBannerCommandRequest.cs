using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.BannerDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.CreateBannerCommand;

public class CreateBannerCommandRequest : IRequest<CreateBannerCommandResponse>
{
    public CreateBannerCommandDto CreateBannerCommandDtoRequest { get; set; } = null!;
}
