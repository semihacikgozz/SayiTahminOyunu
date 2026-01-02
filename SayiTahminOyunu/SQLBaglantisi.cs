using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Gerekli Kütüphaneler:
using System.Data.SqlClient;           // SQL işlemleri için
using System.Security.Cryptography;    // MD5 Şifreleme için

namespace SayiTahminOyunu
{
    class SQLBaglantisi
    {
        // 1. BAĞLANTI METODU
        public SqlConnection Baglanti()
        {
            // Veritabanı adresimiz
            SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ProjeOyunDB;Integrated Security=True");

            baglan.Open(); // Bağlantıyı aç
            return baglan; // Açık bağlantıyı gönder
        }

        // 2. MD5 ŞİFRELEME METODU 
        public string MD5Sifrele(string sifrelenecekMetin)
        {
            // MD5 nesnesini oluşturuyoruz
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            // Metni byte dizisine çeviriyoruz
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);

            // Diziyi şifreliyoruz (Hash işlemi)
            dizi = md5.ComputeHash(dizi);

            // StringBuilder: Şifrelenmiş karmaşık karakterleri birleştirmek için kullanıyoruz
            StringBuilder sb = new StringBuilder();

            // Döngü ile şifreli byte'ları tek tek geziyoruz
            foreach (byte ba in dizi)
            {
                // Her byte'ı hex (onaltılık) formata çevirip string'e ekliyoruz
                sb.Append(ba.ToString("x2").ToLower());
            }

            // Sonuç olarak çıkan uzun şifreli metni geri döndürüyoruz
            return sb.ToString();
        }
    }
}