
namespace Perakende_Satış_Otomasyonu.Forms
{
    partial class SatisRaporu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSatisBicimi = new System.Windows.Forms.ComboBox();
            this.txtPersonel = new System.Windows.Forms.TextBox();
            this.btnPersonelSec = new System.Windows.Forms.Button();
            this.btnGenelRapor = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSatisRaporu = new System.Windows.Forms.ListView();
            this.Tarih = new System.Windows.Forms.ColumnHeader();
            this.Personel = new System.Windows.Forms.ColumnHeader();
            this.Barkod = new System.Windows.Forms.ColumnHeader();
            this.UrunAdi = new System.Windows.Forms.ColumnHeader();
            this.UrunBirim = new System.Windows.Forms.ColumnHeader();
            this.UrunMiktar = new System.Windows.Forms.ColumnHeader();
            this.UrunFiyat = new System.Windows.Forms.ColumnHeader();
            this.Risk = new System.Windows.Forms.ColumnHeader();
            this.Fiyat2 = new System.Windows.Forms.ColumnHeader();
            this.Tutar = new System.Windows.Forms.ColumnHeader();
            this.Satis = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblToplamGelentutar = new System.Windows.Forms.Label();
            this.lblAcikHesap = new System.Windows.Forms.Label();
            this.lblKrediTutari = new System.Windows.Forms.Label();
            this.lblPesinTutar = new System.Windows.Forms.Label();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonelSec);
            this.groupBox1.Controls.Add(this.txtPersonel);
            this.groupBox1.Controls.Add(this.cmbSatisBicimi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(212, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(6, 28);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtpBaslangic.TabIndex = 2;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(212, 28);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 23);
            this.dtpBitis.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satış Biçimi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(151, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personel";
            // 
            // cmbSatisBicimi
            // 
            this.cmbSatisBicimi.FormattingEnabled = true;
            this.cmbSatisBicimi.Location = new System.Drawing.Point(6, 74);
            this.cmbSatisBicimi.Name = "cmbSatisBicimi";
            this.cmbSatisBicimi.Size = new System.Drawing.Size(121, 23);
            this.cmbSatisBicimi.TabIndex = 6;
            // 
            // txtPersonel
            // 
            this.txtPersonel.Location = new System.Drawing.Point(151, 74);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(142, 23);
            this.txtPersonel.TabIndex = 7;
            // 
            // btnPersonelSec
            // 
            this.btnPersonelSec.Location = new System.Drawing.Point(309, 63);
            this.btnPersonelSec.Name = "btnPersonelSec";
            this.btnPersonelSec.Size = new System.Drawing.Size(84, 34);
            this.btnPersonelSec.TabIndex = 8;
            this.btnPersonelSec.Text = "Personel Seç";
            this.btnPersonelSec.UseVisualStyleBackColor = true;
            // 
            // btnGenelRapor
            // 
            this.btnGenelRapor.Location = new System.Drawing.Point(60, 54);
            this.btnGenelRapor.Name = "btnGenelRapor";
            this.btnGenelRapor.Size = new System.Drawing.Size(84, 36);
            this.btnGenelRapor.TabIndex = 9;
            this.btnGenelRapor.Text = "Genel Rapor";
            this.btnGenelRapor.UseVisualStyleBackColor = true;
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(60, 16);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(84, 36);
            this.btnRapor.TabIndex = 10;
            this.btnRapor.Text = "Rapor Ver";
            this.btnRapor.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(209, 16);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(84, 36);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(209, 54);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(84, 36);
            this.btnKapat.TabIndex = 12;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenelRapor);
            this.groupBox2.Controls.Add(this.btnKapat);
            this.groupBox2.Controls.Add(this.btnYazdir);
            this.groupBox2.Controls.Add(this.btnRapor);
            this.groupBox2.Location = new System.Drawing.Point(503, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 103);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstSatisRaporu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(839, 345);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(397, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Satış Raporu";
            // 
            // lstSatisRaporu
            // 
            this.lstSatisRaporu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstSatisRaporu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tarih,
            this.Personel,
            this.Barkod,
            this.UrunAdi,
            this.UrunBirim,
            this.UrunMiktar,
            this.UrunFiyat,
            this.Risk,
            this.Fiyat2,
            this.Tutar,
            this.Satis});
            this.lstSatisRaporu.FullRowSelect = true;
            this.lstSatisRaporu.GridLines = true;
            this.lstSatisRaporu.HideSelection = false;
            this.lstSatisRaporu.Location = new System.Drawing.Point(3, 19);
            this.lstSatisRaporu.Name = "lstSatisRaporu";
            this.lstSatisRaporu.Size = new System.Drawing.Size(830, 320);
            this.lstSatisRaporu.TabIndex = 10;
            this.lstSatisRaporu.UseCompatibleStateImageBehavior = false;
            this.lstSatisRaporu.View = System.Windows.Forms.View.Details;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 100;
            // 
            // Personel
            // 
            this.Personel.Text = "Personel";
            this.Personel.Width = 100;
            // 
            // Barkod
            // 
            this.Barkod.Text = "Barkod";
            this.Barkod.Width = 100;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 100;
            // 
            // UrunBirim
            // 
            this.UrunBirim.Text = "Birimi";
            // 
            // UrunMiktar
            // 
            this.UrunMiktar.Text = "Miktarı";
            // 
            // UrunFiyat
            // 
            this.UrunFiyat.Text = "Fiyatı";
            // 
            // Risk
            // 
            this.Risk.Text = "İsk.";
            // 
            // Fiyat2
            // 
            this.Fiyat2.Text = "Fiyatı";
            // 
            // Tutar
            // 
            this.Tutar.Text = "Tutarı";
            // 
            // Satis
            // 
            this.Satis.Text = "Satış";
            this.Satis.Width = 66;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblToplamGelentutar);
            this.panel1.Controls.Add(this.lblAcikHesap);
            this.panel1.Controls.Add(this.lblKrediTutari);
            this.panel1.Controls.Add(this.lblPesinTutar);
            this.panel1.Controls.Add(this.lblToplamSatis);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSatisIptal);
            this.panel1.Location = new System.Drawing.Point(12, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 66);
            this.panel1.TabIndex = 11;
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSatisIptal.Location = new System.Drawing.Point(749, 17);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(84, 36);
            this.btnSatisIptal.TabIndex = 13;
            this.btnSatisIptal.Text = "Satış İptal";
            this.btnSatisIptal.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Toplam Satış";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(112, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Peşin Tutar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(204, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kredi Tutarı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(309, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Açık Hesap Tutar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(430, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Gelen Toplam Tutar ";
            // 
            // lblToplamGelentutar
            // 
            this.lblToplamGelentutar.AutoSize = true;
            this.lblToplamGelentutar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamGelentutar.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamGelentutar.Location = new System.Drawing.Point(482, 38);
            this.lblToplamGelentutar.Name = "lblToplamGelentutar";
            this.lblToplamGelentutar.Size = new System.Drawing.Size(14, 15);
            this.lblToplamGelentutar.TabIndex = 22;
            this.lblToplamGelentutar.Text = "0";
            // 
            // lblAcikHesap
            // 
            this.lblAcikHesap.AutoSize = true;
            this.lblAcikHesap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAcikHesap.ForeColor = System.Drawing.Color.Lime;
            this.lblAcikHesap.Location = new System.Drawing.Point(350, 38);
            this.lblAcikHesap.Name = "lblAcikHesap";
            this.lblAcikHesap.Size = new System.Drawing.Size(14, 15);
            this.lblAcikHesap.TabIndex = 21;
            this.lblAcikHesap.Text = "0";
            // 
            // lblKrediTutari
            // 
            this.lblKrediTutari.AutoSize = true;
            this.lblKrediTutari.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKrediTutari.ForeColor = System.Drawing.Color.Lime;
            this.lblKrediTutari.Location = new System.Drawing.Point(233, 38);
            this.lblKrediTutari.Name = "lblKrediTutari";
            this.lblKrediTutari.Size = new System.Drawing.Size(14, 15);
            this.lblKrediTutari.TabIndex = 20;
            this.lblKrediTutari.Text = "0";
            // 
            // lblPesinTutar
            // 
            this.lblPesinTutar.AutoSize = true;
            this.lblPesinTutar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesinTutar.ForeColor = System.Drawing.Color.Lime;
            this.lblPesinTutar.Location = new System.Drawing.Point(141, 38);
            this.lblPesinTutar.Name = "lblPesinTutar";
            this.lblPesinTutar.Size = new System.Drawing.Size(14, 15);
            this.lblPesinTutar.TabIndex = 19;
            this.lblPesinTutar.Text = "0";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamSatis.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamSatis.Location = new System.Drawing.Point(35, 38);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(14, 15);
            this.lblToplamSatis.TabIndex = 18;
            this.lblToplamSatis.Text = "0";
            // 
            // SatisRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(861, 558);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SatisRaporu";
            this.Text = "Satış Raporu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPersonelSec;
        private System.Windows.Forms.TextBox txtPersonel;
        private System.Windows.Forms.ComboBox cmbSatisBicimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenelRapor;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstSatisRaporu;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Personel;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunBirim;
        private System.Windows.Forms.ColumnHeader UrunMiktar;
        private System.Windows.Forms.ColumnHeader UrunFiyat;
        private System.Windows.Forms.ColumnHeader Risk;
        private System.Windows.Forms.ColumnHeader Fiyat2;
        private System.Windows.Forms.ColumnHeader Tutar;
        private System.Windows.Forms.ColumnHeader Satis;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Label lblToplamGelentutar;
        private System.Windows.Forms.Label lblAcikHesap;
        private System.Windows.Forms.Label lblKrediTutari;
        private System.Windows.Forms.Label lblPesinTutar;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}