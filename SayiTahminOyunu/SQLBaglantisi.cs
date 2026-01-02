using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SQL Server ile iletişim kurmamızı sağlayan temel kütüphane.
// Bu kütüphane olmadan SqlConnection, SqlCommand gibi komutları kullanamayız.
using System.Data.SqlClient;

namespace SayiTahminOyunu
{
    // VERİTABANI BAĞLANTI SINIFI (Database Connection Class)
    // Amaç: Projenin her formunda (Giriş, Kayıt, Oyun) tekrar tekrar bağlantı cümlesi yazmamak.
    // Bağlantı adresini tek bir yerden yöneterek kod tekrarını önlüyoruz.
    class SQLBaglantisi
    {
        // Bu metot geriye açık bir "SqlConnection" nesnesi döndürür.
        public SqlConnection Baglanti()
        {
            // 1. BAĞLANTI CÜMLESİ (Connection String)
            // Data Source: Sunucu adresi (.\SQLEXPRESS veya . nokta işareti 'yerel bilgisayar' demektir).
            // Initial Catalog: Bağlanacağımız veritabanının adı.
            // Integrated Security=True: Şifre yazmadan, Windows hesabıyla güvenli giriş yap.
            SqlConnection baglan = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ProjeOyunDB;Integrated Security=True");

            // 2. BAĞLANTIYI AÇMA
            // Bağlantıyı burada açıyoruz ki, çağıran form tekrar açmakla uğraşmasın.
            baglan.Open();

            // 3. NESNEYİ GÖNDERME
            // Açık haldeki bağlantıyı, bu metodu çağıran yere (Örn: Form1'e) teslim ediyoruz.
            return baglan;
        }
    }
}
