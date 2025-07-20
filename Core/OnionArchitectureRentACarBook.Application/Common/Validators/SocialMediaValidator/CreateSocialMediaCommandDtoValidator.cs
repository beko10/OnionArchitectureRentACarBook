using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.SocialMediaValidator;

public class CreateSocialMediaCommandDtoValidator : AbstractValidator<CreateSocialMediaCommandDto>
{
    public CreateSocialMediaCommandDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.NameRequired);
        RuleFor(x => x.Url)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.UrlRequired);
        RuleFor(x => x.Icon)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.IconRequired);
    }
} 