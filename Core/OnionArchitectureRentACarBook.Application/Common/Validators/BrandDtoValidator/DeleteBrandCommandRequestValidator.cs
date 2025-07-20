using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.DeleteBrandCommand;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.BrandDtoValidator
{
    public class DeleteBrandCommandRequestValidator : AbstractValidator<DeleteBrandCommandRequest>
    {
        public DeleteBrandCommandRequestValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage(ValidationMessages.BrandValidationMessages.IdRequired);
        }
    }
}