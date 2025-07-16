using FluentValidation;
using static OnionArchitectureRentACarBook.Application.Common.Messages.ValidationMessages;

public class DeleteCarPricingCommandDtoValidator : AbstractValidator<DeleteCarPricingCommandDto>
{
    public DeleteCarPricingCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(CarPricingValidationMessages.IdRequired)
            .WithName(nameof(DeleteCarPricingCommandDto.Id));
    }
}

