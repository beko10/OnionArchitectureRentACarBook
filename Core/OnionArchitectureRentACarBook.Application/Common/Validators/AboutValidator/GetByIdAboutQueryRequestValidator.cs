using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Query.AboutQueries.GetByIdAboutQuery;

public class GetByIdAboutQueryRequestValidator : AbstractValidator<GetByIdAboutQueryRequest>
{
    public GetByIdAboutQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty()
            .WithMessage(ValidationMessages.AboutValidationMessages.IdRequired);
    }
}