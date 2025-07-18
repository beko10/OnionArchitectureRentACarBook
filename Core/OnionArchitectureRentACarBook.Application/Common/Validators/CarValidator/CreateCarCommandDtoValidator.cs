using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;
using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarValidator;

public class CreateCarCommandDtoValidator : AbstractValidator<CreateCarCommandDto>
{
    public CreateCarCommandDtoValidator()
    {
        RuleFor(x => x.Model)
            .NotEmpty().WithMessage(ValidationMessages. CarValidationMessages.ModelRequired)
            .Matches(ValidationRegexPatterns.CarRegexPatterns.Model)
            .WithMessage(ValidationMessages.CarValidationMessages.InvalidModelCharacters)
            .WithName(nameof(CreateCarCommandDto.Model));

        RuleFor(x => x.CoverImageUrl)
            .NotEmpty().WithMessage(ValidationMessages.CarValidationMessages.CoverImageUrlRequired)
            .Must(BeValidImageUrl).WithMessage(ValidationMessages.CarValidationMessages.InvalidImageUrlFormat)
            .WithName(nameof(CreateCarCommandDto.CoverImageUrl));

        RuleFor(x => x.BigImageUrl)
            .NotEmpty().WithMessage(ValidationMessages.CarValidationMessages.BigImageUrlRequired)
            .Must(BeValidImageUrl).WithMessage(ValidationMessages.CarValidationMessages.InvalidImageUrlFormat)
            .WithName(nameof(CreateCarCommandDto.BigImageUrl));

        RuleFor(x => x.Km)
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.CarValidationMessages.InvalidMileage)
            .WithName(nameof(CreateCarCommandDto.Km));

        RuleFor(x => x.Transmission)
            .NotEmpty().WithMessage(ValidationMessages.CarValidationMessages.TransmissionRequired)
            .WithName(nameof(CreateCarCommandDto.Transmission));

        RuleFor(x => x.CarFuelType)
            .NotEmpty().WithMessage(ValidationMessages.CarValidationMessages.FuelTypeRequired)
            .WithName(nameof(CreateCarCommandDto.CarFuelType));

        RuleFor(x => Convert.ToInt32(x.Seat))
            .GreaterThan(0).WithMessage(ValidationMessages.CarValidationMessages.SeatMustBePositive)
            .WithName(nameof(CreateCarCommandDto.Seat));

        RuleFor(x => Convert.ToInt32(x.Luggage))
            .GreaterThanOrEqualTo(0).WithMessage(ValidationMessages.CarValidationMessages.LuggageMustBePositive)
            .WithName(nameof(CreateCarCommandDto.Luggage));

        RuleFor(x => x.BrandId)
            .NotEmpty().WithMessage (ValidationMessages.CarValidationMessages.BrandIdRequired)
            .WithName(nameof(CreateCarCommandDto.BrandId));
    }

    private static bool BeValidImageUrl(string? url)
    {
        if (string.IsNullOrEmpty(url)) return false;

        return Uri.TryCreate(url, UriKind.Absolute, out var result)
            && (result.Scheme == Uri.UriSchemeHttp || result.Scheme == Uri.UriSchemeHttps)
            && System.Text.RegularExpressions.Regex.IsMatch(url, ValidationRegexPatterns.AboutRegexPatterns.ImageUrl);
    }
}
