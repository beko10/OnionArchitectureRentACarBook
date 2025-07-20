using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.TestimonialQueries.GetAllTestimonialsQuery;

public class GetAllTestimonialsQueryHandler : IRequestHandler<GetAllTestimonialsQueryRequest, GetAllTestimonialsQueryResponse>
{
    private readonly ITestimonialReadRepository _testimonialReadRepository;
    private readonly IMapper _mapper;

    public GetAllTestimonialsQueryHandler(ITestimonialReadRepository testimonialReadRepository, IMapper mapper)
    {
        _testimonialReadRepository = testimonialReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllTestimonialsQueryResponse> Handle(GetAllTestimonialsQueryRequest request, CancellationToken cancellationToken)
    {
        var entities = await _testimonialReadRepository.GetAllAsync(cancellationToken);
        var dtos = _mapper.Map<List<TestimonialQueryDto>>(entities);
        return new GetAllTestimonialsQueryResponse
        {
            Result = dtos.Any()
                ? ResultData<List<TestimonialQueryDto>>.Success(dtos, "Referanslar başarıyla getirildi.")
                : ResultData<List<TestimonialQueryDto>>.Failure("Kayıt bulunamadı.")
        };
    }
} 