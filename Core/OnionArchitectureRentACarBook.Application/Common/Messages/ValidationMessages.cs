namespace OnionArchitectureRentACarBook.Application.Common.Messages;

/// <summary>
/// FluentValidation i�in varl�k baz�nda grupland�r�lm�� do�rulama mesajlar�n� i�erir.
/// </summary>
public static class ValidationMessages
{
    /// <summary>
    /// Genel veya birden fazla varl�k i�in ge�erli olabilecek mesajlar.
    /// </summary>
    public static class CommonValidationMessages
    {
        public const string RequiredField = "{PropertyName} alan� zorunludur.";
        public const string MaxLengthExceeded = "{PropertyName} en fazla {MaxLength} karakter olabilir.";
        public const string MinLengthNotMet = "{PropertyName} en az {MinLength} karakter olmal�d�r.";
        public const string InvalidUrlFormat = "Ge�ersiz URL format�. L�tfen ge�erli bir URL giriniz.";
        public const string InvalidEmailFormat = "Ge�ersiz e-posta format�. L�tfen ge�erli bir e-posta adresi giriniz.";
        public const string InvalidPhoneFormat = "Ge�ersiz telefon numaras� format�.";
        public const string InvalidDateFormat = "Ge�ersiz tarih format�.";
        public const string InvalidNumericValue = "L�tfen ge�erli bir say� giriniz.";
        public const string PositiveNumberRequired = "De�er s�f�rdan b�y�k olmal�d�r.";
        public const string PastDateNotAllowed = "Gelecek bir tarih se�iniz.";
        public const string FutureDateNotAllowed = "Ge�mi� bir tarih se�iniz.";

    }

    /// <summary>
    /// "Banner" varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class BannerValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string TitleLength = "Ba�l�k en az 2, en fazla 100 karakter olmal�d�r.";
        public const string TitleInvalidChars = "Ba�l�k ge�ersiz karakter i�eriyor.";
        public const string DescriptionLength = "A��klama en az 10, en fazla 500 karakter olmal�d�r.";
        public const string InvalidVideoUrl = "L�tfen desteklenen bir video URL'si giriniz (YouTube, Vimeo, .mp4 vb.).";
    }

    /// <summary>
    /// "Hakk�m�zda" (About) varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class AboutValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string TitleRequired = "Hakk�m�zda ba�l��� zorunludur.";
        public const string DescriptionRequired = "Hakk�m�zda a��klamas� zorunludur.";
        public const string InvalidTitleCharacters = "Ba�l�k ge�ersiz karakter i�eriyor.";
        public const string ImageUrlRequired = "Hakk�m�zda g�rsel URL'si zorunludur.";
        public const string InvalidImageUrl = "L�tfen ge�erli bir g�rsel URL'si giriniz (.jpg, .png, .gif vb.).";
    }

    /// <summary>
    /// "Kullan�c�" (User) varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class UserValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string FirstNameRequired = "Ad alan� zorunludur.";
        public const string LastNameRequired = "Soyad alan� zorunludur.";
        public const string EmailRequired = "E-posta adresi zorunludur.";
        public const string EmailAlreadyExists = "Bu e-posta adresi zaten kullan�mda.";
        public const string PasswordRequired = "�ifre zorunludur.";
        public const string PasswordTooWeak = "�ifre en az 8 karakter olmal�, b�y�k-k���k harf, rakam ve �zel karakter i�ermelidir.";
        public const string PasswordsNotMatch = "�ifreler e�le�miyor.";
        public const string PhoneRequired = "Telefon numaras� zorunludur.";
        public const string InvalidBirthDate = "Do�um tarihi ge�erli de�il. 18 ya��ndan b�y�k olmal�s�n�z.";
        public const string LicenseNumberRequired = "Ehliyet numaras� zorunludur.";
        public const string InvalidLicenseNumber = "Ge�ersiz ehliyet numaras� format�.";
    }

  
    /// <summary>
    /// "�leti�im" (Contact) varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class ContactValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameRequired = "Ad Soyad zorunludur.";
        public const string EmailRequired = "E-posta adresi zorunludur.";
        public const string SubjectRequired = "Konu ba�l��� zorunludur.";
        public const string MessageRequired = "Mesaj i�eri�i zorunludur.";
        public const string MessageTooShort = "Mesaj en az 10 karakter olmal�d�r.";
        public const string MessageTooLong = "Mesaj en fazla 1000 karakter olmal�d�r.";
    }

    /// <summary>
    /// "Marka" (Brand) varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class BrandValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameLength = "Marka ad� en az 2, en fazla 50 karakter olmal�d�r.";
        public const string NameInvalidChars = "Marka ad� yaln�zca harf, say�, bo�luk ve noktalama i�aretleri i�erebilir.";
        public const string InvalidId = "Ge�erli bir marka ID'si girilmelidir.";
    }

    public static class CarValidationMessages
    {
        
        public const string IdRequired = "Id alanı boş olamaz";
        public const string BrandRequired = "Ara� markas� alan� bo� b�rak�lamaz.";
        public const string BrandIdRequired = "Marka ID'si belirtilmelidir.";

        public const string ModelRequired = "Ara� modeli alan� zorunludur.";
        public const string InvalidModelCharacters = "Ara� modeli ge�ersiz karakterler i�eriyor.";

        public const string FuelTypeRequired = "Yak�t t�r� se�imi zorunludur.";
        public const string TransmissionRequired = "Vites t�r� se�imi zorunludur.";

        public const string CoverImageUrlRequired = "Kapak g�rseli URL'si zorunludur.";
        public const string BigImageUrlRequired = "Detay g�rseli URL'si zorunludur.";
        public const string InvalidImageUrlFormat = "Ge�erli bir g�rsel URL'si giriniz (.jpg, .png vb.).";

        public const string SeatMustBePositive = "Ara� koltuk say�s� 0�dan b�y�k olmal�d�r.";
        public const string LuggageMustBePositive = "Bagaj kapasitesi 0 veya daha b�y�k olmal�d�r.";
        public const string InvalidMileage = "Kilometre bilgisi negatif olamaz.";
    }

    public static class CarFeatureValidationMessages
    {
        public const string CarIdRequired = "Ara� ID alan� zorunludur.";
        public const string FeatureIdRequired = "�zellik ID alan� zorunludur.";
        public const string IdRequired = "Ge�erli bir �zellik ID'si girilmelidir.";
    }

    public static class CarPricingValidationMessages
    {
        public const string AmountPositive = "Fiyat bilgisi s�f�rdan b�y�k olmal�d�r.";
        public const string CarIdRequired = "Ara� ID'si belirtilmelidir.";
        public const string PricingIdRequired = "Fiyatland�rma ID'si belirtilmelidir.";
        public const string IdRequired = "CarPricing ID'si ge�erli olmal�d�r.";
    }

    public static class PricingValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameRequired = "Fiyatlandırma adı zorunludur.";
    }


    /// <summary>
    /// "Kategori" (Category) varlığı için doğrulama mesajları.
    /// </summary>
    public static class CategoryValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameRequired = "Kategori adı zorunludur.";
        public const string NameLength = "Kategori adı en az 2, en fazla 50 karakter olmalıdır.";
        public const string NameInvalidChars = "Kategori adı yalnızca harf, sayı, boşluk ve noktalama işaretleri içerebilir.";
        public const string NameAlreadyExists = "Bu kategori adı zaten kullanımda.";
        public const string InvalidId = "Geçerli bir kategori ID'si girilmelidir.";
    }

    public static class FeatureValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameRequired = "Özellik adı zorunludur.";
    }

    public static class FooterAdressValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string DescriptionRequired = "Açıklama alanı zorunludur.";
        public const string AdressRequired = "Adres alanı zorunludur.";
        public const string PhoneRequired = "Telefon alanı zorunludur.";
        public const string EmailRequired = "Email alanı zorunludur.";
    }

    public static class LocationValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameRequired = "Lokasyon adı zorunludur.";
    }

    public static class ServiceValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string TitleRequired = "Başlık alanı zorunludur.";
        public const string DescriptionRequired = "Açıklama alanı zorunludur.";
        public const string IconUrlRequired = "IconUrl alanı zorunludur.";
    }

    public static class SocialMediaValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameRequired = "Ad alanı zorunludur.";
        public const string UrlRequired = "Url alanı zorunludur.";
        public const string IconRequired = "Icon alanı zorunludur.";
    }

    public static class TestimonialValidationMessages
    {
        public const string IdRequired = "Id alanı boş olamaz";
        public const string NameRequired = "Ad alanı zorunludur.";
        public const string TitleRequired = "Başlık alanı zorunludur.";
        public const string CommentRequired = "Yorum alanı zorunludur.";
        public const string ImageUrlRequired = "Görsel alanı zorunludur.";
    }
}