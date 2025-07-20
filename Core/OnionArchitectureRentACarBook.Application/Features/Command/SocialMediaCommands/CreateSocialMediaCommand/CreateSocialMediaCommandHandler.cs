using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.SocialMediaCommands.CreateSocialMediaCommand;

public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommandRequest, CreateSocialMediaCommandResponse>
{
    private readonly ISocialMediaWriteRepository _socialMediaWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateSocialMediaCommandHandler(ISocialMediaWriteRepository socialMediaWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _socialMediaWriteRepository = socialMediaWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateSocialMediaCommandResponse> Handle(CreateSocialMediaCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<SocialMedia>(request.CreateSocialMediaCommandDtoRequest);
        await _socialMediaWriteRepository.AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreateSocialMediaCommandResponse
        {
            Result = Result.Success("Sosyal medya kaydı başarıyla eklendi.")
        };
    }
} 