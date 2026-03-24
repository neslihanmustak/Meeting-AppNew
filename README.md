# Meeting App

Basit bir ASP.NET Core MVC uygulaması. Kullanıcılar toplantı katılım formunu doldurur, katılım durumuna göre teşekkür/ret mesajı görür ve katılımcı listesini inceleyebilir.

**Öne çıkanlar**
1. Toplantı bilgisi ve selamlama (günün saatine göre) gösterimi.
2. Katılım formu (ad, telefon, e‑posta, katılım durumu).
3. Sunucu tarafı doğrulama (DataAnnotations).
4. Katılımcı listesi ve detay sayfası.
5. Basit in‑memory repository ile demo veri.

**Sayfalar**
1. `GET /` veya `GET /Home/Index`  
Toplantı bilgilerini ve “Başvuru Yap” butonunu gösterir.
2. `GET /Meeting/Apply`  
Başvuru formu.
3. `POST /Meeting/Apply`  
Form doğrulaması başarılıysa teşekkür sayfasına yönlendirir.
4. `GET /Meeting/List`  
Katılımcı listesini gösterir.
5. `GET /Meeting/Details/{id}`  
Katılımcı detayını gösterir.

**Teknik Özet**
1. ASP.NET Core MVC, Razor Views
2. `Models/Repository.cs` içinde in‑memory liste
3. Bootstrap tabanlı basit UI (LibMan ile)

**Çalıştırma**
1. .NET SDK kurulu olmalı.
2. Proje klasöründe:
```bash
dotnet restore
dotnet run
```
3. Tarayıcıda `http://localhost:5114` adresine gidin (varsayılan).

