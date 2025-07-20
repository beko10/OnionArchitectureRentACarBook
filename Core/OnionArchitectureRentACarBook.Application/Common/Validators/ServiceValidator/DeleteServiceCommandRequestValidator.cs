using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.ServiceCommands.DeleteServiceCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.ServiceValidator;

public class DeleteServiceCommandRequestValidator : AbstractValidator<DeleteServiceCommandRequest>
{
    public DeleteServiceCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.ServiceValidationMessages.IdRequired);
    }
} 