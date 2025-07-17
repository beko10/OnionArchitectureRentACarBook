using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Query.CarFeatureQueries.GeByIdCarFeatureQuery;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarFeatureValidator;

public class GeByIdCarFeatureQueryRequestValidator : AbstractValidator<GeByIdCarFeatureQueryRequest>
{
    public GeByIdCarFeatureQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty()
            .WithMessage(ValidationMessages.CarFeatureValidationMessages.IdRequired);
    }
}
