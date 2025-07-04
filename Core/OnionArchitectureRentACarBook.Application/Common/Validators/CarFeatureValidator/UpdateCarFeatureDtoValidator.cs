using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarFeatureDto;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarFeatureValidator;

public class UpdateCarFeatureDtoValidator : AbstractValidator<UpdateCarFeatureDto>
{
    public UpdateCarFeatureDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.CarFeatureValidationMessages.IdRequired)
            .WithName(nameof(UpdateCarFeatureDto.Id));

        RuleFor(x => x.CarId)
            .NotEmpty().WithMessage(ValidationMessages.CarFeatureValidationMessages.CarIdRequired)
            .WithName(nameof(UpdateCarFeatureDto.CarId));

        RuleFor(x => x.FeatureId)
            .NotEmpty().WithMessage(ValidationMessages.CarFeatureValidationMessages.FeatureIdRequired)
            .WithName(nameof(UpdateCarFeatureDto.FeatureId));
    }
}
