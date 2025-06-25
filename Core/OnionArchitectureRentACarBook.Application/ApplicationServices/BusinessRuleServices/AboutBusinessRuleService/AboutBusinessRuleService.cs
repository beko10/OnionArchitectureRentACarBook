using OnionArchitectureRentACarBook.Application.ApplicationServices.BusinessRuleServices.AboutRuleService;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureRentACarBook.Application.ApplicationServices.BusinessRuleServices.AboutBusinessRuleService;

public class AboutBusinessRuleService : IAboutBusinessRuleService
{
    private readonly IAboutReadRepository _aboutReadRepository;

    public AboutBusinessRuleService(IAboutReadRepository aboutReadRepository)
    {
        _aboutReadRepository = aboutReadRepository;
    }

    public async Task CreateAboutBusineesRuleCheck(CreateAboutDto createAboutDto)
    {
        await AboutDescriptionUniqeCheck(createAboutDto.Description!);
        await AboutImageUrlUniqeCheck(createAboutDto.ImageUrl!);
        await AboutTitleUniqeCheck(createAboutDto.Title!);
    }

    public async Task UpdateAboutBusineesRuleCheck(string id)
    {
        var about = await _aboutReadRepository.GetByIdAsync(id);
        if(about is null)
        {
            throw new NotFoundException($"About with id {id} not found.");
        }

    }

    private async Task AboutTitleUniqeCheck(string title)
    {
        var about = await _aboutReadRepository.GetSingleAsync(x => x.Title == title);
        if(about is not null)
        {
            throw new ConflictException($"About with title {title} already exists.");
        }
    }

    private async Task AboutImageUrlUniqeCheck(string imageUrl)
    {
        var about = await _aboutReadRepository.GetSingleAsync(x => x.ImageUrl == imageUrl);
        if(about is not null)
        {
            throw new ConflictException($"About with image URL {imageUrl} already exists.");
        }
    }
    private async Task AboutDescriptionUniqeCheck(string description)
    {
        var about = await _aboutReadRepository.GetSingleAsync(x => x.Description == description);
        if(about is not null)
        {
            throw new ConflictException($"About with description {description} already exists.");
        }
    }

}
