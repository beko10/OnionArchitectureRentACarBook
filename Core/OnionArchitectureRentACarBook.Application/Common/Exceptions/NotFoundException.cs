using OnionArchitectureRentACarBook.Application.Common.Exceptions;

public sealed class NotFoundException : AppException
{
    public override int StatusCode => 404;
    public NotFoundException(string message = "Kaynak bulunamadı") : base(message) { }
}