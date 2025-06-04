namespace OnionArchitectureCarBook.Application.Utilities.Results;

public  class Result
{
    protected const string DefaultSuccess = "Operation completed successfully";
    protected const string DefaultFailure = "Operation failure";

    public bool IsSuccess { get; }
    public string Message { get; }

    protected Result(bool isSuccess, string message)
    {
        IsSuccess = isSuccess;
        Message = message;
    }

    public static Result Success(string? message = null) =>
        new(true, message ?? DefaultSuccess);

    public static Result Failure(string? message = null) =>
        new(false, message ?? DefaultFailure);
}

