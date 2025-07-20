using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using OnionArchitectureRentACarBook.Application.Repositories.ContactRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ContactCommands.UpdateContactCommand;

public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommandRequest, UpdateContactCommandResponse>
{
    private readonly IContactWriteRepository _contactWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateContactCommandHandler(IContactWriteRepository contactWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _contactWriteRepository = contactWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdateContactCommandResponse> Handle(UpdateContactCommandRequest request, CancellationToken cancellationToken)
    {
        // Mevcut kaydı bul
        var contact = await _contactWriteRepository.GetByIdAsync(request.UpdateContactCommandDtoRequest.Id, cancellationToken);
        if (contact == null)
        {
            return new UpdateContactCommandResponse
            {
                Result = Result.Failure(OperationMessages.ContactOperationMessages.UpdateNotFound)
            };
        }

        // DTO'dan entity'ye güncelleme (AutoMapper ile)
        _mapper.Map(request.UpdateContactCommandDtoRequest, contact);
        await _contactWriteRepository.UpdateAsync(contact, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateContactCommandResponse
        {
            Result = Result.Success(OperationMessages.ContactOperationMessages.UpdateSuccess)
        };
    }
} 