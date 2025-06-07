using FluentValidation;
using MediatR;
using OnionArchitectureRentACarBook.Application.Utilities.Results;
using System.Reflection;

namespace OnionArchitectureRentACarBook.Application.Common.Behaviors;

public class ValidationPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    // Bu request için tanımlanmış tüm validator'ları DI (Dependency Injection) ile alıyoruz.
    private readonly IEnumerable<IValidator<TRequest>> _validators;

    public ValidationPipelineBehavior(IEnumerable<IValidator<TRequest>> validators)
    {
        _validators = validators;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        // Eğer bu request için atanmış bir validator yoksa, direkt bir sonraki adıma geç.
        if (!_validators.Any())
        {
            return await next();
        }

        // Validation context'ini oluştur.
        var context = new ValidationContext<TRequest>(request);

        // Tüm validator'ları asenkron olarak çalıştır ve sonuçları topla.
        var validationResults = await Task.WhenAll(
            _validators.Select(v => v.ValidateAsync(context, cancellationToken)));

        // Hataları tek bir listeye topla.
        var failures = validationResults
            .SelectMany(r => r.Errors)
            .Where(f => f != null)
            .ToList();

        // Eğer validasyon hatası varsa...
        if (failures.Any())
        {
            // Hata mesajlarını birleştir.
            var errorMessage = string.Join("\n", failures.Select(f => f.ErrorMessage));

            // TResponse tipindeki yanıt nesnesini oluştur ve Result özelliğini "Failure" olarak ayarla.
            // Bu kısım reflection ile yapılıyor çünkü TResponse'un ne olduğunu bilmiyoruz,
            // ama Result veya ResultData<T> tipinde bir property'si olduğunu varsayıyoruz.
            return CreateValidationFailureResponse(errorMessage);
        }

        // Validasyon başarılıysa, pipeline'daki bir sonraki adıma (genellikle asıl Handler'a) geç.
        return await next();
    }

    private static TResponse CreateValidationFailureResponse(string errorMessage)
    {
        // Yanıt nesnesinin (örn: CreateAboutCommandResponse) "Result" adında bir property'si olmalı
        // ve bu property'nin tipi Result sınıfından türemeli (Result veya ResultData<T>).
        var responseType = typeof(TResponse);

        // TResponse'un Result veya ResultData<T> tipinde bir property'sini bul.
        var resultProperty = responseType.GetProperties()
            .FirstOrDefault(p => typeof(Result).IsAssignableFrom(p.PropertyType));

        if (resultProperty == null)
        {
            // Eğer response nesnesinde Result tipinde bir property bulunamazsa, bu bir programlama hatasıdır.
            // Bu durumu belirtmek için bir exception fırlatmak mantıklıdır.
            throw new InvalidOperationException(
                $"Response type '{responseType.Name}' does not have a property that inherits from 'Result' to assign the validation failure.");
        }

        // Result property'sinin gerçek tipini al (örn: ResultData<CreateAboutDto>).
        var resultType = resultProperty.PropertyType;

        // Bu tipin static "Failure" metodunu bul. Hem Result hem de ResultData<T> bu metoda sahip.
        var failureMethod = resultType.GetMethod("Failure", BindingFlags.Public | BindingFlags.Static, new[] { typeof(string) });

        if (failureMethod == null)
        {
            // Beklenmedik bir durum, Failure metodu bulunamadı.
            throw new InvalidOperationException(
                $"Could not find static 'Failure' method on type '{resultType.Name}'.");
        }

        // Static "Failure" metodunu çağırarak bir "Failure" sonucu oluştur.
        // `Invoke(null, ...)` static metotlar için kullanılır.
        var failureResult = failureMethod.Invoke(null, new object?[] { errorMessage });

        // TResponse'un bir örneğini oluştur (örn: new CreateAboutCommandResponse()).
        // Bunun çalışması için Response nesnelerinin parametresiz bir constructor'a sahip olması gerekir.
        var responseInstance = Activator.CreateInstance<TResponse>();

        // Oluşturulan "Failure" sonucunu, response nesnesindeki "Result" property'sine ata.
        resultProperty.SetValue(responseInstance, failureResult);

        // Hazırlanan hata yanıtını döndür.
        return responseInstance;
    }
}