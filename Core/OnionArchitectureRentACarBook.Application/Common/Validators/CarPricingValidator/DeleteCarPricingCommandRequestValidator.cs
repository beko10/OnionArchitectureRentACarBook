using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.CarPricingDtos;
using OnionArchitectureRentACarBook.Application.Features.Command.CarPricingCommand.DeleteCarPricingCommand;
using static OnionArchitectureRentACarBook.Application.Common.Messages.ValidationMessages;

public class DeleteCarPricingCommandRequestValidator : AbstractValidator<DeleteCarPricingCommandRequest>
{
    public DeleteCarPricingCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(CarPricingValidationMessages.IdRequired)
            .WithName(nameof(DeleteCarPricingCommandDto.Id));
    }
}

