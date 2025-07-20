using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.LocationValidator;

public class UpdateLocationCommandDtoValidator : AbstractValidator<UpdateLocationCommandDto>
{
    public UpdateLocationCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.LocationValidationMessages.IdRequired);
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.LocationValidationMessages.NameRequired);
    }
} 