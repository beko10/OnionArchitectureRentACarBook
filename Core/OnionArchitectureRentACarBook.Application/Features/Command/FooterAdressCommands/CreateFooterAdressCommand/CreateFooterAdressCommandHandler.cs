using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.FooterAdressDtos;
using OnionArchitectureRentACarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FooterAdressCommands.CreateFooterAdressCommand;

public class CreateFooterAdressCommandHandler : IRequestHandler<CreateFooterAdressCommandRequest, CreateFooterAdressCommandResponse>
{
    private readonly IFooterAdressWriteRepository _footerAdressWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateFooterAdressCommandHandler(IFooterAdressWriteRepository footerAdressWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _footerAdressWriteRepository = footerAdressWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateFooterAdressCommandResponse> Handle(CreateFooterAdressCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<FooterAdress>(request.CreateFooterAdressCommandDtoRequest);
        await _footerAdressWriteRepository.AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreateFooterAdressCommandResponse
        {
            Result = Result.Success("Footer adres başarıyla eklendi.")
        };
    }
} 