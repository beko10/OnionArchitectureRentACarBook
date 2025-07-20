using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.PricingValidator;

public class CreatePricingCommandDtoValidator : AbstractValidator<CreatePricingCommandDto>
{
    public CreatePricingCommandDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.PricingValidationMessages.NameRequired);
    }
} 