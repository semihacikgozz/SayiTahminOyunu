using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    // Oyun Seçim Menüsü (Game Selection Menu)
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        // --- 3 BASAMAKLI OYUN SEÇİMİ ---
        private void btn3Basamak_Click(object sender, EventArgs e)
        {
            // 1. ADIM: OYUN FORMUNU HAZIRLAMA (Instantiation)
            // 'FormOyun' sınıfından yeni bir nesne (oyun penceresi) türetiyoruz.
            FormOyun fr = new FormOyun();

            // 2. ADIM: PARAMETRE GÖNDERME (Data Passing)
            // Oluşturduğumuz form henüz ekrana gelmedi. 
            // Arka planda o formun halka açık (public) değişkenlerini ayarlıyoruz.
            fr.basamakSayisi = 3;  // Oyunun zorluk seviyesini belirliyoruz.
            fr.oyunTuru = "Sayi";  // Oyunun modunu (Sayı Tahmini) olarak ayarlıyoruz.

            // 3. ADIM: FORMU GÖSTERME VE GİZLEME
            fr.Show();     // Ayarladığımız oyun formunu kullanıcıya göster.
            this.Hide();   // Menü formunu gizle (Kapatma, arkada beklesin).
        }

        // --- 4 BASAMAKLI OYUN SEÇİMİ ---
        private void btn4Basamak_Click(object sender, EventArgs e)
        {
            FormOyun fr = new FormOyun();

            // Burada 4 basamaklı sayı üretilmesi için komut gönderiyoruz.
            fr.basamakSayisi = 4;
            fr.oyunTuru = "Sayi";

            fr.Show();
            this.Hide();
        }

        // --- 5 BASAMAKLI OYUN SEÇİMİ ---
        private void btn5Basamak_Click(object sender, EventArgs e)
        {
            FormOyun fr = new FormOyun();

            // En zor seviye: 5 basamaklı sayı tahmini.
            fr.basamakSayisi = 5;
            fr.oyunTuru = "Sayi";

            fr.Show();
            this.Hide();
        }

        // --- RENK MODU (BONUS ÖZELLİK) ---
        private void btnRenkModu_Click(object sender, EventArgs e)
        {
            FormOyun fr = new FormOyun();

            // Renk modu (Mastermind mantığı) genelde 4 haneli oynanır.
            fr.basamakSayisi = 4;

            // Oyun türünü "Renk" olarak işaretliyoruz.
            // FormOyun tarafı bu değişkeni kontrol edip arayüzü (Sayılar/Renkler) ona göre değiştirecek.
            fr.oyunTuru = "Renk";

            fr.Show();
            this.Hide();
        }
    }
}