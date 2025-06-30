using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarDto;
using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetByIdQuery;

public class GetByIdQueryHandler : IRequestHandler<GetByIdQueryRequest, GetByIdQueryResponse>
{
    private readonly ICarReadRepository _carReadRepository;
    private readonly IMapper _mapper;
    public GetByIdQueryHandler(ICarReadRepository carReadRepository, IMapper mapper)
    {
        _carReadRepository = carReadRepository;
        _mapper = mapper;
    }

    public async Task<GetByIdQueryResponse> Handle(GetByIdQueryRequest request, CancellationToken cancellationToken)
    {
        var hasCar = await _carReadRepository.GetByIdAsync(request.Id, cancellationToken);
        if (hasCar is null)
        {
            return new GetByIdQueryResponse
            {
                Result = ResultData<CarQueryDto>.Failure(OperationMessages.CarOperationMessages.GetNotFound)
            };
        }

        var carDto = _mapper.Map<CarQueryDto>(hasCar);
        return new GetByIdQueryResponse
        {
            Result = ResultData<CarQueryDto>.Success(carDto, OperationMessages.CarOperationMessages.GetSuccess)
        };
    }
}
