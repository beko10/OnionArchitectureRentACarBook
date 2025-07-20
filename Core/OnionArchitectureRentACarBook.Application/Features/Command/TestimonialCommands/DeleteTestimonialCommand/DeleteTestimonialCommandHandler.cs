using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.TestimonialCommands.DeleteTestimonialCommand;

public class DeleteTestimonialCommandHandler : IRequestHandler<DeleteTestimonialCommandRequest, DeleteTestimonialCommandResponse>
{
    private readonly ITestimonialWriteRepository _testimonialWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteTestimonialCommandHandler(ITestimonialWriteRepository testimonialWriteRepository, IUnitOfWork unitOfWork)
    {
        _testimonialWriteRepository = testimonialWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteTestimonialCommandResponse> Handle(DeleteTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _testimonialWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if (!result)
        {
            return new DeleteTestimonialCommandResponse
            {
                Result = Result.Failure("Silinecek referans bulunamadı.")
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeleteTestimonialCommandResponse
        {
            Result = Result.Success("Referans başarıyla silindi.")
        };
    }
} 