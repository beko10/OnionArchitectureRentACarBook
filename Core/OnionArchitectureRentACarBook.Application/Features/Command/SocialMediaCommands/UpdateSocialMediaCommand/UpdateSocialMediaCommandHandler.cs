using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.SocialMediaDtos;
using OnionArchitectureRentACarBook.Application.Repositories.SocialMediaRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.SocialMediaCommands.UpdateSocialMediaCommand;

public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommandRequest, UpdateSocialMediaCommandResponse>
{
    private readonly ISocialMediaWriteRepository _socialMediaWriteRepository;
    private readonly ISocialMediaReadRepository _socialMediaReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateSocialMediaCommandHandler(ISocialMediaWriteRepository socialMediaWriteRepository, ISocialMediaReadRepository socialMediaReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _socialMediaWriteRepository = socialMediaWriteRepository;
        _socialMediaReadRepository = socialMediaReadRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdateSocialMediaCommandResponse> Handle(UpdateSocialMediaCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _socialMediaReadRepository.GetByIdAsync(request.UpdateSocialMediaCommandDtoRequest.Id, cancellationToken);
        if (entity == null)
        {
            return new UpdateSocialMediaCommandResponse
            {
                Result = Result.Failure("Güncellenecek sosyal medya kaydı bulunamadı.")
            };
        }

        _mapper.Map(request.UpdateSocialMediaCommandDtoRequest, entity);
        await _socialMediaWriteRepository.UpdateAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateSocialMediaCommandResponse
        {
            Result = Result.Success("Sosyal medya kaydı başarıyla güncellendi.")
        };
    }
} 