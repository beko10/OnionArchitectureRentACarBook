using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.DeleteAboutCommand;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.AboutValidator;

public class DeleteAboutCommandRequestValidator : AbstractValidator<DeleteAboutCommandRequest>
{
    public DeleteAboutCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.AboutValidationMessages.IdRequired);
    }
}
