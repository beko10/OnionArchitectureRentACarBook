using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.FooterAdressCommands.DeleteFooterAdressCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.FooterAdressValidator;

public class DeleteFooterAdressCommandRequestValidator : AbstractValidator<DeleteFooterAdressCommandRequest>
{
    public DeleteFooterAdressCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.FooterAdressValidationMessages.IdRequired);
    }
} 