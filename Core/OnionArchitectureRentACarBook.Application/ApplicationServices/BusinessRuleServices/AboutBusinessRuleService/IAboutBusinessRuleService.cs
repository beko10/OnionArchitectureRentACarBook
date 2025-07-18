using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureRentACarBook.Application.ApplicationServices.BusinessRuleServices.AboutRuleService;

public interface IAboutBusinessRuleService
{
    Task CreateAboutBusineesRuleCheck(CreateAboutCommandDto createAboutDto);
    Task UpdateAboutBusineesRuleCheck(string id);
}
