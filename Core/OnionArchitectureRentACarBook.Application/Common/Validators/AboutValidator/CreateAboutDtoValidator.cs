using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.AboutValidator;

public class CreateAboutDtoValidator : AbstractValidator<CreateAboutCommandDto>
{
    public CreateAboutDtoValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.TitleRequired)
            .MinimumLength(5).WithMessage(ValidationMessages.CommonValidationMessages.MinLengthNotMet)
            .MaximumLength(200).WithMessage(ValidationMessages.CommonValidationMessages.MaxLengthExceeded)
            .Matches(ValidationRegexPatterns.AboutRegexPatterns.TitleCharacters)
            .WithMessage(ValidationMessages.AboutValidationMessages.InvalidTitleCharacters)
            .WithName(nameof(CreateAboutCommandDto.Title));

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.DescriptionRequired)
            .MinimumLength(20).WithMessage(ValidationMessages.CommonValidationMessages.MinLengthNotMet)
            .MaximumLength(1000).WithMessage(ValidationMessages.CommonValidationMessages.MaxLengthExceeded)
            .WithName(nameof(CreateAboutCommandDto.Description));

        RuleFor(x => x.ImageUrl)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.ImageUrlRequired)
            .Must(BeValidImageUrl).WithMessage(ValidationMessages.AboutValidationMessages.InvalidImageUrl)
            .When(x => !string.IsNullOrEmpty(x.ImageUrl))
            .WithName(nameof(CreateAboutCommandDto.ImageUrl));
    }

    private static bool BeValidImageUrl(string? url)
    {
        if (string.IsNullOrEmpty(url)) return false;
        return Uri.TryCreate(url, UriKind.Absolute, out var result)
               && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps)
               && System.Text.RegularExpressions.Regex.IsMatch(url, ValidationRegexPatterns.AboutRegexPatterns.ImageUrl);
    }
}