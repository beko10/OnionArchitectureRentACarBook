using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Query.TestimonialQueries.GetByIdTestimonialQuery;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.TestimonialValidator;

public class GetByIdTestimonialQueryRequestValidator : AbstractValidator<GetByIdTestimonialQueryRequest>
{
    public GetByIdTestimonialQueryRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.TestimonialValidationMessages.IdRequired);
    }
} 