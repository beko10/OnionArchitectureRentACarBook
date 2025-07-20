using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.ServiceValidator;

public class UpdateServiceCommandDtoValidator : AbstractValidator<UpdateServiceCommandDto>
{
    public UpdateServiceCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.ServiceValidationMessages.IdRequired);
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage(ValidationMessages.ServiceValidationMessages.TitleRequired);
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(ValidationMessages.ServiceValidationMessages.DescriptionRequired);
        RuleFor(x => x.IconUrl)
            .NotEmpty().WithMessage(ValidationMessages.ServiceValidationMessages.IconUrlRequired);
    }
} 