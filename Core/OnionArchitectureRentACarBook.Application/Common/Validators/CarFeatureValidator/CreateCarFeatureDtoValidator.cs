using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDtos;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarFeatureValidator;

public class CreateCarFeatureDtoValidator : AbstractValidator<CreateCarFeatureDto>
{
    public CreateCarFeatureDtoValidator()
    {
        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage(ValidationMessages.CarFeatureValidationMessages.CarIdRequired)
            .WithName(nameof(CreateCarFeatureDto.CarId));

        RuleFor(x => x.FeatureId)
            .NotEmpty().WithMessage(ValidationMessages.CarFeatureValidationMessages.FeatureIdRequired)
            .WithName(nameof(CreateCarFeatureDto.FeatureId));
    }
}
