using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CategoryCommands.CreateCategoryCommand;

public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
{
    public CreateCategoryCommandDto? CreateCategoryCommandDtoRequest { get; set; }
}
