﻿using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.ApplicationServices.BusinessRuleServices.AboutRuleService;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDtos;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, CreateAboutCommandResponse>
{
    private readonly IAboutWriteRepository _aboutWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IAboutBusinessRuleService _aboutBusinessRuleService;
    public CreateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IUnitOfWork unitOfWork, IMapper mapper, IAboutBusinessRuleService aboutBusinessRuleService)
    {
        _aboutWriteRepository = aboutWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _aboutBusinessRuleService = aboutBusinessRuleService;
    }

    public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
    {
        await _aboutBusinessRuleService.CreateAboutBusineesRuleCheck(request.CreateAboutDtoRequest);
        var addedAboutMapping =  _mapper.Map<About>(request.CreateAboutDtoRequest);
        await _aboutWriteRepository.AddAsync(addedAboutMapping);
        await _unitOfWork.SaveAsync();
        var aboutDto = _mapper.Map<CreateAboutCommandDto>(addedAboutMapping);
        return new CreateAboutCommandResponse
        {
            Result = Result.Success(OperationMessages.AboutOperationMessages.CreateSuccess)
        };
    }
}
