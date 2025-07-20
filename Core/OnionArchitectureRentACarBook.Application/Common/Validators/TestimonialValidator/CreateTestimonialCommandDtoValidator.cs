using FluentValidation;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.TestimonialValidator;

public class CreateTestimonialCommandDtoValidator : AbstractValidator<CreateTestimonialCommandDto>
{
    public CreateTestimonialCommandDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(ValidationMessages.TestimonialValidationMessages.NameRequired);
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage(ValidationMessages.TestimonialValidationMessages.TitleRequired);
        RuleFor(x => x.Comment)
            .NotEmpty().WithMessage(ValidationMessages.TestimonialValidationMessages.CommentRequired);
        RuleFor(x => x.ImageUrl)
            .NotEmpty().WithMessage(ValidationMessages.TestimonialValidationMessages.ImageUrlRequired);
    }
} 