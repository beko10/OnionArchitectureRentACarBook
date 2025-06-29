using OnionArchitectureRentACarBook.Domain.Common;

namespace OnionArchitectureRentACarBook.Domain.Entities;

public sealed class About : BaseEntity 
{
    public string Title { get;  set; }
    public string Description { get;  set; }
    public string ImageUrl { get;  set; }

    //public About()
    //{"
    //    Title = string.Empty;
    //    Description = string.Empty;
    //    ImageUrl = string.Empty;
    //}

    //public About(string title, string description, string imageUrl)
    //{
    //    Title = title;
    //    Description = description;
    //    ImageUrl = imageUrl;
    //}

    //// Factory Method
    //public static About Create(string title, string description, string imageUrl)
    //{
    //    return new About(title, description, imageUrl);
    //}
    
    //public void Update(string title, string description, string imageUrl)
    //{
    //    SetValidateTitle(title);
    //    SetValidateDescription(description);
    //    SetValidateImageUrl(imageUrl);
    //}


    //// Validation Methods
    //private void SetValidateTitle(string title)
    //{
    //    if (string.IsNullOrWhiteSpace(title))
    //        throw new ArgumentException("Title cannot be empty.", nameof(title));
    //    if (title.Length > 100)
    //        throw new ArgumentException("Title cannot exceed 100 characters.", nameof(title));
    //    if (title.Length < 5)
    //        throw new ArgumentException("Title must be at least 5 characters long.", nameof(title));
    //    Title = title;
    //}

    //private void SetValidateDescription(string description)
    //{
    //    if (string.IsNullOrWhiteSpace(description))
    //        throw new ArgumentException("Description cannot be empty.", nameof(description));
    //    if (description.Length > 500)
    //        throw new ArgumentException("Description cannot exceed 500 characters.", nameof(description));
    //    if (description.Length < 10)
    //        throw new ArgumentException("Description must be at least 10 characters long.", nameof(description));
    //    Description = description;
    //}

    //private void SetValidateImageUrl(string imageUrl)
    //{
    //    if (string.IsNullOrWhiteSpace(imageUrl))
    //        throw new Exception("Resim URL'si boş olamaz");

    //    if (!IsValidImageUrl(imageUrl))
    //        throw new Exception("Geçersiz resim URL formatı");

    //    ImageUrl = imageUrl.Trim();

    //    ImageUrl = imageUrl.Trim();
    //}

    //private static bool IsValidImageUrl(string url)
    //{
    //    if (!Uri.TryCreate(url, UriKind.Absolute, out var result))
    //        return false;

    //    if (result.Scheme != Uri.UriSchemeHttp && result.Scheme != Uri.UriSchemeHttps)
    //        return false;

    //    // Resim dosya uzantısı kontrolü
    //    var validExtensions = new[] { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".webp" };
    //    var extension = Path.GetExtension(result.AbsolutePath).ToLowerInvariant();

    //    return validExtensions.Contains(extension);
    //}


    //Business Logic Methods





}
