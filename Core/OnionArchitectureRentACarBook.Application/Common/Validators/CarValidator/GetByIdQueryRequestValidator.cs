using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetByIdQuery;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.CarValidator;

public class GetByIdQueryRequestValidator : AbstractValidator<GetByIdQueryRequest>
{
    public GetByIdQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty()
            .WithMessage(ValidationMessages.CarValidationMessages.IdRequired);
    }
}
