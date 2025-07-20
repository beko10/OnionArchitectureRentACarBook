using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.PricingValidator;

public class UpdatePricingCommandDtoValidator : AbstractValidator<UpdatePricingCommandDto>
{
    public UpdatePricingCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.PricingValidationMessages.IdRequired);
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.PricingValidationMessages.NameRequired);
    }
} 