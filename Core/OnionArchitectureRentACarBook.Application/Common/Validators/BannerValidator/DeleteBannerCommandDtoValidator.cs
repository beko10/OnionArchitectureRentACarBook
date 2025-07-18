using FluentValidation;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.BrandDtos;


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