using OnionArchitectureRentACarBook.Application.Common.Exceptions;

public sealed class ConflictException : AppException
{
    public override int StatusCode => 409;
    public ConflictException(string message = "Çakışan kayıt") : base(message) { }
}