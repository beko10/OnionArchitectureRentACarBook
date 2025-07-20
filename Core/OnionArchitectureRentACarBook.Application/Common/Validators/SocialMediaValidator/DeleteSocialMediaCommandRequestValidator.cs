using FluentValidation;
using OnionArchitectureRentACarBook.Application.Features.Command.SocialMediaCommands.DeleteSocialMediaCommand;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Common.Validators.SocialMediaValidator;

public class DeleteSocialMediaCommandRequestValidator : AbstractValidator<DeleteSocialMediaCommandRequest>
{
    public DeleteSocialMediaCommandRequestValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty().WithMessage(ValidationMessages.SocialMediaValidationMessages.IdRequired);
    }
} 