using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.DeleteCarFeatureCommand;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarFeatureValidator;

public class DeleteCarFeatureCommandRequestValidator : AbstractValidator<DeleteCarFeatureCommandRequest>
{
    public DeleteCarFeatureCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.CarFeatureValidationMessages.IdRequired);
    }
}