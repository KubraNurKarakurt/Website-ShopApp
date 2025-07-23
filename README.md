# Website-ShopApp


ShopApp, ofis ürünleri için hazırlanmış bir e-ticaret web uygulamasıdır. Kullanıcılar ürünleri inceleyebilir, sepete ekleyebilir, sipariş verebilir ve yönetici paneli üzerinden ürün yönetimi yapılabilir.

![Banner](./images/banner.png)

##  Proje Özellikleri

-  Ürün listeleme, detay, kategoriye göre filtreleme
-  Ürün ekleme, düzenleme, silme (Yönetici için)
-  Sepete ürün ekleme, silme, sepet görüntüleme
-  Sipariş oluşturma ve sipariş geçmişi
-  Kullanıcı kayıt/giriş sistemi (Identity ile)
-  Rol tabanlı yetkilendirme (Admin/Kullanıcı)
-  Admin paneli
-  SQLite veritabanı ve EF Core ORM
-  Katmanlı mimari (N-Tier Architecture)
-  MVC mimarisiyle geliştirilmiş frontend/backend

##  Kullanılan Teknolojiler

- ASP.NET Core MVC (.NET)
- Entity Framework Core
- Identity (Kullanıcı yönetimi)
- HTML, CSS, JavaScript
- Bootstrap
- SQLite

##  Veritabanı Yapısı

![Veritabanı Şeması](./images/database-schema.png)


### Gereksinimler

- [.NET 6 SDK veya üstü](https://dotnet.microsoft.com/)
- Visual Studio veya Visual Studio Code



##  Kullanıcı Rolleri

- **Admin**: Ürünleri ve siparişleri yönetebilir
- **Kullanıcı**: Ürünleri görüntüleyip sipariş verebilir

##  Ekran Görüntüsü

Ana sayfa:

![Ana Sayfa](./images/banner.png)
