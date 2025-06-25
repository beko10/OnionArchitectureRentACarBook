namespace OnionArchitectureRentACarBook.Application.Common.Exceptions;

public abstract class AppException : Exception
{
    public abstract int StatusCode { get; }      
    public string? ErrorCode { get; init; }       
    protected AppException(string message) : base(message) { }
}
