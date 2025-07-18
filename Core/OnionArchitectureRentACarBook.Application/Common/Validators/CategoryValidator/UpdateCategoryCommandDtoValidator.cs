using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;
using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;
using System.Text.RegularExpressions;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CategoryValidator;

public class UpdateCategoryCommandDtoValidator : AbstractValidator<UpdateCategoryCommandDto>
{
    public UpdateCategoryCommandDtoValidator()
    {
        RuleFor(x => x.Id)
           .NotEmpty()
           .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired)
           .NotNull()
           .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired);

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage(ValidationMessages.CategoryValidationMessages.NameRequired)
            .Length(2, 50)
            .WithMessage(ValidationMessages.CategoryValidationMessages.NameLength)
            .Must(BeValidCategoryName)
            .WithMessage(ValidationMessages.CategoryValidationMessages.NameInvalidChars);
    }

    private bool BeValidCategoryName(string name)
    {
        if (string.IsNullOrEmpty(name))
            return false;

        // ValidationRegexPatterns'dan kategori adı pattern'ını kullan
        return Regex.IsMatch(name, ValidationRegexPatterns.CategoryRegexPatterns.CategoryName);
    }
}
