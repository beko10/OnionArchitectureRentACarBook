﻿using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;

public class CreateBrandCommandDtoValidator : AbstractValidator<CreateBrandCommandDto>
{
    public CreateBrandCommandDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.CommonValidationMessages.RequiredField)
            .Length(2, 50).WithMessage(ValidationMessages.BrandValidationMessages.NameLength)
            .Matches(ValidationRegexPatterns.CommonRegexPatterns.BasicText)
            .WithMessage(ValidationMessages.BrandValidationMessages.NameInvalidChars)
            .WithName(nameof(CreateBrandCommandDto.Name));
    }
}
