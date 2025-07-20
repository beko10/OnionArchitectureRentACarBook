using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FooterAdressCommands.UpdateFooterAdressCommand;

public class UpdateFooterAdressCommandRequest : IRequest<UpdateFooterAdressCommandResponse>
{
    public UpdateFooterAdressCommandDto UpdateFooterAdressCommandDtoRequest { get; set; } = null!;
} 