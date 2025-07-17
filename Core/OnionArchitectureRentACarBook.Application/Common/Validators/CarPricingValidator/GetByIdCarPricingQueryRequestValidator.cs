using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Query.CarPricingQuery.GetByIdCarPricingQuery;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarPricingValidator;


public class GetByIdCarPricingQueryRequestValidator : AbstractValidator<GetByIdCarPricingQueryRequest>
{
    public GetByIdCarPricingQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty()
            .WithMessage(ValidationMessages.CarPricingValidationMessages.IdRequired);
    }
}
