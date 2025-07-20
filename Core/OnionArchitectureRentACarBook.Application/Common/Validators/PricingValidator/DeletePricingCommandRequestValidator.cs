using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.PricingCommands.DeletePricingCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.PricingValidator;

public class DeletePricingCommandRequestValidator : AbstractValidator<DeletePricingCommandRequest>
{
    public DeletePricingCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.PricingValidationMessages.IdRequired);
    }
} 