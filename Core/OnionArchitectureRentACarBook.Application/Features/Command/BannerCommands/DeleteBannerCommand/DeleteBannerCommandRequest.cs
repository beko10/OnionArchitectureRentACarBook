using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.DeleteBannerCommand;

public class DeleteBannerCommandRequest : IRequest<DeleteBannerCommandResponse>
{
    public string Id { get; set; } = null!;
}

