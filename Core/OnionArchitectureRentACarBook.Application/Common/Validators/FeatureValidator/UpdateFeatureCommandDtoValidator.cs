using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.FeatureValidator;

public class UpdateFeatureCommandDtoValidator : AbstractValidator<UpdateFeatureCommandDto>
{
    public UpdateFeatureCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.FeatureValidationMessages.IdRequired);
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.FeatureValidationMessages.NameRequired);
    }
} 