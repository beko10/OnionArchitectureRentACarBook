﻿using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;
using OnionArchitectureRentACarBook.Application.DTOs.BannerDtos;

public class UpdateBannerCommandDtoValidator : AbstractValidator<UpdateBannerCommandDto>
{
    public UpdateBannerCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .WithName(nameof(UpdateBannerCommandDto.Id));

        RuleFor(x => x.Title)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .Length(2, 100).WithMessage(ValidationMessages.BannerValidationMessages.TitleLength)
            .Matches(ValidationRegexPatterns.BannerRegexPatterns.TitleCharacters)
            .WithMessage(ValidationMessages.BannerValidationMessages.TitleInvalidChars)
            .WithName(nameof(UpdateBannerCommandDto.Title));

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .Length(10, 500).WithMessage(ValidationMessages.BannerValidationMessages.DescriptionLength)
            .WithName(nameof(UpdateBannerCommandDto.Description));

        RuleFor(x => x.VideoUrl)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .Must(BeSupportedVideoUrl).WithMessage(ValidationMessages.BannerValidationMessages.InvalidVideoUrl)
            .WithName(nameof(UpdateBannerCommandDto.VideoUrl));
    }

    private static bool BeSupportedVideoUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url)) return false;

        if (!Uri.TryCreate(url, UriKind.Absolute, out var uri) ||
            (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
            return false;

        return ValidationRegexPatterns.UrlRegexPatterns.SupportedVideoUrls
            .Any(pattern => System.Text.RegularExpressions.Regex.IsMatch(url, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase));
    }
}