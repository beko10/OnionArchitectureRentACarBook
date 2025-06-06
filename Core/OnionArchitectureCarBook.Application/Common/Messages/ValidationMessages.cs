namespace OnionArchitectureRentACarBook.Application.Common.Messages;

public static class ValidationMessages
{
    /// <summary>
    /// Genel veya birden fazla varl�k i�in ge�erli olabilecek mesajlar.
    /// </summary>
    public static class CommonValidationMessages
    {
        public const string RequiredField = "{PropertyName} alan� zorunludur."; // {PropertyName} FluentValidation taraf�ndan otomatik doldurulur
        public const string MaxLengthExceeded = "{PropertyName} en fazla {MaxLength} karakter olabilir.";
        public const string MinLengthNotMet = "{PropertyName} en az {MinLength} karakter olmal�d�r.";
        public const string InvalidFormat = "{PropertyName} i�in ge�ersiz format.";
        public const string NotFound = "{PropertyName} bulunamad�.";
        public const string AlreadyExists = "{PropertyName} zaten mevcut.";
        public const string MustBePositive = "{PropertyName} pozitif bir de�er olmal�d�r.";
        public const string InvalidUrlFormat = "Ge�ersiz URL format�. L�tfen ge�erli bir URL giriniz.";
    }

    /// <summary>
    /// "Hakk�m�zda" (About) varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class AboutValidationMessages
    {
        public const string TitleRequired = "Hakk�m�zda ba�l��� zorunludur.";
        public const string TitleMinLength = "Hakk�m�zda ba�l��� en az 5 karakter olmal�d�r.";
        public const string TitleMaxLength = "Hakk�m�zda ba�l��� en fazla 200 karakter olabilir.";

        public const string DescriptionRequired = "Hakk�m�zda a��klamas� zorunludur.";
        public const string DescriptionMinLength = "Hakk�m�zda a��klamas� en az 20 karakter olmal�d�r.";
        public const string DescriptionMaxLength = "Hakk�m�zda a��klamas� en fazla 1000 karakter olabilir.";

        public const string ImageUrlRequired = "Hakk�m�zda g�rsel URL'si zorunludur.";
        // CommonValidationMessages.InvalidUrlFormat kullan�labilir veya daha spesifik bir mesaj:
        public const string InvalidImageUrlFormat = "Ge�ersiz resim URL format�. L�tfen ge�erli bir resim URL'si giriniz.";
    }
 
}