using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandResponse
{
    public ResultData<CreateAboutDto> Result { get; set; }
}
