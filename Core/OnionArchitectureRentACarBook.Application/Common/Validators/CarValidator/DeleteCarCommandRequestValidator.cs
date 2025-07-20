using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;
using OnionArchitectureRentACarBook.Application.Features.Command.CarCommands.DeleteCarCommand;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarValidator;

public class DeleteCarCommandRequestValidator : AbstractValidator<DeleteCarCommandRequest>
{
    public DeleteCarCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.CarValidationMessages.IdRequired
            )
            .WithName(nameof(DeleteCarCommandDto.Id));
    }
}