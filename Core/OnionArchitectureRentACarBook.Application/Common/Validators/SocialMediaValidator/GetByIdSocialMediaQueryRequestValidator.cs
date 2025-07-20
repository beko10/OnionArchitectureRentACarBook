using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.SocialMediaQueries.GetByIdSocialMediaQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.SocialMediaValidator;

public class GetByIdSocialMediaQueryRequestValidator : AbstractValidator<GetByIdSocialMediaQueryRequest>
{
    public GetByIdSocialMediaQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.IdRequired);
    }
} 