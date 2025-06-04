using OnionArchitectureCarBook.Application.DTOs.About;

namespace OnionArchitectureCarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandResponse
{
    public ResultData<CreateAboutDto> Result { get; set; }
}
