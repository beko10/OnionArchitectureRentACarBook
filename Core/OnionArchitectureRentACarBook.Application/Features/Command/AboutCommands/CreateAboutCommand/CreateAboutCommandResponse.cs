using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandResponse
{
    public ResultData<CreateAboutCommandDto> Result { get; set; }
}
