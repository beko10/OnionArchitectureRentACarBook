using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Query.CategoryQueries.GetByIdCategoryQuery;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CategoryValidator;

public class GetByIdCategoryQueryRequestValidator : AbstractValidator<GetByIdCategoryQueryRequest>
{
    public GetByIdCategoryQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired)
            .NotNull()
            .WithMessage(ValidationMessages.CategoryValidationMessages.IdRequired);
    }
}
