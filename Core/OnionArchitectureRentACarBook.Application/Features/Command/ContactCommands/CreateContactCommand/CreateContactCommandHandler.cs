using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.ContactDtos;
using OnionArchitectureRentACarBook.Application.Repositories.ContactRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;
using OnionArchitectureRentACarBook.Application.Common.Messages;

namespace OnionArchitectureRentACarBook.Application.Features.Command.ContactCommands.CreateContactCommand;

public class CreateContactCommandHandler : IRequestHandler<CreateContactCommandRequest, CreateContactCommandResponse>
{
    private readonly IContactWriteRepository _contactWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateContactCommandHandler(IContactWriteRepository contactWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _contactWriteRepository = contactWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateContactCommandResponse> Handle(CreateContactCommandRequest request, CancellationToken cancellationToken)
    {
        var contact = _mapper.Map<Contact>(request.CreateContactCommandDtoRequest);

        await _contactWriteRepository.AddAsync(contact, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreateContactCommandResponse
        {
            Result = Result.Success(OperationMessages.ContactOperationMessages.CreateSuccess)
        };
    }
} 