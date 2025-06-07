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
        public const string TitleRequired = "Hakk�m�zda ba�l��� zorunludur.";
        public const string DescriptionRequired = "Hakk�m�zda a��klamas� zorunludur.";
        public const string InvalidTitleCharacters = "Ba�l�k ge�ersiz karakter i�eriyor.";
        public const string ImageUrlRequired = "Hakk�m�zda g�rsel URL'si zorunludur.";
        public const string InvalidImageUrl = "L�tfen ge�erli bir g�rsel URL'si giriniz (.jpg, .png, .gif vb.).";
    }

    /// <summary>
    /// "Ara�" (Car) varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class CarValidationMessages
    {
        public const string BrandRequired = "Ara� markas� zorunludur.";
        public const string ModelRequired = "Ara� modeli zorunludur.";
        public const string YearRequired = "Ara� model y�l� zorunludur.";
        public const string InvalidYear = "Model y�l� 1900 ile g�ncel y�l aras�nda olmal�d�r.";
        public const string InvalidLicensePlate = "Ge�ersiz plaka format�. (�rnek: 34 ABC 1234)";
        public const string FuelTypeRequired = "Yak�t t�r� se�imi zorunludur.";
        public const string TransmissionRequired = "Vites t�r� se�imi zorunludur.";
        public const string InvalidMileage = "Kilometre bilgisi s�f�r veya pozitif bir de�er olmal�d�r.";
        public const string InvalidDailyPrice = "G�nl�k kiralama �creti s�f�rdan b�y�k olmal�d�r.";
    }

    /// <summary>
    /// "Kullan�c�" (User) varl��� i�in do�rulama mesajlar�.
    /// </summary>
    public static class UserValidationMessages
    {
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
        public const string NameRequired = "Ad Soyad zorunludur.";
        public const string EmailRequired = "E-posta adresi zorunludur.";
        public const string SubjectRequired = "Konu ba�l��� zorunludur.";
        public const string MessageRequired = "Mesaj i�eri�i zorunludur.";
        public const string MessageTooShort = "Mesaj en az 10 karakter olmal�d�r.";
        public const string MessageTooLong = "Mesaj en fazla 1000 karakter olmal�d�r.";
    }
}