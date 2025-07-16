using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDto;
using static OnionArchitectureRentACarBook.Application.Common.Messages.ValidationMessages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarPricingValidator;

public class UpdateCarPricingCommandDtoValidator : AbstractValidator<UpdateCarPricingCommandDto>
{
    public UpdateCarPricingCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(CarPricingValidationMessages.IdRequired)
            .WithName(nameof(UpdateCarPricingCommandDto.Id));

        RuleFor(x => x.Amount)
            .GreaterThan(0)
            .WithMessage(CarPricingValidationMessages.AmountPositive)
            .WithName(nameof(UpdateCarPricingCommandDto.Amount));

        RuleFor(x => x.CarId)
            .NotEmpty()
            .WithMessage(CarPricingValidationMessages.CarIdRequired)
            .WithName(nameof(UpdateCarPricingCommandDto.CarId));

        RuleFor(x => x.PricingId)
            .NotEmpty()
            .WithMessage(CarPricingValidationMessages.PricingIdRequired)
            .WithName(nameof(UpdateCarPricingCommandDto.PricingId));
    }
}
