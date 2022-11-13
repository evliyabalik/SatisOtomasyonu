
namespace Perakende_Satış_Otomasyonu.Forms
{
    partial class PerakendeSatis
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSatisTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSatisBicimi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbIskontoOran = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIskontoYuzde = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnUrunSec = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstSearchProduct = new System.Windows.Forms.ListView();
            this.Barkod = new System.Windows.Forms.ColumnHeader();
            this.UrunAdi = new System.Windows.Forms.ColumnHeader();
            this.Birim = new System.Windows.Forms.ColumnHeader();
            this.BirimFiyat = new System.Windows.Forms.ColumnHeader();
            this.Fiyat = new System.Windows.Forms.ColumnHeader();
            this.Miktar = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tarih = new System.Windows.Forms.ColumnHeader();
            this.Barkodu = new System.Windows.Forms.ColumnHeader();
            this.UrunAdii = new System.Windows.Forms.ColumnHeader();
            this.UrunBirim = new System.Windows.Forms.ColumnHeader();
            this.Miktari = new System.Windows.Forms.ColumnHeader();
            this.Fiyati = new System.Windows.Forms.ColumnHeader();
            this.Iskonto = new System.Windows.Forms.ColumnHeader();
            this.BirimFiyati = new System.Windows.Forms.ColumnHeader();
            this.Tutari = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUrunSayisi = new System.Windows.Forms.Label();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnKapat);
            this.groupBox1.Controls.Add(this.btnSatisIptal);
            this.groupBox1.Controls.Add(this.btnSatisYap);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbSatisBicimi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpSatisTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblPersonel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Menüsü";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPersonel.Location = new System.Drawing.Point(6, 42);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(64, 19);
            this.lblPersonel.TabIndex = 1;
            this.lblPersonel.Text = "Deneme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(92, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satış Tarihi";
            // 
            // dtpSatisTarih
            // 
            this.dtpSatisTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpSatisTarih.Location = new System.Drawing.Point(92, 40);
            this.dtpSatisTarih.Name = "dtpSatisTarih";
            this.dtpSatisTarih.Size = new System.Drawing.Size(157, 23);
            this.dtpSatisTarih.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(291, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Satış Biçimi";
            // 
            // cmbSatisBicimi
            // 
            this.cmbSatisBicimi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSatisBicimi.FormattingEnabled = true;
            this.cmbSatisBicimi.Location = new System.Drawing.Point(266, 38);
            this.cmbSatisBicimi.Name = "cmbSatisBicimi";
            this.cmbSatisBicimi.Size = new System.Drawing.Size(121, 23);
            this.cmbSatisBicimi.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIskontoYuzde);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbIskontoOran);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(404, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 52);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "iskonto";
            // 
            // cmbIskontoOran
            // 
            this.cmbIskontoOran.FormattingEnabled = true;
            this.cmbIskontoOran.Items.AddRange(new object[] {
            "1,2,3,4,5,6,7,8,9,10"});
            this.cmbIskontoOran.Location = new System.Drawing.Point(6, 19);
            this.cmbIskontoOran.Name = "cmbIskontoOran";
            this.cmbIskontoOran.Size = new System.Drawing.Size(44, 23);
            this.cmbIskontoOran.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "%";
            // 
            // txtIskontoYuzde
            // 
            this.txtIskontoYuzde.Location = new System.Drawing.Point(76, 19);
            this.txtIskontoYuzde.Name = "txtIskontoYuzde";
            this.txtIskontoYuzde.Size = new System.Drawing.Size(74, 23);
            this.txtIskontoYuzde.TabIndex = 8;
            this.txtIskontoYuzde.Text = "0";
            this.txtIskontoYuzde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatisYap.Location = new System.Drawing.Point(566, 29);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(82, 37);
            this.btnSatisYap.TabIndex = 1;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatisIptal.Location = new System.Drawing.Point(654, 29);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(82, 37);
            this.btnSatisIptal.TabIndex = 7;
            this.btnSatisIptal.Text = "Satışı İptal Et";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKapat.Location = new System.Drawing.Point(742, 29);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(82, 37);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstSearchProduct);
            this.groupBox3.Controls.Add(this.btnSil);
            this.groupBox3.Controls.Add(this.btnEkle);
            this.groupBox3.Controls.Add(this.btnUrunSec);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 94);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Menüsü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAciklama.Location = new System.Drawing.Point(92, 68);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(295, 23);
            this.txtAciklama.TabIndex = 1;
            // 
            // btnUrunSec
            // 
            this.btnUrunSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunSec.Location = new System.Drawing.Point(6, 24);
            this.btnUrunSec.Name = "btnUrunSec";
            this.btnUrunSec.Size = new System.Drawing.Size(80, 38);
            this.btnUrunSec.TabIndex = 0;
            this.btnUrunSec.Text = "Ürün Seç";
            this.btnUrunSec.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.Location = new System.Drawing.Point(742, 19);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(82, 34);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(742, 59);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 29);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // lstSearchProduct
            // 
            this.lstSearchProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Barkod,
            this.UrunAdi,
            this.Birim,
            this.BirimFiyat,
            this.Fiyat,
            this.Miktar});
            this.lstSearchProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstSearchProduct.GridLines = true;
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.lstSearchProduct.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.lstSearchProduct.HideSelection = false;
            this.lstSearchProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstSearchProduct.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.lstSearchProduct.LabelEdit = true;
            this.lstSearchProduct.Location = new System.Drawing.Point(88, 19);
            this.lstSearchProduct.Name = "lstSearchProduct";
            this.lstSearchProduct.Size = new System.Drawing.Size(648, 69);
            this.lstSearchProduct.TabIndex = 10;
            this.lstSearchProduct.UseCompatibleStateImageBehavior = false;
            this.lstSearchProduct.View = System.Windows.Forms.View.Details;
            this.lstSearchProduct.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Barkod
            // 
            this.Barkod.Text = "Barkod";
            this.Barkod.Width = 100;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 150;
            // 
            // Birim
            // 
            this.Birim.Text = "Birim";
            this.Birim.Width = 100;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.Text = "Birim Fiyat";
            this.BirimFiyat.Width = 100;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 100;
            // 
            // Miktar
            // 
            this.Miktar.Text = "Miktar";
            this.Miktar.Width = 75;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(845, 287);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tarih,
            this.Barkodu,
            this.UrunAdii,
            this.UrunBirim,
            this.Miktari,
            this.Fiyati,
            this.Iskonto,
            this.BirimFiyati,
            this.Tutari});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(832, 257);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 100;
            // 
            // Barkodu
            // 
            this.Barkodu.Text = "Barkod";
            this.Barkodu.Width = 100;
            // 
            // UrunAdii
            // 
            this.UrunAdii.Text = "Ürün Adı";
            this.UrunAdii.Width = 150;
            // 
            // UrunBirim
            // 
            this.UrunBirim.Text = "Birimi";
            this.UrunBirim.Width = 100;
            // 
            // Miktari
            // 
            this.Miktari.Text = "Miktarı";
            this.Miktari.Width = 80;
            // 
            // Fiyati
            // 
            this.Fiyati.Text = "Fiyatı";
            this.Fiyati.Width = 80;
            // 
            // Iskonto
            // 
            this.Iskonto.Text = "İskonto";
            this.Iskonto.Width = 80;
            // 
            // BirimFiyati
            // 
            this.BirimFiyati.Text = "Birim Fiyatı";
            this.BirimFiyati.Width = 78;
            // 
            // Tutari
            // 
            this.Tutari.Text = "Tutarı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblToplamTutar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblToplamSatis);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblUrunSayisi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 48);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ürün Sayısı:";
            // 
            // lblUrunSayisi
            // 
            this.lblUrunSayisi.AutoSize = true;
            this.lblUrunSayisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunSayisi.ForeColor = System.Drawing.Color.Lime;
            this.lblUrunSayisi.Location = new System.Drawing.Point(92, 16);
            this.lblUrunSayisi.Name = "lblUrunSayisi";
            this.lblUrunSayisi.Size = new System.Drawing.Size(17, 19);
            this.lblUrunSayisi.TabIndex = 10;
            this.lblUrunSayisi.Text = "0";
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamSatis.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamSatis.Location = new System.Drawing.Point(232, 16);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(17, 19);
            this.lblToplamSatis.TabIndex = 12;
            this.lblToplamSatis.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(130, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Toplam Satış:";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplamTutar.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamTutar.Location = new System.Drawing.Point(761, 10);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(23, 25);
            this.lblToplamTutar.TabIndex = 14;
            this.lblToplamTutar.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(644, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "Toplam Tutar:";
            // 
            // PerakendeSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(869, 566);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PerakendeSatis";
            this.Text = "Perakende Satış";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpSatisTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIskontoYuzde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIskontoOran;
        private System.Windows.Forms.ComboBox cmbSatisBicimi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnUrunSec;
        private System.Windows.Forms.ListView lstSearchProduct;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader Birim;
        private System.Windows.Forms.ColumnHeader BirimFiyat;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ColumnHeader Miktar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Barkodu;
        private System.Windows.Forms.ColumnHeader UrunAdii;
        private System.Windows.Forms.ColumnHeader UrunBirim;
        private System.Windows.Forms.ColumnHeader Miktari;
        private System.Windows.Forms.ColumnHeader Fiyati;
        private System.Windows.Forms.ColumnHeader Iskonto;
        private System.Windows.Forms.ColumnHeader BirimFiyati;
        private System.Windows.Forms.ColumnHeader Tutari;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblToplamSatis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblUrunSayisi;
        private System.Windows.Forms.Label label6;
    }
}