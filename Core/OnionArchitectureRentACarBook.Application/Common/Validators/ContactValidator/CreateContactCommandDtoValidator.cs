using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.ContactValidator;

public class CreateContactCommandDtoValidator : AbstractValidator<CreateContactCommandDto>
{
    public CreateContactCommandDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.ContactValidationMessages.NameRequired);
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(ValidationMessages.ContactValidationMessages.EmailRequired)
            .EmailAddress().WithMessage(ValidationMessages.CommonValidationMessages.InvalidEmailFormat);
        RuleFor(x => x.Subject)
            .NotEmpty().WithMessage(ValidationMessages.ContactValidationMessages.SubjectRequired);
        RuleFor(x => x.Message)
            .NotEmpty().WithMessage(ValidationMessages.ContactValidationMessages.MessageRequired);
    }
} 