namespace OnionArchitectureRentACarBook.Application.Common.Messages;

public static class ValidationMessages
{
    /// <summary>
    /// Genel veya birden fazla varlýk için geçerli olabilecek mesajlar.
    /// </summary>
    public static class CommonValidationMessages
    {
        public const string RequiredField = "{PropertyName} alaný zorunludur."; // {PropertyName} FluentValidation tarafýndan otomatik doldurulur
        public const string MaxLengthExceeded = "{PropertyName} en fazla {MaxLength} karakter olabilir.";
        public const string MinLengthNotMet = "{PropertyName} en az {MinLength} karakter olmalýdýr.";
        public const string InvalidFormat = "{PropertyName} için geçersiz format.";
        public const string NotFound = "{PropertyName} bulunamadý.";
        public const string AlreadyExists = "{PropertyName} zaten mevcut.";
        public const string MustBePositive = "{PropertyName} pozitif bir deðer olmalýdýr.";
        public const string InvalidUrlFormat = "Geçersiz URL formatý. Lütfen geçerli bir URL giriniz.";
    }

    /// <summary>
    /// "Hakkýmýzda" (About) varlýðý için doðrulama mesajlarý.
    /// </summary>
    public static class AboutValidationMessages
    {
        public const string TitleRequired = "Hakkýmýzda baþlýðý zorunludur.";
        public const string TitleMinLength = "Hakkýmýzda baþlýðý en az 5 karakter olmalýdýr.";
        public const string TitleMaxLength = "Hakkýmýzda baþlýðý en fazla 200 karakter olabilir.";

        public const string DescriptionRequired = "Hakkýmýzda açýklamasý zorunludur.";
        public const string DescriptionMinLength = "Hakkýmýzda açýklamasý en az 20 karakter olmalýdýr.";
        public const string DescriptionMaxLength = "Hakkýmýzda açýklamasý en fazla 1000 karakter olabilir.";

        public const string ImageUrlRequired = "Hakkýmýzda görsel URL'si zorunludur.";
        // CommonValidationMessages.InvalidUrlFormat kullanýlabilir veya daha spesifik bir mesaj:
        public const string InvalidImageUrlFormat = "Geçersiz resim URL formatý. Lütfen geçerli bir resim URL'si giriniz.";
    }
 
}