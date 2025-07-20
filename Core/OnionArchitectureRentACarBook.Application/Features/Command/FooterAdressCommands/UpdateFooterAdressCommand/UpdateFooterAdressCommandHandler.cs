using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FooterAdressCommands.UpdateFooterAdressCommand;

public class UpdateFooterAdressCommandHandler : IRequestHandler<UpdateFooterAdressCommandRequest, UpdateFooterAdressCommandResponse>
{
    private readonly IFooterAdressWriteRepository _footerAdressWriteRepository;
    private readonly IFooterAdressReadRepository _footerAdressReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateFooterAdressCommandHandler(IFooterAdressWriteRepository footerAdressWriteRepository, IFooterAdressReadRepository footerAdressReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _footerAdressWriteRepository = footerAdressWriteRepository;
        _footerAdressReadRepository = footerAdressReadRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdateFooterAdressCommandResponse> Handle(UpdateFooterAdressCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _footerAdressReadRepository.GetByIdAsync(request.UpdateFooterAdressCommandDtoRequest.Id, cancellationToken);
        if (entity == null)
        {
            return new UpdateFooterAdressCommandResponse
            {
                Result = Result.Failure("Güncellenecek footer adres bulunamadı.")
            };
        }

        _mapper.Map(request.UpdateFooterAdressCommandDtoRequest, entity);
        await _footerAdressWriteRepository.UpdateAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateFooterAdressCommandResponse
        {
            Result = Result.Success("Footer adres başarıyla güncellendi.")
        };
    }
} 