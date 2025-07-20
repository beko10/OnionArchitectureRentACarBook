using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Command.BannerCommands.DeleteBannerCommand;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.BannerValidator
{
    public class DeleteBannerCommandRequestValidator : AbstractValidator<DeleteBannerCommandRequest>
    {
        public DeleteBannerCommandRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage(ValidationMessages.BannerValidationMessages.IdRequired);
        }
    }
}