﻿namespace OnionArchitectureRentACarBook.Application.Common.Messages;

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

    public static class BrandOperationMessages
    {
        // Create Messages
        public const string CreateSuccess = "Brand bilgisi başarıyla oluşturuldu.";
        public const string CreateFailed = "Brand bilgisi oluşturulurken bir hata oluştu.";
        public const string CreateFailedWithDetail = "Brand bilgisi oluşturulurken hata: {0}";

        // Update Messages
        public const string UpdateSuccess = "Brand bilgisi başarıyla güncellendi.";
        public const string UpdateFailed = "Brand bilgisi güncellenirken bir hata oluştu.";
        public const string UpdateFailedWithDetail = "Brand bilgisi güncellenirken hata: {0}";
        public const string UpdateNotFound = "Güncellenecek brand bilgisi bulunamadı.";

        // Delete Messages
        public const string DeleteSuccess = "Brand bilgisi başarıyla silindi.";
        public const string DeleteFailed = "Brand bilgisi silinirken bir hata oluştu.";
        public const string DeleteFailedWithDetail = "Brand bilgisi silinirken hata: {0}";
        public const string DeleteNotFound = "Silinecek brand bilgisi bulunamadı.";

        // Get Messages
        public const string GetSuccess = "Brand bilgisi başarıyla getirildi.";
        public const string GetNotFound = "Brand bilgisi bulunamadı.";
        public const string GetAllSuccess = "Brand bilgileri başarıyla getirildi.";
        public const string GetAllEmpty = "Henüz brand bilgisi bulunmamaktadır.";
    }

    public static class CarOperationMessages
    {
        // Create Messages
        public const string CreateSuccess = "Car bilgisi başarıyla oluşturuldu.";
        public const string CreateFailed = "Car bilgisi oluşturulurken bir hata oluştu.";
        public const string CreateFailedWithDetail = "Car bilgisi oluşturulurken hata: {0}";

        // Update Messages
        public const string UpdateSuccess = "Car bilgisi başarıyla güncellendi.";
        public const string UpdateFailed = "Car bilgisi güncellenirken bir hata oluştu.";
        public const string UpdateFailedWithDetail = "Car bilgisi güncellenirken hata: {0}";
        public const string UpdateNotFound = "Güncellenecek car bilgisi bulunamadı.";

        // Delete Messages
        public const string DeleteSuccess = "Car bilgisi başarıyla silindi.";
        public const string DeleteFailed = "Car bilgisi silinirken bir hata oluştu.";
        public const string DeleteFailedWithDetail = "Car bilgisi silinirken hata: {0}";
        public const string DeleteNotFound = "Silinecek car bilgisi bulunamadı.";

        // Get Messages
        public const string GetSuccess = "Car bilgisi başarıyla getirildi.";
        public const string GetNotFound = "Car bilgisi bulunamadı.";
        public const string GetAllSuccess = "Car bilgileri başarıyla getirildi.";
        public const string GetAllEmpty = "Henüz car bilgisi bulunmamaktadır.";
    }

    public static class CarFeatureOperationMessages
    {
        // Create Messages
        public const string CreateSuccess = "Araç özelliği başarıyla eklendi.";
        public const string CreateFailed = "Araç özelliği eklenirken bir hata oluştu.";
        public const string CreateFailedWithDetail = "Araç özelliği eklenirken hata: {0}";

        // Update Messages
        public const string UpdateSuccess = "Araç özelliği başarıyla güncellendi.";
        public const string UpdateFailed = "Araç özelliği güncellenirken bir hata oluştu.";
        public const string UpdateFailedWithDetail = "Araç özelliği güncellenirken hata: {0}";
        public const string UpdateNotFound = "Güncellenecek araç özelliği bulunamadı.";

        // Delete Messages
        public const string DeleteSuccess = "Araç özelliği başarıyla silindi.";
        public const string DeleteFailed = "Araç özelliği silinirken bir hata oluştu.";
        public const string DeleteFailedWithDetail = "Araç özelliği silinirken hata: {0}";
        public const string DeleteNotFound = "Silinecek araç özelliği bulunamadı.";

        // Get Messages
        public const string GetSuccess = "Araç özelliği başarıyla getirildi.";
        public const string GetNotFound = "Araç özelliği bulunamadı.";
        public const string GetAllSuccess = "Araç özellikleri başarıyla getirildi.";
        public const string GetAllEmpty = "Henüz araç özelliği bilgisi bulunmamaktadır.";
    }

    public static class CarPricingOperationMessages
    {
        // Create Messages
        public const string CreateSuccess = "Araç fiyatlandırması başarıyla oluşturuldu.";
        public const string CreateFailed = "Araç fiyatlandırması oluşturulurken bir hata oluştu.";
        public const string CreateFailedWithDetail = "Araç fiyatlandırması oluşturulurken hata: {0}";

        // Update Messages
        public const string UpdateSuccess = "Araç fiyatlandırması başarıyla güncellendi.";
        public const string UpdateFailed = "Araç fiyatlandırması güncellenirken bir hata oluştu.";
        public const string UpdateFailedWithDetail = "Araç fiyatlandırması güncellenirken hata: {0}";
        public const string UpdateNotFound = "Güncellenecek araç fiyatlandırması bulunamadı.";

        // Delete Messages
        public const string DeleteSuccess = "Araç fiyatlandırması başarıyla silindi.";
        public const string DeleteFailed = "Araç fiyatlandırması silinirken bir hata oluştu.";
        public const string DeleteFailedWithDetail = "Araç fiyatlandırması silinirken hata: {0}";
        public const string DeleteNotFound = "Silinecek araç fiyatlandırması bulunamadı.";

        // Get Messages
        public const string GetSuccess = "Araç fiyatlandırması başarıyla getirildi.";
        public const string GetNotFound = "Araç fiyatlandırması bulunamadı.";
        public const string GetAllSuccess = "Araç fiyatlandırmaları başarıyla getirildi.";
        public const string GetAllEmpty = "Henüz araç fiyatlandırması bilgisi bulunmamaktadır.";
    }

    public static class CategoryOperationMessages
    {
        // Create Messages
        public const string CreateSuccess = "Kategori başarıyla oluşturuldu.";
        public const string CreateFailed = "Kategori oluşturulurken bir hata oluştu.";
        public const string CreateFailedWithDetail = "Kategori oluşturulurken hata: {0}";

        // Update Messages
        public const string UpdateSuccess = "Kategori başarıyla güncellendi.";
        public const string UpdateFailed = "Kategori güncellenirken bir hata oluştu.";
        public const string UpdateFailedWithDetail = "Kategori güncellenirken hata: {0}";
        public const string UpdateNotFound = "Güncellenecek kategori bulunamadı.";

        // Delete Messages
        public const string DeleteSuccess = "Kategori başarıyla silindi.";
        public const string DeleteFailed = "Kategori silinirken bir hata oluştu.";
        public const string DeleteFailedWithDetail = "Kategori silinirken hata: {0}";
        public const string DeleteNotFound = "Silinecek kategori bulunamadı.";

        // Get Messages
        public const string GetSuccess = "Kategori başarıyla getirildi.";
        public const string GetNotFound = "Kategori bulunamadı.";
        public const string GetAllSuccess = "Kategoriler başarıyla getirildi.";
        public const string GetAllEmpty = "Henüz kategori bulunmamaktadır.";

        // Business Logic Messages
        public const string NameAlreadyExists = "Bu kategori adı zaten kullanımda.";
        public const string CategoryInUse = "Bu kategori kullanımda olduğu için silinemez.";
        public const string CategoryHasRelatedRecords = "Bu kategoriye bağlı kayıtlar bulunduğu için silinemez.";
    }
}
