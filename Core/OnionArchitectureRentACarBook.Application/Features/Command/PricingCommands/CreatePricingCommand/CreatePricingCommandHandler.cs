using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Repositories.PricingRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.PricingCommands.CreatePricingCommand;

public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommandRequest, CreatePricingCommandResponse>
{
    private readonly IPricingWriteRepository _pricingWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreatePricingCommandHandler(IPricingWriteRepository pricingWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _pricingWriteRepository = pricingWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreatePricingCommandResponse> Handle(CreatePricingCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Pricing>(request.CreatePricingCommandDtoRequest);
        await _pricingWriteRepository.AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreatePricingCommandResponse
        {
            Result = Result.Success("Fiyatlandırma başarıyla eklendi.")
        };
    }
} 