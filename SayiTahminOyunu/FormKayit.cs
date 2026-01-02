using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// SQL kütüphanesi
using System.Data.SqlClient;

namespace SayiTahminOyunu
{
    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();
        }

        private void btnKayitTamamla_Click(object sender, EventArgs e)
        {
            // 1. BOŞ ALAN KONTROLÜ
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtKayitKadi.Text == "" || txtKayitParola.Text == "")
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurunuz!", "Eksik Bilgi");
                return;
            }

            // 2. BAĞLANTIYI AÇ
            SQLBaglantisi bgl = new SQLBaglantisi();
            SqlConnection baglanti = bgl.Baglanti();

            // --- YENİ EKLENEN KISIM: ŞİFRELEME ---
            // Kullanıcının girdiği şifreyi alıp MD5 fonksiyonuna gönderiyoruz.
            // Geriye karmaşık, şifrelenmiş bir metin dönüyor.
            string kodlanmisSifre = bgl.MD5Sifrele(txtKayitParola.Text);

            // 3. KOMUTU HAZIRLA
            // Dikkat: En sondaki 'VALUES' kısmında artık txtKayitParola.Text değil, 
            // yukarıdaki 'kodlanmisSifre' değişkenini kullanıyoruz.
            string sorgu = "INSERT INTO tblKullanicilar (Ad, Soyad, Telefon, Eposta, KullaniciAdi, Sifre) VALUES ('" + txtAd.Text + "', '" + txtSoyad.Text + "', '" + txtTelefon.Text + "', '" + txtEposta.Text + "', '" + txtKayitKadi.Text + "', '" + kodlanmisSifre + "')";

            SqlCommand komut = new SqlCommand(sorgu, baglanti);

            // 4. ÇALIŞTIR VE KAPAT
            komut.ExecuteNonQuery(); // Veritabanına kaydet
            baglanti.Close();        // Bağlantıyı kapat 

            // 5. BİLGİ VER
            MessageBox.Show("Kayıt Başarılı! Şifreniz güvenli bir şekilde oluşturuldu.", "Bilgi");
            this.Close(); // Formu kapat
        }
    }
}