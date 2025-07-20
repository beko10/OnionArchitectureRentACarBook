using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.FooterAdressRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;

namespace OnionArchitectureRentACarBook.Application.Features.Command.FooterAdressCommands.DeleteFooterAdressCommand;

public class DeleteFooterAdressCommandHandler : IRequestHandler<DeleteFooterAdressCommandRequest, DeleteFooterAdressCommandResponse>
{
    private readonly IFooterAdressWriteRepository _footerAdressWriteRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteFooterAdressCommandHandler(IFooterAdressWriteRepository footerAdressWriteRepository, IUnitOfWork unitOfWork)
    {
        _footerAdressWriteRepository = footerAdressWriteRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<DeleteFooterAdressCommandResponse> Handle(DeleteFooterAdressCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _footerAdressWriteRepository.RemoveIdAsync(request.Id, cancellationToken);
        if (!result)
        {
            return new DeleteFooterAdressCommandResponse
            {
                Result = Result.Failure("Silinecek footer adres bulunamadı.")
            };
        }

        await _unitOfWork.SaveAsync();
        return new DeleteFooterAdressCommandResponse
        {
            Result = Result.Success("Footer adres başarıyla silindi.")
        };
    }
} 