using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDto;
using static OnionArchitectureRentACarBook.Application.Common.Messages.ValidationMessages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarPricingValidator;

public class CreateCarPricingCommandDtoValidator : AbstractValidator<CreateCarPricingCommandDto>
{
    public CreateCarPricingCommandDtoValidator()
    {
        RuleFor(x => x.Amount)
            .GreaterThan(0)
            .WithMessage(CarPricingValidationMessages.AmountPositive)
            .WithName(nameof(CreateCarPricingCommandDto.Amount));

        RuleFor(x => x.CarId)
            .NotEmpty()
            .WithMessage(CarPricingValidationMessages.CarIdRequired)
            .WithName(nameof(CreateCarPricingCommandDto.CarId));

        RuleFor(x => x.PricingId)
            .NotEmpty()
            .WithMessage(CarPricingValidationMessages.PricingIdRequired)
            .WithName(nameof(CreateCarPricingCommandDto.PricingId));
    }
}
