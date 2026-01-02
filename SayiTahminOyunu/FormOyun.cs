using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// SQL Veritabanı kütüphanesi
using System.Data.SqlClient;

namespace SayiTahminOyunu
{
    // OYUN MOTORU (Game Engine)
    // Oyunun tüm mantığı, algoritması ve veritabanı etkileşimi bu formda döner.
    public partial class FormOyun : Form
    {
        // --- DIŞARIDAN GELEN AYARLAR (Configuration) ---
        // Menü formundan gönderilen zorluk seviyesi ve oyun türü.
        public int basamakSayisi = 0;   // Örn: 3, 4 veya 5
        public string oyunTuru = "";    // Örn: "Sayi" veya "Renk"

        // --- OYUN DEĞİŞKENLERİ ---
        // Bilgisayarın tuttuğu gizli şifreyi hafızada tutmak için Koleksiyon (List) kullanıyoruz.
        // Array yerine List kullandık çünkü eleman ekleyip çıkarmak (Add/Clear) daha kolay.
        List<int> gizliSayilar = new List<int>();
        List<string> gizliRenkler = new List<string>();

        // Renk Havuzu: Bilgisayar bu harflerden seçim yapacak.
        // K=Kırmızı, M=Mavi, Y=Yeşil, S=Sarı, P=Mor(Purple)
        string[] renkHavuzu = { "K", "M", "Y", "S", "P" };

        int sayac = 0; // Süreyi saniye cinsinden tutar.

        public FormOyun()
        {
            InitializeComponent();
        }

        // --- FORM YÜKLENİNCE (Setup) ---
        private void FormOyun_Load(object sender, EventArgs e)
        {
            // 1. KULLANICI BİLGİSİ
            // Giriş formundaki 'static' değişkeni alıp ekrana yazıyoruz.
            lblKullaniciAdi.Text = "Oyuncu: " + Form1.kadi;

            // 2. OYUNU BAŞLAT
            // Rastgele sayı/renk üretimini tetikliyoruz.
            OyunuBaslat();

            // 3. ARAYÜZ AYARLARI (UI Logic)
            lblGirilenSayi.Text = "";

            // Seçilen moda göre tuş takımlarını gizle/göster yapıyoruz.
            if (oyunTuru == "Sayi")
            {
                grpSayilar.Visible = true;   // Sayı tuşlarını aç
                grpRenkler.Visible = false;  // Renk tuşlarını kapat
            }
            else if (oyunTuru == "Renk")
            {
                grpSayilar.Visible = false;
                grpRenkler.Visible = true;
            }

            // En yüksek skorları veritabanından çekip göster.
            SkorlariListele();
        }

        // --- RASTGELE ÜRETİM ALGORİTMASI ---
        private void OyunuBaslat()
        {
            Random rastgele = new Random();

            // Yeni oyun için hafızayı temizle
            gizliSayilar.Clear();
            gizliRenkler.Clear();

            // SENARYO 1: SAYI MODU
            if (oyunTuru == "Sayi")
            {
                // Hedef basamak sayısına ulaşana kadar döngü kur.
                while (gizliSayilar.Count < basamakSayisi)
                {
                    int sayi = rastgele.Next(0, 10); // 0-9 arası sayı tut

                    // ALGORİTMA MANTIĞI: Benzersizlik Kontrolü
                    // Eğer tutulan sayı listede zaten varsa (.Contains) ekleme yapma.
                    // Bu sayede rakamları birbirinden farklı (Örn: 1234) sayılar üretilir.
                    if (gizliSayilar.Contains(sayi) == false)
                    {
                        gizliSayilar.Add(sayi);
                    }
                }
            }
            // SENARYO 2: RENK MODU (Mastermind)
            else if (oyunTuru == "Renk")
            {
                while (gizliRenkler.Count < 4) // Renk modu standart 4 hanelidir.
                {
                    int rastgeleSira = rastgele.Next(0, renkHavuzu.Length);
                    string secilenRenk = renkHavuzu[rastgeleSira];

                    // Aynı renk tekrar seçilmesin (Benzersizlik kuralı)
                    if (gizliRenkler.Contains(secilenRenk) == false)
                    {
                        gizliRenkler.Add(secilenRenk);
                    }
                }
            }
        }

        // --- TUŞLAMA FONKSİYONU ---
        // Her butona tek tek kod yazmak yerine, basılan değeri buraya gönderiyoruz.
        private void TusaBas(string deger)
        {
            // Kontrol: Basamak sınırını aştı mı?
            if (lblGirilenSayi.Text.Length < basamakSayisi)
            {
                lblGirilenSayi.Text += deger;
            }
        }

        // --- SAYI BUTONLARI ---
        private void btn0_Click(object sender, EventArgs e) { TusaBas("0"); }
        private void btn1_Click(object sender, EventArgs e) { TusaBas("1"); }
        private void btn2_Click(object sender, EventArgs e) { TusaBas("2"); }
        private void btn3_Click(object sender, EventArgs e) { TusaBas("3"); }
        private void btn4_Click(object sender, EventArgs e) { TusaBas("4"); }
        private void btn5_Click(object sender, EventArgs e) { TusaBas("5"); }
        private void btn6_Click(object sender, EventArgs e) { TusaBas("6"); }
        private void btn7_Click(object sender, EventArgs e) { TusaBas("7"); }
        private void btn8_Click(object sender, EventArgs e) { TusaBas("8"); }
        private void btn9_Click(object sender, EventArgs e) { TusaBas("9"); }

        // --- RENK BUTONLARI ---
        private void btnKırmızı_Click(object sender, EventArgs e) { TusaBas("K"); }
        private void btnSari_Click(object sender, EventArgs e) { TusaBas("S"); }
        private void btnMor_Click(object sender, EventArgs e) { TusaBas("P"); }
        private void btnMavi_Click(object sender, EventArgs e) { TusaBas("M"); }
        private void btnYesil_Click(object sender, EventArgs e) { TusaBas("Y"); }

        // --- SİLME BUTONU ---
        private void btnSil_Click(object sender, EventArgs e)
        {
            // String manipülasyonu: Son karakteri kesip atıyoruz.
            if (lblGirilenSayi.Text.Length > 0)
            {
                lblGirilenSayi.Text = lblGirilenSayi.Text.Substring(0, lblGirilenSayi.Text.Length - 1);
            }
        }

        // --- TAHMİN ET (ENTER) ALGORİTMASI ---
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // 1. Doğrulama (Validation)
            if (lblGirilenSayi.Text.Length != basamakSayisi)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Giriş");
                return;
            }

            int arti = 0; // Yeri ve değeri doğru olanlar
            int eksi = 0; // Değeri doğru ama yeri yanlış olanlar
            string tahmin = lblGirilenSayi.Text;

            // ---------------------------------------------------------
            // MOD 1: SAYI KONTROLÜ
            // ---------------------------------------------------------
            if (oyunTuru == "Sayi")
            {
                for (int i = 0; i < basamakSayisi; i++)
                {
                    // String'i int'e çevirip kontrol ediyoruz.
                    int oAnkiRakam = int.Parse(tahmin[i].ToString());

                    if (oAnkiRakam == gizliSayilar[i])
                    {
                        arti++; // Tam isabet
                    }
                    else if (gizliSayilar.Contains(oAnkiRakam))
                    {
                        eksi++; // Sayı var ama yeri yanlış
                    }
                }
            }
            // ---------------------------------------------------------
            // MOD 2: RENK KONTROLÜ
            // ---------------------------------------------------------
            else if (oyunTuru == "Renk")
            {
                for (int i = 0; i < basamakSayisi; i++)
                {
                    string oAnkiRenk = tahmin[i].ToString();

                    if (oAnkiRenk == gizliRenkler[i])
                    {
                        arti++;
                    }
                    else if (gizliRenkler.Contains(oAnkiRenk))
                    {
                        eksi++;
                    }
                }
            }

            // --- SONUÇLARI LİSTEYE EKLEME ---
            lstTahminler.Items.Add(tahmin + "   >>>   +" + arti + "   -" + eksi);
            lblGirilenSayi.Text = ""; // Giriş kutusunu temizle

            // --- KAZANMA KONTROLÜ ---
            if (arti == basamakSayisi)
            {
                timer1.Stop(); // Süreyi durdur

                // Puan Formülü: Zorluk * 100 - (Geçen Süre * 3)
                int finalPuan = (basamakSayisi * 100) - (sayac * 3);
                if (finalPuan < 0) finalPuan = 0;

                MessageBox.Show("TEBRİKLER! KAZANDINIZ.\nPuan: " + finalPuan);

                // Skoru veritabanına işle
                SkorKaydet(finalPuan);
            }
        }

        // --- ZAMANLAYICI (TIMER) ---
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++; // Her saniye artır
            lblSure.Text = "Süre: " + sayac.ToString();

            // Anlık Puanı Ekrana Yansıtma (Görsellik)
            int anlikPuan = (basamakSayisi * 100) - (sayac * 3);
            if (anlikPuan < 0) anlikPuan = 0;
            lblPuan.Text = "Puan: " + anlikPuan.ToString();
        }

        // --- VERİTABANI: SKOR KAYDETME ---
        private void SkorKaydet(int kazanilanPuan)
        {
            // Kullanıcı hatalarını göz ardı etmek için try-catch kullanmadık.
            // Amaç: Kodun daha sade ve anlaşılır olması.

            SQLBaglantisi bgl = new SQLBaglantisi();
            SqlConnection conn = bgl.Baglanti();

            // SQL İPUCU (Subquery):
            // Elimizde Kullanıcı Adı var ama tabloda Kullanıcı ID lazım.
            // İç içe sorgu (SELECT KullaniciID FROM...) kullanarak ID'yi veritabanından bulup ekliyoruz.
            string sorgu = "INSERT INTO tblSkorlar (KullaniciID, Puan, Sure, OyunTuru, Tarih) " +
                           "VALUES ((SELECT KullaniciID FROM tblKullanicilar WHERE KullaniciAdi=@p1), @p2, @p3, @p4, @p5)";

            SqlCommand komut = new SqlCommand(sorgu, conn);

            komut.Parameters.AddWithValue("@p1", Form1.kadi); // Global değişkenden adı al
            komut.Parameters.AddWithValue("@p2", kazanilanPuan);
            komut.Parameters.AddWithValue("@p3", sayac);
            komut.Parameters.AddWithValue("@p4", oyunTuru);
            komut.Parameters.AddWithValue("@p5", DateTime.Now);

            komut.ExecuteNonQuery(); // Kaydı yap
            conn.Close();            // Bağlantıyı kapat

            // Listeyi güncelle ki yeni skoru görelim
            SkorlariListele();
        }

        // --- VERİTABANI: SKORLARI LİSTELEME ---
        private void SkorlariListele()
        {
            SQLBaglantisi bgl = new SQLBaglantisi();

            // SQL İPUCU (INNER JOIN):
            // Skorlar tablosunda sadece ID var, isim yok.
            // Kullanıcılar tablosuyla Skorlar tablosunu ID üzerinden BİRLEŞTİRİP (Join)
            // İsimleri oradan çekiyoruz.
            string sorgu = "SELECT TOP 5 K.KullaniciAdi, S.Puan, S.Sure, S.Tarih " +
                           "FROM tblSkorlar S " +
                           "INNER JOIN tblKullanicilar K ON S.KullaniciID = K.KullaniciID " +
                           "ORDER BY S.Puan DESC";

            // BAĞLANTISIZ KATMAN (Disconnected Architecture):
            // Veriyi çekip hafızadaki tabloya (DataTable) dolduruyoruz.
            // SqlDataReader yerine SqlDataAdapter kullanıyoruz.
            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.Baglanti());

            DataTable dt = new DataTable();
            da.Fill(dt); // Veriyi doldur

            dgvSkorlar.DataSource = dt; // Grid'e bağla
        }
    }
}