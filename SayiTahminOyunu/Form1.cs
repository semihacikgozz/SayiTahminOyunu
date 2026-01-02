using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// SQL Server ile iletişim kurmamızı sağlayan kütüphane
using System.Data.SqlClient;

namespace SayiTahminOyunu
{
    // Giriş Ekranı (Login Form)
    public partial class Form1 : Form
    {
        // GLOBAL DEĞİŞKEN:
        // 'static' ifadesi ile bu değişkene projenin her yerinden ulaşılmasını sağlıyoruz.
        // Amaç: Giriş yapan kullanıcının adını (kadi) hafızada tutup Oyun ekranına taşımak.
        public static string kadi = "";

        public Form1()
        {
            InitializeComponent();
        }

        // --- FORM YÜKLENDİĞİNDE ÇALIŞAN KODLAR ---
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kullanıcı kolaylığı (UX): Form açılır açılmaz imleç 
            // Kullanıcı Adı kutusunda yanıp sönsün, tıklamakla uğraşmasın.
            txtKullaniciAdi.Focus();
        }

        // --- KAYIT OL BUTONU ---
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            // Kayıt olma formunu (nesnesini) türetiyoruz.
            FormKayit fr = new FormKayit();

            // Kayıt formunu ekrana getiriyoruz (Show).
            fr.Show();
        }

        // --- GİRİŞ YAP BUTONU (KRİTİK BÖLÜM) ---
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. ADIM: BAĞLANTIYI HAZIRLAMA
            // Veritabanı bağlantılarını yönettiğimiz sınıfı çağırıyoruz.
            SQLBaglantisi bgl = new SQLBaglantisi();

            // Bağlantı nesnesini bir değişkene atıyoruz ki işlem bitince kapatabilelim.
            // Bu yöntem sunucu kaynaklarını verimli kullanmak için önemlidir.
            SqlConnection conn = bgl.Baglanti();

            // 2. ADIM: SORGUSU OLUŞTURMA (Query)
            // Kullanıcının girdiği Ad ve Şifre veritabanında var mı?
            // String birleştirme yöntemi ile SQL sorgusunu dinamik olarak oluşturuyoruz.
            string sorgu = "SELECT * FROM tblKullanicilar WHERE KullaniciAdi='" + txtKullaniciAdi.Text + "' AND Sifre='" + txtParola.Text + "'";

            // 3. ADIM: KOMUTU GÖNDERME
            // Sorguyu ve açık olan bağlantıyı SqlCommand nesnesine teslim ediyoruz.
            SqlCommand komut = new SqlCommand(sorgu, conn);

            // 4. ADIM: VERİYİ OKUMA (Reading)
            // ExecuteReader: Veritabanından gelen sonuçları okumak için kullanılır (Select işlemleri için).
            SqlDataReader dr = komut.ExecuteReader();

            // 5. ADIM: KONTROL VE YÖNLENDİRME
            // dr.Read(): Eğer sorgu sonucunda eşleşen bir kayıt (satır) bulunursa TRUE döner.
            if (dr.Read())
            {
                // Giriş Başarılıysa:
                kadi = txtKullaniciAdi.Text; // Kullanıcının adını statik değişkene ata.

                MessageBox.Show("Giriş Başarılı! Menüye yönlendiriliyorsunuz...");

                // Menü formunu aç
                FormMenu frm = new FormMenu();
                frm.Show();

                // Giriş ekranını (bu formu) gizle, arkada açık kalmasın.
                this.Hide();
            }
            else
            {
                // Giriş Başarısızsa:
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 6. ADIM: TEMİZLİK
            // İşimiz bittiğinde bağlantıyı mutlaka kapatıyoruz.
            // Açık kalan bağlantılar veritabanı performansını düşürebilir.
            conn.Close();
        }
    }
}