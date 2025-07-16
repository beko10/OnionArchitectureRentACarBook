using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarDto;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarValidator
{
    public class DeleteCarCommandDtoValidator : AbstractValidator<DeleteCarCommandDto>
    {
        public DeleteCarCommandDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage(ValidationMessages.CarValidationMessages.IdRequired
                )
                .WithName(nameof(DeleteCarCommandDto.Id));
        }
    }
}