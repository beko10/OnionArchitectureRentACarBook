namespace OnionArchitectureRentACarBook.Application.Common.Messages;

public static class OperationMessages
{
    public static class AboutOperationMessages
    {
        // Create Messages
        public const string CreateSuccess = "Hakkımızda bilgisi başarıyla oluşturuldu.";
        public const string CreateFailed = "Hakkımızda bilgisi oluşturulurken bir hata oluştu.";
        public const string CreateFailedWithDetail = "Hakkımızda bilgisi oluşturulurken hata: {0}";

        // Update Messages
        public const string UpdateSuccess = "Hakkımızda bilgisi başarıyla güncellendi.";
        public const string UpdateFailed = "Hakkımızda bilgisi güncellenirken bir hata oluştu.";
        public const string UpdateFailedWithDetail = "Hakkımızda bilgisi güncellenirken hata: {0}";
        public const string UpdateNotFound = "Güncellenecek hakkımızda bilgisi bulunamadı.";

        // Delete Messages
        public const string DeleteSuccess = "Hakkımızda bilgisi başarıyla silindi.";
        public const string DeleteFailed = "Hakkımızda bilgisi silinirken bir hata oluştu.";
        public const string DeleteFailedWithDetail = "Hakkımızda bilgisi silinirken hata: {0}";
        public const string DeleteNotFound = "Silinecek hakkımızda bilgisi bulunamadı.";

        // Get Messages
        public const string GetSuccess = "Hakkımızda bilgisi başarıyla getirildi.";
        public const string GetNotFound = "Hakkımızda bilgisi bulunamadı.";
        public const string GetAllSuccess = "Hakkımızda bilgileri başarıyla getirildi.";
        public const string GetAllEmpty = "Henüz hakkımızda bilgisi bulunmamaktadır.";
    }

    public static class BannerOperationMessages
    {
        // Create Messages
        public const string CreateSuccess = "Banner bilgisi başarıyla oluşturuldu.";
        public const string CreateFailed = "Banner bilgisi oluşturulurken bir hata oluştu.";
        public const string CreateFailedWithDetail = "Banner bilgisi oluşturulurken hata: {0}";

        // Update Messages
        public const string UpdateSuccess = "Banner bilgisi başarıyla güncellendi.";
        public const string UpdateFailed = "Banner bilgisi güncellenirken bir hata oluştu.";
        public const string UpdateFailedWithDetail = "Banner bilgisi güncellenirken hata: {0}";
        public const string UpdateNotFound = "Güncellenecek banner bilgisi bulunamadı.";

        // Delete Messages
        public const string DeleteSuccess = "Banner bilgisi başarıyla silindi.";
        public const string DeleteFailed = "Banner bilgisi silinirken bir hata oluştu.";
        public const string DeleteFailedWithDetail = "Banner bilgisi silinirken hata: {0}";
        public const string DeleteNotFound = "Silinecek banner bilgisi bulunamadı.";

        // Get Messages
        public const string GetSuccess = "Banner bilgisi başarıyla getirildi.";
        public const string GetNotFound = "Banner bilgisi bulunamadı.";
        public const string GetAllSuccess = "Banner bilgileri başarıyla getirildi.";
        public const string GetAllEmpty = "Henüz banner bilgisi bulunmamaktadır.";
    }

}
