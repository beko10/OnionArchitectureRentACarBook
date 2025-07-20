using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.ContactCommands.DeleteContactCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.ContactValidator;

public class DeleteContactCommandRequestValidator : AbstractValidator<DeleteContactCommandRequest>
{
    public DeleteContactCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.ContactValidationMessages.IdRequired);
    }
} 