using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Application.Features.Command.BrandCommands.CreateBrandCommand;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandResponse>
{
    private readonly IBrandWriteRepository _brandWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CreateBrandCommandHandler(IBrandWriteRepository brandWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _brandWriteRepository = brandWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        if(request.CreateBrandCommandDtoRequest == null)
        {
            return new CreateBrandCommandResponse
            {
                Result = Result.Failure(OperationMessages.BrandOperationMessages.CreateFailed)
            };
        }

        var addedBrand = _mapper.Map<Brand>(request.CreateBrandCommandDtoRequest);
        await _brandWriteRepository.AddAsync(entity : addedBrand,cancellationToken:cancellationToken);
        await _unitOfWork.SaveAsync();
        return new CreateBrandCommandResponse
        {
            Result = Result.Success()
        };

    }
}
