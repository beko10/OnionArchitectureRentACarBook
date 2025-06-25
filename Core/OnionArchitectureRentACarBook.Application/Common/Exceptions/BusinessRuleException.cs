using OnionArchitectureRentACarBook.Application.Common.Exceptions;

public sealed class BusinessRuleException : AppException  
{
    public override int StatusCode => 422;          
    public BusinessRuleException(string message) : base(message) { }
}
