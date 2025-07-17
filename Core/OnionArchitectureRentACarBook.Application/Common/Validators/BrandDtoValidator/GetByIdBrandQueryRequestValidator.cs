using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Query.BrandQueries.GetByIdBrandQuery;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.BrandDtoValidator;

public class GetByIdBrandQueryRequestValidator : AbstractValidator<GetByIdBrandQueryRequest>
{
    public GetByIdBrandQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty().WithMessage(ValidationMessages.BrandValidationMessages.IdRequired);
    }
}
