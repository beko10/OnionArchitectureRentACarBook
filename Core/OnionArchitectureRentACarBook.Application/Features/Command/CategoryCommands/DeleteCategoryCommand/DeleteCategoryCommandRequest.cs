using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CategoryCommands.DeleteCategoryCommand;

public class DeleteCategoryCommandRequest : IRequest<DeleteCategoryCommandResponse>
{
    public string? Id { get; set; }

}
