using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.BrandDtoValidator
{
    public class DeleteBrandCommandDtoValidator : AbstractValidator<DeleteBrandCommandDto>
    {
        public DeleteBrandCommandDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage(ValidationMessages.BrandValidationMessages.IdRequired);
        }
    }
}