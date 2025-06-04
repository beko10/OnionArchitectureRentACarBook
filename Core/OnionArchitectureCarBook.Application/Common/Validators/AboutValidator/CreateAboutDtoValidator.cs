using FluentValidation;
using OnionArchitectureCarBook.Application.DTOs.About;
using OnionArchitectureCarBook.Application.Common.Messages; // Eklendi

namespace OnionArchitectureCarBook.Application.Common.Validators.AboutValidator;

public class CreateAboutDtoValidator : AbstractValidator<CreateAboutDto>
{
    public CreateAboutDtoValidator()
    {
        RuleFor(x => x.Title)
                .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.TitleRequired)
                .MinimumLength(5).WithMessage(ValidationMessages.AboutValidationMessages.TitleMinLength)
                .MaximumLength(200).WithMessage(ValidationMessages.AboutValidationMessages.TitleMaxLength);

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.DescriptionRequired)
            .MinimumLength(20).WithMessage(ValidationMessages.AboutValidationMessages.DescriptionMinLength)
            .MaximumLength(1000).WithMessage(ValidationMessages.AboutValidationMessages.DescriptionMaxLength);


        RuleFor(x => x.ImageUrl)
            .Must(BeValidUrl).WithMessage(ValidationMessages.AboutValidationMessages.InvalidImageUrlFormat)
            .When(x => !string.IsNullOrEmpty(x.ImageUrl));
    }

    private static bool BeValidUrl(string? url)
    {
        if (string.IsNullOrEmpty(url)) return true;
        return Uri.TryCreate(url, UriKind.Absolute, out var result)
               && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps);
    }
}