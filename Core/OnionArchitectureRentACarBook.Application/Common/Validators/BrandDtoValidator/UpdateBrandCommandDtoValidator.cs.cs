using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;

public class UpdateBrandCommandDtoValidator : AbstractValidator<UpdateBrandCommandDto>
{
    public UpdateBrandCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .NotEqual(string.Empty).WithMessage(ValidationMessages.BrandValidationMessages.InvalidId)
            .WithName(nameof(UpdateBrandCommandDto.Id));

        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .Length(2, 50).WithMessage(ValidationMessages.BrandValidationMessages.NameLength)
            .Matches(ValidationRegexPatterns.CommonRegexPatterns.BasicText)
            .WithMessage(ValidationMessages.BrandValidationMessages.NameInvalidChars)
            .WithName(nameof(UpdateBrandCommandDto.Name));
    }
}
