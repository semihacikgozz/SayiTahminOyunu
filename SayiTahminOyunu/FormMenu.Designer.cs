namespace SayiTahminOyunu
{
    partial class FormMenu
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
            this.btn3Basamak = new System.Windows.Forms.Button();
            this.btn4Basamak = new System.Windows.Forms.Button();
            this.btn5Basamak = new System.Windows.Forms.Button();
            this.btnRenkModu = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn3Basamak
            // 
            this.btn3Basamak.Location = new System.Drawing.Point(192, 89);
            this.btn3Basamak.Name = "btn3Basamak";
            this.btn3Basamak.Size = new System.Drawing.Size(135, 97);
            this.btn3Basamak.TabIndex = 0;
            this.btn3Basamak.Text = "3 Basamaklı Oyun";
            this.btn3Basamak.UseVisualStyleBackColor = true;
            this.btn3Basamak.Click += new System.EventHandler(this.btn3Basamak_Click);
            // 
            // btn4Basamak
            // 
            this.btn4Basamak.Location = new System.Drawing.Point(378, 89);
            this.btn4Basamak.Name = "btn4Basamak";
            this.btn4Basamak.Size = new System.Drawing.Size(130, 97);
            this.btn4Basamak.TabIndex = 1;
            this.btn4Basamak.Text = "4 Basamaklı Oyun";
            this.btn4Basamak.UseVisualStyleBackColor = true;
            this.btn4Basamak.Click += new System.EventHandler(this.btn4Basamak_Click);
            // 
            // btn5Basamak
            // 
            this.btn5Basamak.Location = new System.Drawing.Point(192, 234);
            this.btn5Basamak.Name = "btn5Basamak";
            this.btn5Basamak.Size = new System.Drawing.Size(135, 99);
            this.btn5Basamak.TabIndex = 2;
            this.btn5Basamak.Text = "5 Basamaklı Oyun";
            this.btn5Basamak.UseVisualStyleBackColor = true;
            this.btn5Basamak.Click += new System.EventHandler(this.btn5Basamak_Click);
            // 
            // btnRenkModu
            // 
            this.btnRenkModu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRenkModu.Font = new System.Drawing.Font("Segoe Script", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenkModu.ForeColor = System.Drawing.Color.Gold;
            this.btnRenkModu.Location = new System.Drawing.Point(378, 234);
            this.btnRenkModu.Name = "btnRenkModu";
            this.btnRenkModu.Size = new System.Drawing.Size(130, 99);
            this.btnRenkModu.TabIndex = 3;
            this.btnRenkModu.Text = "Renk Modu";
            this.btnRenkModu.UseVisualStyleBackColor = false;
            this.btnRenkModu.Click += new System.EventHandler(this.btnRenkModu_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(592, 355);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(87, 38);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnRenkModu);
            this.Controls.Add(this.btn5Basamak);
            this.Controls.Add(this.btn4Basamak);
            this.Controls.Add(this.btn3Basamak);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn3Basamak;
        private System.Windows.Forms.Button btn4Basamak;
        private System.Windows.Forms.Button btn5Basamak;
        private System.Windows.Forms.Button btnRenkModu;
        private System.Windows.Forms.Button btnCikis;
    }
}