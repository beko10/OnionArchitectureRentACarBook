using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.LocationCommands.DeleteLocationCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.LocationValidator;

public class DeleteLocationCommandRequestValidator : AbstractValidator<DeleteLocationCommandRequest>
{
    public DeleteLocationCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.LocationValidationMessages.IdRequired);
    }
} 