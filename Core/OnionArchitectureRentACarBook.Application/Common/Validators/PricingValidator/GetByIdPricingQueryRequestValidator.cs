using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.PricingQueries.GetByIdPricingQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.PricingValidator;

public class GetByIdPricingQueryRequestValidator : AbstractValidator<GetByIdPricingQueryRequest>
{
    public GetByIdPricingQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.PricingValidationMessages.IdRequired);
    }
} 