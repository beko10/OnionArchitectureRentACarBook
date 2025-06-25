using OnionArchitectureRentACarBook.Application.Common.Exceptions;

public sealed class UnauthorizedException : AppException
{
    public override int StatusCode => 401;
    public UnauthorizedException(string message = "Kimlik doğrulama gerekli") : base(message) { }
}