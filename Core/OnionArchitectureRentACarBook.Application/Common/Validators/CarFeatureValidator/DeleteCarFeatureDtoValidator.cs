using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDto;
using OnionArchitectureRentACarBook.Application.Features.Command.CarFeatureCommands.DeleteCarFeatureCommand;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarFeatureValidator;

public class DeleteCarFeatureDtoValidator : AbstractValidator<DeleteCarFeatureCommandDto>
{
    public DeleteCarFeatureDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.CarFeatureValidationMessages.IdRequired);
    }
}