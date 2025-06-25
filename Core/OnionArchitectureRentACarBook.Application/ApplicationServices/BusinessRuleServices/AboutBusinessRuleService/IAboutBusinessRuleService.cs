using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureRentACarBook.Application.ApplicationServices.BusinessRuleServices.AboutRuleService;

public interface IAboutBusinessRuleService
{
    Task CreateAboutBusineesRuleCheck(CreateAboutDto createAboutDto);
    Task UpdateAboutBusineesRuleCheck(string id);
}
