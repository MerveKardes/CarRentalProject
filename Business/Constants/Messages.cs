using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string Added = "Ekleme başarılı";
        public static string AddedInvalid = "Ekleme başarısız";
        public static string Deleted = "Silme başarılı";
        public static string DeletedInvalid = "Silme başarısız";
        public static string Updated = "Güncelleme başarılı";
        public static string UpdatedInvalid = "Güncelleme başarısız";
        public static string Listed = "Arabalar listelendi";
        public static string CarRentalInvalid = "Araba kiralanamaz";
        public static string RentalAdded = "Araba kiralama başarılı";
        public static string FailedCarImageAdd;
        public static string DeletedCarImage;
        public static string AddedCarImage;
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        internal static string SuccessfulLogin;
    }
}
