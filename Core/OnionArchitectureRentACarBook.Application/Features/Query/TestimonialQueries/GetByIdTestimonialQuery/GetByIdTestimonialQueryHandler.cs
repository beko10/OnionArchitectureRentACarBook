using MediatR;
using OnionArchitectureRentACarBook.Application.Repositories.TestimonialRepository;
using OnionArchitectureRentACarBook.Application.DTOs.TestimonialDtos;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using AutoMapper;

namespace OnionArchitectureRentACarBook.Application.Features.Query.TestimonialQueries.GetByIdTestimonialQuery;

public class GetByIdTestimonialQueryHandler : IRequestHandler<GetByIdTestimonialQueryRequest, GetByIdTestimonialQueryResponse>
{
    private readonly ITestimonialReadRepository _testimonialReadRepository;
    private readonly IMapper _mapper;

    public GetByIdTestimonialQueryHandler(ITestimonialReadRepository testimonialReadRepository, IMapper mapper)
    {
        _testimonialReadRepository = testimonialReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdTestimonialQueryResponse> Handle(GetByIdTestimonialQueryRequest request, CancellationToken cancellationToken)
    {
        var entity = await _testimonialReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (entity == null)
        {
            return new GetByIdTestimonialQueryResponse
            {
                Result = ResultData<TestimonialQueryDto>.Failure("Kayıt bulunamadı.")
            };
        }
        var dto = _mapper.Map<TestimonialQueryDto>(entity);
        return new GetByIdTestimonialQueryResponse
        {
            Result = ResultData<TestimonialQueryDto>.Success(dto, "Referans başarıyla getirildi.")
        };
    }
} 