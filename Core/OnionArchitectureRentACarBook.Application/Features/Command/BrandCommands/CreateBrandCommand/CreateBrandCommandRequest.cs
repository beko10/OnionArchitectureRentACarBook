using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDto;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.CreateBrandCommand;

public class CreateBrandCommandRequest : IRequest<CreateBrandCommandResponse>
{
    public CreateBrandCommandDto CreateBrandCommandDtoRequest { get; set; } = null!;
}
