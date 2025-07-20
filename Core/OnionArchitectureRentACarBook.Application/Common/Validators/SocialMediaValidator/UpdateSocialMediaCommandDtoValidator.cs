using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.SocialMediaValidator;

public class UpdateSocialMediaCommandDtoValidator : AbstractValidator<UpdateSocialMediaCommandDto>
{
    public UpdateSocialMediaCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.IdRequired);
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.NameRequired);
        RuleFor(x => x.Url)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.UrlRequired);
        RuleFor(x => x.Icon)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.IconRequired);
    }
} 