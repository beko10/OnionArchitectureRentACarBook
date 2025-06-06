using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.AboutDto;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;

namespace OnionArchitectureRentACarBook.Application.Features.Command.AboutCommands.UpdateAboutCommand;

public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommandRequest, UpdateAboutCommandResponse>
{
    private readonly IAboutWriteRepository _aboutWriteRepository;
    private readonly IAboutReadRepository _aboutReadRepository;
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    public UpdateAboutCommandHandler(IAboutWriteRepository aboutWriteRepository, IUnitOfWork unitOfWork, IAboutReadRepository aboutReadRepository, IMapper mapper)
    {
        _aboutWriteRepository = aboutWriteRepository;
        _unitOfWork = unitOfWork;
        _aboutReadRepository = aboutReadRepository;
        _mapper = mapper;
    }

    public async Task<UpdateAboutCommandResponse> Handle(UpdateAboutCommandRequest request, CancellationToken cancellationToken)
    {
        var about = await _aboutReadRepository.GetByIdAsync(request.UpdateAboutDtoRequest.Id);
        if(about == null)
        {
            return new UpdateAboutCommandResponse
            {
                Result = ResultData<UpdateAboutDto>.Failure(OperationMessages.AboutOperationMessages.GetNotFound)
            };
        }
        _mapper.Map(request.UpdateAboutDtoRequest, about);
        await _aboutWriteRepository.UpdateAsync(about);
        await _unitOfWork.SaveAsync();
        return new UpdateAboutCommandResponse
        {
            Result = ResultData<UpdateAboutDto>.Success(request.UpdateAboutDtoRequest, OperationMessages.AboutOperationMessages.UpdateSuccess)
        };
    }
}
