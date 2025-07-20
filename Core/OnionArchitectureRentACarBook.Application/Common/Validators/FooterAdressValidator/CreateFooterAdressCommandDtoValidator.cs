using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.FooterAdressValidator;

public class CreateFooterAdressCommandDtoValidator : AbstractValidator<CreateFooterAdressCommandDto>
{
    public CreateFooterAdressCommandDtoValidator()
    {
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage(ValidationMessages.FooterAdressValidationMessages.DescriptionRequired);
        RuleFor(x => x.Adress)
            .NotEmpty().WithMessage(ValidationMessages.FooterAdressValidationMessages.AdressRequired);
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage(ValidationMessages.FooterAdressValidationMessages.PhoneRequired);
        RuleFor(x => x.Email)
            .NotEmpty().WithMessage(ValidationMessages.FooterAdressValidationMessages.EmailRequired);
    }
} 