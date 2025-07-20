using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.TestimonialCommands.DeleteTestimonialCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.TestimonialValidator;

public class DeleteTestimonialCommandRequestValidator : AbstractValidator<DeleteTestimonialCommandRequest>
{
    public DeleteTestimonialCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.TestimonialValidationMessages.IdRequired);
    }
} 