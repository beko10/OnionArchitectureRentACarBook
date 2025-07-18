using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.CreateBrandCommand;

public class CreateBrandCommandRequest : IRequest<CreateBrandCommandResponse>
{
    public CreateBrandCommandDto CreateBrandCommandDtoRequest { get; set; } = null!;
}
