using MediatR;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using OnionArchitectureRentACarBook.Domain.Entities;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Command.TestimonialCommands.CreateTestimonialCommand;

public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommandRequest, CreateTestimonialCommandResponse>
{
    private readonly ITestimonialWriteRepository _testimonialWriteRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateTestimonialCommandHandler(ITestimonialWriteRepository testimonialWriteRepository, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _testimonialWriteRepository = testimonialWriteRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateTestimonialCommandResponse> Handle(CreateTestimonialCommandRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<Testimonial>(request.CreateTestimonialCommandDtoRequest);
        await _testimonialWriteRepository.AddAsync(entity, cancellationToken);
        await _unitOfWork.SaveAsync();

        return new CreateTestimonialCommandResponse
        {
            Result = Result.Success("Referans başarıyla eklendi.")
        };
    }
} 