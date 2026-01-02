# SayiTahminOyunu

KTÜ Görsel Programlama II projesi olarak geliştirdiğim, veritabanı tabanlı sayı ve renk tahmin oyunu. Proje C# (Windows Forms) ve SQL Server kullanılarak hazırlanmıştır.

##Projenin Amacı ve Özellikleri
Bu projede, kullanıcının seçtiği zorluk seviyesine göre (3, 4, 5 basamaklı) rastgele üretilen farklı sayıları tahmin etmesi amaçlanmıştır. Ayrıca klasik sayı tahmininden farklı olarak "Renk Modu"da eklenmiştir.

**Öne Çıkan Özellikler:**
* **Farklı Oyun Modları:** 3, 4 ve 5 Basamaklı Sayı Tahmini ve Renk Tahmini seçenekleri.
* **Sanal Klavye:** Oyun, klavyesi olmayan cihazlarda da çalışabilmesi için ekrandaki butonlarla yönetilmektedir.
* **Kullanıcı Sistemi:** Kayıt olma ve güvenli giriş yapma ekranları mevcuttur.
* **Skor Tablosu:** Puan ve süre bilgileri SQL veritabanında tutulur, puana göre sıralı en yüksek 5 skor listelenir.
---

### Oyun Menüsü
Kullanıcının oyun türünü seçtiği ekran. Seçilen moda göre (Örn: 3 basamak veya Renk modu) değişkenler oyun formuna aktarılıyor.

### Oyun Ekranı (Sayı Modu)
Algoritma, rastgele sayı üretirken rakamların birbirinden farklı olmasını sağlar. Kullanıcı doğru tahmin ettiğinde puan hesaplanır (Zorluk seviyesi ve süreye göre) ve veritabanına kaydedilir.

### Renk Modu
Bu modda sayılar yerine renkler tahmin edilir. Arayüz dinamik olarak değişir; sayı tuşları gizlenip renk butonları aktif olur.

---

## Teknik Detaylar

**Veritabanı 
    * **Merkezi Bağlantı:** Her formda tekrar tekrar bağlantı kodu yazmak yerine `SQLBaglantisi.cs` adında bir sınıf oluşturdum. Tüm formlar bağlantıyı buradan çeker, böylece kod tekrarı önlenir.
    * **Bağlantılı & Bağlantısız Mimari:** * Giriş ve Kayıt işlemlerinde anlık veri okumak ve kontrol etmek için `SqlDataReader`  kullandım.
        * Skor listeleme işleminde ise veriyi toplu çekip Grid'e doldurmak için `SqlDataAdapter` ve `DataTable` (Bağlantısız Mimari) yapılarını kullandım.

* **Algoritma Mantığı:**
    * Sayıları veya renkleri üretirken `List` koleksiyon yapısını kullandım. `Contains` metodu ile üretilen sayının/rengin daha önce listede olup olmadığını kontrol ettim. Böylece tekrarsız (benzersiz) üretim sağladım.

---

## 🚀 Kurulum

Projeyi kendi bilgisayarınızda çalıştırmak için:
1.  SQL Server'da `ProjeOyunDB` adında bir veritabanı oluşturun.
2.  `tblKullanicilar` ve `tblSkorlar` tablolarını projeye uygun sütunlarla ekleyin.
3.  `SQLBaglantisi.cs` dosyasındaki "Connection String" adresini kendi bilgisayarınıza göre güncelleyin.
