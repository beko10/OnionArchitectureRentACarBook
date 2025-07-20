using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.FeatureQueries.GetByIdFeatureQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.FeatureValidator;

public class GetByIdFeatureQueryRequestValidator : AbstractValidator<GetByIdFeatureQueryRequest>
{
    public GetByIdFeatureQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.FeatureValidationMessages.IdRequired);
    }
} 