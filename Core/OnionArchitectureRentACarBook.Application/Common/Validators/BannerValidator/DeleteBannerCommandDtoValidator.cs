using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDto;


namespace OnionArchitectureRentACarBook.Application.Common.Validators.BannerValidator
{
    public class DeleteBannerCommandDtoValidator : AbstractValidator<DeleteBrandCommandDto>
    {
        public DeleteBannerCommandDtoValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage(ValidationMessages.BannerValidationMessages.IdRequired);
        }
    }
}