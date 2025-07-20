using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.ServiceQueries.GetByIdServiceQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.ServiceValidator;

public class GetByIdServiceQueryRequestValidator : AbstractValidator<GetByIdServiceQueryRequest>
{
    public GetByIdServiceQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.ServiceValidationMessages.IdRequired);
    }
} 