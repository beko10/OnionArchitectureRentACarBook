using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CategoryCommands.UpdateCategoryCommand;

public class UpdateCategoryCommandRequest : IRequest<UpdateCategoryCommandResponse> 
{
    public UpdateCategoryCommandDto? UpdateCategoryCommandDtoRequest { get; set; }
}
