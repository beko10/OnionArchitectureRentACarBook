using AutoMapper;
using MediatR;
using OnionArchitectureRentACarBook.Application.Common.Messages;
using OnionArchitectureRentACarBook.Application.DTOs.CarDtos;
using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;

namespace OnionArchitectureRentACarBook.Application.Features.Query.CarQueries.GetAllCarQuery;

public class GetAllCarQueryHandler : IRequestHandler<GetAllCarQueryRequest, GetAllCarQueryResponse>
{
    private readonly ICarReadRepository _carReadRepository;
    private readonly IMapper _mapper;
    public GetAllCarQueryHandler(ICarReadRepository carReadRepository, IMapper mapper)
    {
        _carReadRepository = carReadRepository;
        _mapper = mapper;
    }

    public async Task<GetAllCarQueryResponse> Handle(GetAllCarQueryRequest request, CancellationToken cancellationToken)
    {
        var carList = _carReadRepository.GetAll(false,cancellationToken).ToList();
        if(carList == null || !carList.Any())
        {
            return new GetAllCarQueryResponse
            {
                Result = ResultData<IEnumerable<CarQueryDto>>.Failure(OperationMessages.CarOperationMessages.GetAllEmpty)
            };
        }

        var carDtoList = _mapper.Map<IEnumerable<CarQueryDto>>(carList);
        return new GetAllCarQueryResponse
        {
            Result = ResultData<IEnumerable<CarQueryDto>>.Success(carDtoList, OperationMessages.CarOperationMessages.GetAllSuccess)
        };

    }
}
