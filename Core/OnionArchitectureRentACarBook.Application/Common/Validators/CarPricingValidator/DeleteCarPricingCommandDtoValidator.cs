using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDtos;
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

