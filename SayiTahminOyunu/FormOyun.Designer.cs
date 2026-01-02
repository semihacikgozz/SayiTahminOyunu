namespace SayiTahminOyunu
{
    partial class FormOyun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstTahminler = new System.Windows.Forms.ListBox();
            this.lblGirilenSayi = new System.Windows.Forms.Label();
            this.grpSayilar = new System.Windows.Forms.GroupBox();
            this.btnSari = new System.Windows.Forms.Button();
            this.btnMor = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.btnKırmızı = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.dgvSkorlar = new System.Windows.Forms.DataGridView();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpRenkler = new System.Windows.Forms.GroupBox();
            this.grpSayilar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkorlar)).BeginInit();
            this.grpRenkler.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTahminler
            // 
            this.lstTahminler.FormattingEnabled = true;
            this.lstTahminler.ItemHeight = 16;
            this.lstTahminler.Location = new System.Drawing.Point(43, 45);
            this.lstTahminler.Name = "lstTahminler";
            this.lstTahminler.Size = new System.Drawing.Size(135, 180);
            this.lstTahminler.TabIndex = 0;
            // 
            // lblGirilenSayi
            // 
            this.lblGirilenSayi.AutoSize = true;
            this.lblGirilenSayi.Location = new System.Drawing.Point(40, 307);
            this.lblGirilenSayi.Name = "lblGirilenSayi";
            this.lblGirilenSayi.Size = new System.Drawing.Size(135, 16);
            this.lblGirilenSayi.TabIndex = 1;
            this.lblGirilenSayi.Text = "--------------------------------";
            // 
            // grpSayilar
            // 
            this.grpSayilar.Controls.Add(this.btn9);
            this.grpSayilar.Controls.Add(this.btn8);
            this.grpSayilar.Controls.Add(this.btn7);
            this.grpSayilar.Controls.Add(this.btn6);
            this.grpSayilar.Controls.Add(this.btn5);
            this.grpSayilar.Controls.Add(this.btn4);
            this.grpSayilar.Controls.Add(this.btn3);
            this.grpSayilar.Controls.Add(this.btn2);
            this.grpSayilar.Controls.Add(this.btn1);
            this.grpSayilar.Controls.Add(this.btn0);
            this.grpSayilar.Location = new System.Drawing.Point(276, 45);
            this.grpSayilar.Name = "grpSayilar";
            this.grpSayilar.Size = new System.Drawing.Size(262, 278);
            this.grpSayilar.TabIndex = 2;
            this.grpSayilar.TabStop = false;
            this.grpSayilar.Text = "groupBox1";
            // 
            // btnSari
            // 
            this.btnSari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSari.Location = new System.Drawing.Point(0, 12);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(64, 47);
            this.btnSari.TabIndex = 14;
            this.btnSari.UseVisualStyleBackColor = false;
            this.btnSari.Click += new System.EventHandler(this.btnSari_Click);
            // 
            // btnMor
            // 
            this.btnMor.BackColor = System.Drawing.Color.Purple;
            this.btnMor.Location = new System.Drawing.Point(140, 12);
            this.btnMor.Name = "btnMor";
            this.btnMor.Size = new System.Drawing.Size(64, 47);
            this.btnMor.TabIndex = 13;
            this.btnMor.UseVisualStyleBackColor = false;
            this.btnMor.Click += new System.EventHandler(this.btnMor_Click);
            // 
            // btnYesil
            // 
            this.btnYesil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnYesil.Location = new System.Drawing.Point(275, 12);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(64, 47);
            this.btnYesil.TabIndex = 12;
            this.btnYesil.UseVisualStyleBackColor = false;
            this.btnYesil.Click += new System.EventHandler(this.btnYesil_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.Color.Blue;
            this.btnMavi.Location = new System.Drawing.Point(210, 12);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(64, 47);
            this.btnMavi.TabIndex = 0;
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // btnKırmızı
            // 
            this.btnKırmızı.BackColor = System.Drawing.Color.Red;
            this.btnKırmızı.Location = new System.Drawing.Point(70, 12);
            this.btnKırmızı.Name = "btnKırmızı";
            this.btnKırmızı.Size = new System.Drawing.Size(64, 47);
            this.btnKırmızı.TabIndex = 0;
            this.btnKırmızı.UseVisualStyleBackColor = false;
            this.btnKırmızı.Click += new System.EventHandler(this.btnKırmızı_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(435, 329);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(103, 47);
            this.btnEnter.TabIndex = 11;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(276, 329);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 47);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "C";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(168, 156);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 47);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(87, 156);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 47);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(6, 156);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 47);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(168, 84);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 47);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(87, 84);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 47);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(6, 84);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 47);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(168, 21);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 47);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(87, 21);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 47);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(6, 21);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 47);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(87, 218);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 47);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // dgvSkorlar
            // 
            this.dgvSkorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkorlar.Location = new System.Drawing.Point(571, 45);
            this.dgvSkorlar.Name = "dgvSkorlar";
            this.dgvSkorlar.RowHeadersWidth = 51;
            this.dgvSkorlar.RowTemplate.Height = 24;
            this.dgvSkorlar.Size = new System.Drawing.Size(276, 171);
            this.dgvSkorlar.TabIndex = 3;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(639, 278);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(79, 16);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(639, 326);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(38, 16);
            this.lblPuan.TabIndex = 5;
            this.lblPuan.Text = "Puan";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(639, 373);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(35, 16);
            this.lblSure.TabIndex = 6;
            this.lblSure.Text = "Süre";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grpRenkler
            // 
            this.grpRenkler.Controls.Add(this.btnSari);
            this.grpRenkler.Controls.Add(this.btnKırmızı);
            this.grpRenkler.Controls.Add(this.btnMor);
            this.grpRenkler.Controls.Add(this.btnYesil);
            this.grpRenkler.Controls.Add(this.btnMavi);
            this.grpRenkler.Location = new System.Drawing.Point(238, 382);
            this.grpRenkler.Name = "grpRenkler";
            this.grpRenkler.Size = new System.Drawing.Size(345, 100);
            this.grpRenkler.TabIndex = 15;
            this.grpRenkler.TabStop = false;
            this.grpRenkler.Text = "groupBox1";
            // 
            // FormOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1047, 609);
            this.Controls.Add(this.grpRenkler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.dgvSkorlar);
            this.Controls.Add(this.grpSayilar);
            this.Controls.Add(this.lblGirilenSayi);
            this.Controls.Add(this.lstTahminler);
            this.Name = "FormOyun";
            this.Text = "FormOyun";
            this.Load += new System.EventHandler(this.FormOyun_Load);
            this.grpSayilar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkorlar)).EndInit();
            this.grpRenkler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTahminler;
        private System.Windows.Forms.Label lblGirilenSayi;
        private System.Windows.Forms.GroupBox grpSayilar;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMor;
        private System.Windows.Forms.Button btnYesil;
        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnKırmızı;
        private System.Windows.Forms.Button btnSari;
        private System.Windows.Forms.DataGridView dgvSkorlar;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpRenkler;
    }
}