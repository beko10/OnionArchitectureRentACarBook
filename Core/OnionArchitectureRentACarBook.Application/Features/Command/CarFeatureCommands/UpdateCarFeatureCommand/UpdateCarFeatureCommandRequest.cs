using MediatR;

namespace OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.UpdateCarFeatureCommand;

public class UpdateCarFeatureCommandRequest : IRequest<UpdateCarFeatureCommandResponse>
{
    public string?  Id { get; set; } 
}
