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
    public partial class Form1 : Form
    {
        // GLOBAL DEĞİŞKEN: Giriş yapanın adını burada tutuyoruz.
        public static string kadi = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus(); // İmleç direkt burada başlar
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FormKayit fr = new FormKayit();
            fr.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. BAĞLANTIYI HAZIRLA
            SQLBaglantisi bgl = new SQLBaglantisi();
            SqlConnection conn = bgl.Baglanti();

            // --- YENİ EKLENEN KISIM: ŞİFRELEME ---
            // Kullanıcının girdiği şifreyi (Örn: 1234) veritabanındaki formatına (MD5) çeviriyoruz.
            // Çünkü veritabanında şifreler gizli (hashlenmiş) saklanıyor.
            string kodlanmisGirisSifresi = bgl.MD5Sifrele(txtParola.Text);

            // 2. SORGUSU OLUŞTURMA
            // Sorguda artık kullanıcının yazdığını değil, kodlanmış halini soruyoruz.
            // Eşleşme olması için bu şart.
            string sorgu = "SELECT * FROM tblKullanicilar WHERE KullaniciAdi='" + txtKullaniciAdi.Text + "' AND Sifre='" + kodlanmisGirisSifresi + "'";

            SqlCommand komut = new SqlCommand(sorgu, conn);

            // 3. OKUMA VE KONTROL
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                // Giriş Başarılı
                kadi = txtKullaniciAdi.Text;
                MessageBox.Show("Giriş Başarılı! Menüye yönlendiriliyorsunuz...");

                FormMenu frm = new FormMenu();
                frm.Show();
                this.Hide();
            }
            else
            {
                // Giriş Başarısız
                MessageBox.Show("Hatalı Kullanıcı Adı veya Parola!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close(); // Bağlantıyı kapatmayı unutmuyoruz
        }
    }
}