using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.AboutValidator;

public class DeleteAboutDtoValidator : AbstractValidator<DeleteAboutCommandDto>
{
    public DeleteAboutDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.AboutValidationMessages.IdRequired);
    }
}
