namespace OnionArchitectureRentACarBook.Application.Common.Messages;

/// <summary>
/// FluentValidation için varlýk bazýnda gruplandýrýlmýþ doðrulama mesajlarýný içerir.
/// </summary>
public static class ValidationMessages
{
    /// <summary>
    /// Genel veya birden fazla varlýk için geçerli olabilecek mesajlar.
    /// </summary>
    public static class CommonValidationMessages
    {
        public const string RequiredField = "{PropertyName} alaný zorunludur.";
        public const string MaxLengthExceeded = "{PropertyName} en fazla {MaxLength} karakter olabilir.";
        public const string MinLengthNotMet = "{PropertyName} en az {MinLength} karakter olmalýdýr.";
        public const string InvalidUrlFormat = "Geçersiz URL formatý. Lütfen geçerli bir URL giriniz.";
        public const string InvalidEmailFormat = "Geçersiz e-posta formatý. Lütfen geçerli bir e-posta adresi giriniz.";
        public const string InvalidPhoneFormat = "Geçersiz telefon numarasý formatý.";
        public const string InvalidDateFormat = "Geçersiz tarih formatý.";
        public const string InvalidNumericValue = "Lütfen geçerli bir sayý giriniz.";
        public const string PositiveNumberRequired = "Deðer sýfýrdan büyük olmalýdýr.";
        public const string PastDateNotAllowed = "Gelecek bir tarih seçiniz.";
        public const string FutureDateNotAllowed = "Geçmiþ bir tarih seçiniz.";

    }

    /// <summary>
    /// "Banner" varlýðý için doðrulama mesajlarý.
    /// </summary>
    public static class BannerValidationMessages
    {
        public const string TitleLength = "Baþlýk en az 2, en fazla 100 karakter olmalýdýr.";
        public const string TitleInvalidChars = "Baþlýk geçersiz karakter içeriyor.";
        public const string DescriptionLength = "Açýklama en az 10, en fazla 500 karakter olmalýdýr.";
        public const string InvalidVideoUrl = "Lütfen desteklenen bir video URL'si giriniz (YouTube, Vimeo, .mp4 vb.).";
    }

    /// <summary>
    /// "Hakkýmýzda" (About) varlýðý için doðrulama mesajlarý.
    /// </summary>
    public static class AboutValidationMessages
    {
        public const string TitleRequired = "Hakkýmýzda baþlýðý zorunludur.";
        public const string DescriptionRequired = "Hakkýmýzda açýklamasý zorunludur.";
        public const string InvalidTitleCharacters = "Baþlýk geçersiz karakter içeriyor.";
        public const string ImageUrlRequired = "Hakkýmýzda görsel URL'si zorunludur.";
        public const string InvalidImageUrl = "Lütfen geçerli bir görsel URL'si giriniz (.jpg, .png, .gif vb.).";
    }

    /// <summary>
    /// "Kullanýcý" (User) varlýðý için doðrulama mesajlarý.
    /// </summary>
    public static class UserValidationMessages
    {
        public const string FirstNameRequired = "Ad alaný zorunludur.";
        public const string LastNameRequired = "Soyad alaný zorunludur.";
        public const string EmailRequired = "E-posta adresi zorunludur.";
        public const string EmailAlreadyExists = "Bu e-posta adresi zaten kullanýmda.";
        public const string PasswordRequired = "Þifre zorunludur.";
        public const string PasswordTooWeak = "Þifre en az 8 karakter olmalý, büyük-küçük harf, rakam ve özel karakter içermelidir.";
        public const string PasswordsNotMatch = "Þifreler eþleþmiyor.";
        public const string PhoneRequired = "Telefon numarasý zorunludur.";
        public const string InvalidBirthDate = "Doðum tarihi geçerli deðil. 18 yaþýndan büyük olmalýsýnýz.";
        public const string LicenseNumberRequired = "Ehliyet numarasý zorunludur.";
        public const string InvalidLicenseNumber = "Geçersiz ehliyet numarasý formatý.";
    }

  
    /// <summary>
    /// "Ýletiþim" (Contact) varlýðý için doðrulama mesajlarý.
    /// </summary>
    public static class ContactValidationMessages
    {
        public const string NameRequired = "Ad Soyad zorunludur.";
        public const string EmailRequired = "E-posta adresi zorunludur.";
        public const string SubjectRequired = "Konu baþlýðý zorunludur.";
        public const string MessageRequired = "Mesaj içeriði zorunludur.";
        public const string MessageTooShort = "Mesaj en az 10 karakter olmalýdýr.";
        public const string MessageTooLong = "Mesaj en fazla 1000 karakter olmalýdýr.";
    }

    /// <summary>
    /// "Marka" (Brand) varlýðý için doðrulama mesajlarý.
    /// </summary>
    public static class BrandValidationMessages
    {
        public const string NameLength = "Marka adý en az 2, en fazla 50 karakter olmalýdýr.";
        public const string NameInvalidChars = "Marka adý yalnýzca harf, sayý, boþluk ve noktalama iþaretleri içerebilir.";
        public const string InvalidId = "Geçerli bir marka ID'si girilmelidir.";
    }

    public static class CarValidationMessages
    {
        public const string BrandRequired = "Araç markasý alaný boþ býrakýlamaz.";
        public const string BrandIdRequired = "Marka ID'si belirtilmelidir.";

        public const string ModelRequired = "Araç modeli alaný zorunludur.";
        public const string InvalidModelCharacters = "Araç modeli geçersiz karakterler içeriyor.";

        public const string FuelTypeRequired = "Yakýt türü seçimi zorunludur.";
        public const string TransmissionRequired = "Vites türü seçimi zorunludur.";

        public const string CoverImageUrlRequired = "Kapak görseli URL'si zorunludur.";
        public const string BigImageUrlRequired = "Detay görseli URL'si zorunludur.";
        public const string InvalidImageUrlFormat = "Geçerli bir görsel URL'si giriniz (.jpg, .png vb.).";

        public const string SeatMustBePositive = "Araç koltuk sayýsý 0’dan büyük olmalýdýr.";
        public const string LuggageMustBePositive = "Bagaj kapasitesi 0 veya daha büyük olmalýdýr.";
        public const string InvalidMileage = "Kilometre bilgisi negatif olamaz.";
    }

    public static class CarFeatureValidationMessages
    {
        public const string CarIdRequired = "Araç ID alaný zorunludur.";
        public const string FeatureIdRequired = "Özellik ID alaný zorunludur.";
        public const string IdRequired = "Geçerli bir özellik ID'si girilmelidir.";
    }

    public static class CarPricingValidationMessages
    {
        public const string AmountPositive = "Fiyat bilgisi sýfýrdan büyük olmalýdýr.";
        public const string CarIdRequired = "Araç ID'si belirtilmelidir.";
        public const string PricingIdRequired = "Fiyatlandýrma ID'si belirtilmelidir.";
        public const string IdRequired = "CarPricing ID'si geçerli olmalýdýr.";
    }

}