using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;

public class UpdateAboutDtoValidator : AbstractValidator<UpdateAboutCommandDto>
{
    public UpdateAboutDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .WithName(nameof(UpdateAboutCommandDto.Id));

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.TitleRequired)
            .MinimumLength(5).WithMessage(ValidationMessages.CommonValidationMessages.MinLengthNotMet)
            .MaximumLength(200).WithMessage(ValidationMessages.CommonValidationMessages.MaxLengthExceeded)
            .Matches(ValidationRegexPatterns.AboutRegexPatterns.TitleCharacters)
            .WithMessage(ValidationMessages.AboutValidationMessages.InvalidTitleCharacters)
            .WithName(nameof(UpdateAboutCommandDto.Title));

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.DescriptionRequired)
            .MinimumLength(20).WithMessage(ValidationMessages.CommonValidationMessages.MinLengthNotMet)
            .MaximumLength(1000).WithMessage(ValidationMessages.CommonValidationMessages.MaxLengthExceeded)
            .WithName(nameof(UpdateAboutCommandDto.Description));

        RuleFor(x => x.ImageUrl)
            .NotEmpty().WithMessage(ValidationMessages.AboutValidationMessages.ImageUrlRequired)
            .Must(BeValidImageUrl).WithMessage(ValidationMessages.AboutValidationMessages.InvalidImageUrl)
            .When(x => !string.IsNullOrWhiteSpace(x.ImageUrl))
            .WithName(nameof(UpdateAboutCommandDto.ImageUrl));
    }

    private static bool BeValidImageUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url)) return false;
        return Uri.TryCreate(url, UriKind.Absolute, out Uri result)
               && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps)
               && System.Text.RegularExpressions.Regex.IsMatch(url, ValidationRegexPatterns.AboutRegexPatterns.ImageUrl);
    }
}