using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ServiceCommands.CreateServiceCommand;

public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommandRequest, CreateServiceCommandResponse>
{
    private readonly IServiceWriteRepository _serviceWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateServiceCommandHandler(IServiceWriteRepository serviceWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _serviceWriteRepository = serviceWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateServiceCommandResponse> Handle(CreateServiceCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Service>(request.CreateServiceCommandDtoRequest);
        await _serviceWriteRepository.AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreateServiceCommandResponse
        {
            Result = Result.Success("Servis başarıyla eklendi.")
        };
    }
} 