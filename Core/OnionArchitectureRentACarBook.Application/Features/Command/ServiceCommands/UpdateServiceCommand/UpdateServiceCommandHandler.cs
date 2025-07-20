using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ServiceDtos;
using OnionArchitectureRentACarBook.Application.Repositories.ServiceRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ServiceCommands.UpdateServiceCommand;

public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommandRequest, UpdateServiceCommandResponse>
{
    private readonly IServiceWriteRepository _serviceWriteRepository;
    private readonly IServiceReadRepository _serviceReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateServiceCommandHandler(IServiceWriteRepository serviceWriteRepository, IServiceReadRepository serviceReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _serviceWriteRepository = serviceWriteRepository;
        _serviceReadRepository = serviceReadRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdateServiceCommandResponse> Handle(UpdateServiceCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _serviceReadRepository.GetByIdAsync(request.UpdateServiceCommandDtoRequest.Id, cancellationToken);
        if (entity == null)
        {
            return new UpdateServiceCommandResponse
            {
                Result = Result.Failure("Güncellenecek servis bulunamadı.")
            };
        }

        _mapper.Map(request.UpdateServiceCommandDtoRequest, entity);
        await _serviceWriteRepository.UpdateAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateServiceCommandResponse
        {
            Result = Result.Success("Servis başarıyla güncellendi.")
        };
    }
} 