using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.PricingDtos;
using OnionArchitectureRentACarBook.Application.Repositories.PricingRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.PricingCommands.UpdatePricingCommand;

public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommandRequest, UpdatePricingCommandResponse>
{
    private readonly IPricingWriteRepository _pricingWriteRepository;
    private readonly IPricingReadRepository _pricingReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdatePricingCommandHandler(IPricingWriteRepository pricingWriteRepository, IPricingReadRepository pricingReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _pricingWriteRepository = pricingWriteRepository;
        _pricingReadRepository = pricingReadRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdatePricingCommandResponse> Handle(UpdatePricingCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _pricingReadRepository.GetByIdAsync(request.UpdatePricingCommandDtoRequest.Id, cancellationToken);
        if (entity == null)
        {
            return new UpdatePricingCommandResponse
            {
                Result = Result.Failure("Güncellenecek fiyatlandırma bulunamadı.")
            };
        }

        _mapper.Map(request.UpdatePricingCommandDtoRequest, entity);
        await _pricingWriteRepository.UpdateAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdatePricingCommandResponse
        {
            Result = Result.Success("Fiyatlandırma başarıyla güncellendi.")
        };
    }
} 