using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Repositories.LocationRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.LocationCommands.UpdateLocationCommand;

public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommandRequest, UpdateLocationCommandResponse>
{
    private readonly ILocationWriteRepository _locationWriteRepository;
    private readonly ILocationReadRepository _locationReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateLocationCommandHandler(ILocationWriteRepository locationWriteRepository, ILocationReadRepository locationReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _locationWriteRepository = locationWriteRepository;
        _locationReadRepository = locationReadRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdateLocationCommandResponse> Handle(UpdateLocationCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _locationReadRepository.GetByIdAsync(request.UpdateLocationCommandDtoRequest.Id, cancellationToken);
        if (entity == null)
        {
            return new UpdateLocationCommandResponse
            {
                Result = Result.Failure("Güncellenecek lokasyon bulunamadı.")
            };
        }

        _mapper.Map(request.UpdateLocationCommandDtoRequest, entity);
        await _locationWriteRepository.UpdateAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateLocationCommandResponse
        {
            Result = Result.Success("Lokasyon başarıyla güncellendi.")
        };
    }
} 