using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.FeatureCommands.DeleteFeatureCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.FeatureValidator;

public class DeleteFeatureCommandRequestValidator : AbstractValidator<DeleteFeatureCommandRequest>
{
    public DeleteFeatureCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.FeatureValidationMessages.IdRequired);
    }
} 