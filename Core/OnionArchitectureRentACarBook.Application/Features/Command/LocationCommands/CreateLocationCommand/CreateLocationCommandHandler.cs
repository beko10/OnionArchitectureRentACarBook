using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.LocationDtos;
using OnionArchitectureRentACarBook.Application.Repositories.LocationRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.LocationCommands.CreateLocationCommand;

public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommandRequest, CreateLocationCommandResponse>
{
    private readonly ILocationWriteRepository _locationWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateLocationCommandHandler(ILocationWriteRepository locationWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _locationWriteRepository = locationWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateLocationCommandResponse> Handle(CreateLocationCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Location>(request.CreateLocationCommandDtoRequest);
        await _locationWriteRepository.AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreateLocationCommandResponse
        {
            Result = Result.Success("Lokasyon başarıyla eklendi.")
        };
    }
} 