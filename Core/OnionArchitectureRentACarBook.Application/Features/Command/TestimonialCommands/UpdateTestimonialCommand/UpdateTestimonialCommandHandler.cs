using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.TestimonialCommands.UpdateTestimonialCommand;

public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommandRequest, UpdateTestimonialCommandResponse>
{
    private readonly ITestimonialWriteRepository _testimonialWriteRepository;
    private readonly ITestimonialReadRepository _testimonialReadRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateTestimonialCommandHandler(ITestimonialWriteRepository testimonialWriteRepository, ITestimonialReadRepository testimonialReadRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _testimonialWriteRepository = testimonialWriteRepository;
        _testimonialReadRepository = testimonialReadRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UpdateTestimonialCommandResponse> Handle(UpdateTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = await _testimonialReadRepository.GetByIdAsync(request.UpdateTestimonialCommandDtoRequest.Id, cancellationToken);
        if (entity == null)
        {
            return new UpdateTestimonialCommandResponse
            {
                Result = Result.Failure("Güncellenecek referans bulunamadı.")
            };
        }

        _mapper.Map(request.UpdateTestimonialCommandDtoRequest, entity);
        await _testimonialWriteRepository.UpdateAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new UpdateTestimonialCommandResponse
        {
            Result = Result.Success("Referans başarıyla güncellendi.")
        };
    }
} 