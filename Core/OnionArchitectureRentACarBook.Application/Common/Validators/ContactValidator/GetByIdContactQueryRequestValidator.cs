using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.ContactQueries.GetByIdContactQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.ContactValidator;

public class GetByIdContactQueryRequestValidator : AbstractValidator<GetByIdContactQueryRequest>
{
    public GetByIdContactQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty()
            .WithMessage(ValidationMessages.ContactValidationMessages.IdRequired);
    }
} 