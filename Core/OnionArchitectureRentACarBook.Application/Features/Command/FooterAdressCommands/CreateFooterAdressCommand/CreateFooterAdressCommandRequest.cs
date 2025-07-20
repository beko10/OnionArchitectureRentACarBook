using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FooterAdressCommands.CreateFooterAdressCommand;

public class CreateFooterAdressCommandRequest : IRequest<CreateFooterAdressCommandResponse>
{
    public CreateFooterAdressCommandDto CreateFooterAdressCommandDtoRequest { get; set; } = null!;
} 