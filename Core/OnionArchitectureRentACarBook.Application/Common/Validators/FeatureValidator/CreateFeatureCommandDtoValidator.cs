using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.FeatureDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.FeatureValidator;

public class CreateFeatureCommandDtoValidator : AbstractValidator<CreateFeatureCommandDto>
{
    public CreateFeatureCommandDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.FeatureValidationMessages.NameRequired);
    }
} 