using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.ContactValidator;

public class UpdateContactCommandDtoValidator : AbstractValidator<UpdateContactCommandDto>
{
    public UpdateContactCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.ContactValidationMessages.IdRequired);
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