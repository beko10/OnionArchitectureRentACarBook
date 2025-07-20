using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.FooterAdressQueries.GetByIdFooterAdressQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.FooterAdressValidator;

public class GetByIdFooterAdressQueryRequestValidator : AbstractValidator<GetByIdFooterAdressQueryRequest>
{
    public GetByIdFooterAdressQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.FooterAdressValidationMessages.IdRequired);
    }
} 