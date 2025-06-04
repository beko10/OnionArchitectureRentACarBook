using AutoMapper;
using MediatR;
using OnionArchitectureCarBook.Application.Common.Messages;
using OnionArchitectureCarBook.Application.DTOs.About;
using OnionArchitectureCarBook.Application.Repositories.AboutRepository;
using OnionArchitectureCarBook.Application.UnitOfWork;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Application.Features.Command.AboutCommands.CreateAboutCommand;

public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommandRequest, CreateAboutCommandResponse>
{
    private readonly IAboutWriteRepository _aboutWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _aboutWriteRepository = aboutWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateAboutCommandResponse> Handle(CreateAboutCommandRequest request, CancellationToken cancellationToken)
    {
        var addedAboutMapping =  _mapper.Map<About>(request.CreateAboutDto);
        await _aboutWriteRepository.AddAsync(addedAboutMapping);
        await _unitOfWork.SaveAsync();
        var aboutDto = _mapper.Map<CreateAboutDto>(addedAboutMapping);
        return new CreateAboutCommandResponse
        {
            Result = ResultData<CreateAboutDto>.Success(aboutDto, OperationMessages.AboutOperationMessages.CreateSuccess)
        };
    }
}
