using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Command.CategoryCommands.DeleteCategoryCommand;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CategoryValidator;

public class DeleteCategoryCommandRequestValidator : AbstractValidator<DeleteCategoryCommandRequest>
{
    public DeleteCategoryCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired)
            .NotNull()
            .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired);
    }
}
