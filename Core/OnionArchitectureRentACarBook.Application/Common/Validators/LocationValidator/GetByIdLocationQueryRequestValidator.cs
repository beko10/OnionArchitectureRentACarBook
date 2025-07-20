using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.LocationQueries.GetByIdLocationQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.LocationValidator;

public class GetByIdLocationQueryRequestValidator : AbstractValidator<GetByIdLocationQueryRequest>
{
    public GetByIdLocationQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.LocationValidationMessages.IdRequired);
    }
} 