namespace OnionArchitectureRentACarBook.Application.Common.ValidationPatterns;


/// <summary>
/// FluentValidation doğrulamaları için kullanılan regex pattern'larını içerir.
/// </summary>
public static class ValidationRegexPatterns
{
    /// <summary>
    /// Genel pattern'lar
    /// </summary>
    public static class CommonRegexPatterns
    {
        /// <summary>
        /// Türkçe ve İngilizce karakterler, sayılar, boşluk ve temel noktalama işaretleri
        /// </summary>
        public const string BasicText = @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s\d\-_.,!?]+$";

        /// <summary>
        /// E-posta adresi pattern'ı
        /// </summary>
        public const string Email = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        /// <summary>
        /// Telefon numarası pattern'ı (Türkiye formatı)
        /// </summary>
        public const string PhoneNumber = @"^(\+90|0)?[1-9]\d{2}\s?\d{3}\s?\d{2}\s?\d{2}$";

        /// <summary>
        /// Alfanumerik karakterler (sadece harf ve rakam)
        /// </summary>
        public const string AlphaNumeric = @"^[a-zA-Z0-9ğüşıöçĞÜŞİÖÇ]+$";
    }

    /// <summary>
    /// Banner varlığı için özel pattern'lar
    /// </summary>
    public static class BannerRegexPatterns
    {
        /// <summary>
        /// Banner başlığı için izin verilen karakterler
        /// </summary>
        public const string TitleCharacters = @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s\d\-_.,!?]+$";
    }

    /// <summary>
    /// URL pattern'ları
    /// </summary>
    public static class UrlRegexPatterns
    {
        /// <summary>
        /// YouTube URL pattern'ları
        /// </summary>
        public const string YouTube = @"^https?://(www\.)?(youtube\.com|youtu\.be)/.*";

        /// <summary>
        /// Vimeo URL pattern'ı
        /// </summary>
        public const string Vimeo = @"^https?://(www\.)?vimeo\.com/.*";

        /// <summary>
        /// Dailymotion URL pattern'ı
        /// </summary>
        public const string Dailymotion = @"^https?://(www\.)?dailymotion\.com/.*";

        /// <summary>
        /// Twitch URL pattern'ı
        /// </summary>
        public const string Twitch = @"^https?://(www\.)?twitch\.tv/.*";

        /// <summary>
        /// Video dosya uzantıları pattern'ı
        /// </summary>
        public const string VideoFileExtensions = @".*\.(mp4|avi|mov|wmv|flv|webm|mkv|m4v)(\?.*)?$";

        /// <summary>
        /// Tüm desteklenen video URL pattern'ları
        /// </summary>
        public static readonly string[] SupportedVideoUrls =
        {
            YouTube,
            Vimeo,
            Dailymotion,
            Twitch,
            VideoFileExtensions
        };
    }

    /// <summary>
    /// About (Hakkımızda) varlığı için pattern'lar
    /// </summary>
    public static class AboutRegexPatterns
    {
        /// <summary>
        /// Hakkımızda başlığı için izin verilen karakterler
        /// </summary>
        public const string TitleCharacters = @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s\d\-_.,!?:;]+$";

        /// <summary>
        /// Görsel URL'leri için pattern
        /// </summary>
        public const string ImageUrl = @".*\.(jpg|jpeg|png|gif|bmp|webp|svg)(\?.*)?$";
    }

    /// <summary>
    /// Araç (Car) varlığı için pattern'lar
    /// </summary>
    public static class CarRegexPatterns
    {
        /// <summary>
        /// Araç modeli için pattern
        /// </summary>
        public const string Model = @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s\d\-]+$";

        /// <summary>
        /// Plaka numarası pattern'ı (Türkiye formatı)
        /// </summary>
        public const string LicensePlate = @"^[0-9]{2}\s?[A-ZğüşıöçĞÜŞİÖÇ]{1,3}\s?[0-9]{2,4}$";
    }
}
