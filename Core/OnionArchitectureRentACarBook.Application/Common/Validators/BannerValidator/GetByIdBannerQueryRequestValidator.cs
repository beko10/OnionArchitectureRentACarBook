using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Query.BannerQueries.GetByIdBannerQuery;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.BannerValidator;

public class GetByIdBannerQueryRequestValidator : AbstractValidator<GetByIdBannerQueryRequest>
{
    public GetByIdBannerQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotNull()
            .NotEmpty().WithMessage(ValidationMessages.BannerValidationMessages.IdRequired);
    }
}
