using OnionArchitectureRentACarBook.Application.Utilities.Results;

public sealed class ResultData<TData> : Result
{
    public TData? Data { get; }

    private ResultData(bool isSuccess, string message, TData? data)
        : base(isSuccess, message)
    {
        Data = data;
    }


    public static ResultData<TData> Success(TData data, string? message = null)
        => new(true, message ?? DefaultSuccess, data);

    public static ResultData<TData> Failure(string? message = null)
        => new(false, message ?? DefaultFailure, default);
}
