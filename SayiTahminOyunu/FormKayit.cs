using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// SQL Server veritabanı işlemleri için gerekli kütüphane
using System.Data.SqlClient;

namespace SayiTahminOyunu
{
    // Kayıt Ol Ekranı (Registration Form)
    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();
        }

        // --- KAYDI TAMAMLA BUTONU ---
        private void btnKayitTamamla_Click(object sender, EventArgs e)
        {
            // 1. ADIM: VERİ DOĞRULAMA (Validation)
            // Veritabanına boş veri gitmesini engellemek için kontrol yapıyoruz.
            // || (veya) operatörü ile herhangi bir kutu boşsa işlemi durduruyoruz.
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtKayitKadi.Text == "" || txtKayitParola.Text == "")
            {
                MessageBox.Show("Lütfen zorunlu alanları (Ad, Soyad, Kullanıcı Adı, Şifre) doldurunuz!", "Eksik Bilgi");
                return; // Kodun geri kalanını çalıştırma, fonksiyonu burada bitir.
            }

            // 2. ADIM: BAĞLANTIYI AÇMA
            // Merkezi bağlantı sınıfımızdan nesne üretiyoruz.
            SQLBaglantisi bgl = new SQLBaglantisi();

            // Bağlantıyı açıp bir değişkene atıyoruz.
            SqlConnection baglanti = bgl.Baglanti();

            // 3. ADIM: SQL INSERT KOMUTU HAZIRLAMA
            // "INSERT INTO": Veritabanına yeni kayıt eklemek için kullanılan SQL komutu.
            // Kullanıcının TextBox'lara girdiği verileri (Text) SQL sorgusuna ekliyoruz.
            // String birleştirme (+) yöntemi kullanarak sorguyu dinamik oluşturuyoruz.
            string sorgu = "INSERT INTO tblKullanicilar (Ad, Soyad, Telefon, Eposta, KullaniciAdi, Sifre) VALUES ('" + txtAd.Text + "', '" + txtSoyad.Text + "', '" + txtTelefon.Text + "', '" + txtEposta.Text + "', '" + txtKayitKadi.Text + "', '" + txtKayitParola.Text + "')";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            // 4. ADIM: SORGUYU ÇALIŞTIRMA (Execution)
            // ExecuteNonQuery: "Sorguyu çalıştır ama bana veri getirme" demektir.
            // INSERT, UPDATE, DELETE gibi işlemler için kullanılır.
            komut.ExecuteNonQuery();

            // 5. ADIM: KAYNAK YÖNETİMİ
            // İşlem bittiğinde veritabanı bağlantısını mutlaka kapatıyoruz.
            baglanti.Close();

            // 6. ADIM: GERİ BİLDİRİM VE YÖNLENDİRME
            MessageBox.Show("Kayıt Başarılı! Giriş yapabilirsiniz.", "Bilgi");

            // Kayıt ekranını kapat (Kullanıcı giriş ekranına geri döner)
            this.Close();
        }
    }
}