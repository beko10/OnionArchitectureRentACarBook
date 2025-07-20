using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.LocationValidator;

public class CreateLocationCommandDtoValidator : AbstractValidator<CreateLocationCommandDto>
{
    public CreateLocationCommandDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.LocationValidationMessages.NameRequired);
    }
} 