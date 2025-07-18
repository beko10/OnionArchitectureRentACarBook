using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CategoryDtos;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CategoryValidator;

public class DeleteCategoryCommandDtoValidator : AbstractValidator<DeleteCategoryCommandDto>
{
    public DeleteCategoryCommandDtoValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired)
            .NotNull()
            .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired);
    }
}
