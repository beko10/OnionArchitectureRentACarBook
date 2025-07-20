using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.FeatureRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FeatureCommands.DeleteFeatureCommand;

public class DeleteFeatureCommandHandler : IRequestHandler<DeleteFeatureCommandRequest, DeleteFeatureCommandResponse>
{
    private readonly IFeatureWriteRepository _featureWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteFeatureCommandHandler(IFeatureWriteRepository featureWriteRepository, IUnitOfWork unitOfWork)
    {
        _featureWriteRepository = featureWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteFeatureCommandResponse> Handle(DeleteFeatureCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _featureWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if (!result)
        {
            return new DeleteFeatureCommandResponse
            {
                Result = Result.Failure("Silinecek özellik bulunamadı.")
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeleteFeatureCommandResponse
        {
            Result = Result.Success("Özellik başarıyla silindi.")
        };
    }
} 