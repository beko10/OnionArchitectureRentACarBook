using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.AboutValidator;

public class UpdateAboutDtoValidator : AbstractValidator<UpdateAboutDto>
{
    public UpdateAboutDtoValidator()
    {
        RuleFor(x => x.Id).NotEmpty(); 

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.TitleRequired)
            .MinimumLength(5).WithMessage(ValidationMessages.AboutValidationMessages.TitleMinLength)
            .MaximumLength(200).WithMessage(ValidationMessages.AboutValidationMessages.TitleMaxLength);

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.DescriptionRequired)
            .MinimumLength(20).WithMessage(ValidationMessages.AboutValidationMessages.DescriptionMinLength)
            .MaximumLength(1000).WithMessage(ValidationMessages.AboutValidationMessages.DescriptionMaxLength);

        RuleFor(x => x.ImageUrl)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.ImageUrlRequired)
            .Must(BeValidUrl).WithMessage(ValidationMessages.AboutValidationMessages.InvalidImageUrlFormat)
            .When(x => !string.IsNullOrWhiteSpace(x.ImageUrl));
    }
    private static bool BeValidUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url)) return true;
        return Uri.TryCreate(url, UriKind.Absolute, out Uri result)
               && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
    }
}
