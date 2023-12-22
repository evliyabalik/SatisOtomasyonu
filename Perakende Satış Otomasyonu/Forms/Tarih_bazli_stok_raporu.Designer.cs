
namespace Perakende_Satış_Otomasyonu.Forms
{
    partial class Tarih_bazli_stok_raporu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblHareketSayisi = new System.Windows.Forms.Label();
            this.lstHareketRaporu = new System.Windows.Forms.ListView();
            this.UrunKodu = new System.Windows.Forms.ColumnHeader();
            this.UrunAdi = new System.Windows.Forms.ColumnHeader();
            this.Birimi = new System.Windows.Forms.ColumnHeader();
            this.Miktari = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblHareketSayisi);
            this.panel1.Location = new System.Drawing.Point(24, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 30);
            this.panel1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(637, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hareket Sayısı: 0";
            // 
            // lblHareketSayisi
            // 
            this.lblHareketSayisi.AutoSize = true;
            this.lblHareketSayisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHareketSayisi.Location = new System.Drawing.Point(737, 7);
            this.lblHareketSayisi.Name = "lblHareketSayisi";
            this.lblHareketSayisi.Size = new System.Drawing.Size(14, 15);
            this.lblHareketSayisi.TabIndex = 11;
            this.lblHareketSayisi.Text = "0";
            // 
            // lstHareketRaporu
            // 
            this.lstHareketRaporu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstHareketRaporu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunKodu,
            this.UrunAdi,
            this.Birimi,
            this.Miktari,
            this.columnHeader1,
            this.columnHeader2});
            this.lstHareketRaporu.FullRowSelect = true;
            this.lstHareketRaporu.GridLines = true;
            this.lstHareketRaporu.HideSelection = false;
            this.lstHareketRaporu.Location = new System.Drawing.Point(24, 99);
            this.lstHareketRaporu.Name = "lstHareketRaporu";
            this.lstHareketRaporu.Size = new System.Drawing.Size(751, 403);
            this.lstHareketRaporu.TabIndex = 14;
            this.lstHareketRaporu.UseCompatibleStateImageBehavior = false;
            this.lstHareketRaporu.View = System.Windows.Forms.View.Details;
            // 
            // UrunKodu
            // 
            this.UrunKodu.Text = "Ürün Kodu";
            this.UrunKodu.Width = 150;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 250;
            // 
            // Birimi
            // 
            this.Birimi.Text = "Devir";
            // 
            // Miktari
            // 
            this.Miktari.Text = "Giriş Toplam";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKapat);
            this.groupBox1.Controls.Add(this.btnYazdir);
            this.groupBox1.Controls.Add(this.btnRapor);
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 81);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(650, 37);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(86, 23);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(558, 39);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(86, 23);
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(418, 39);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(86, 23);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "Rapor Ver";
            this.btnRapor.UseVisualStyleBackColor = true;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(212, 37);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 23);
            this.dtpBitis.TabIndex = 4;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(6, 37);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtpBaslangic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(212, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Çıkış Toplam";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bakiye";
            // 
            // Tarih_bazli_stok_raporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(798, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstHareketRaporu);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Tarih_bazli_stok_raporu";
            this.Text = "Tarih Bazlı Ürün Raporu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblHareketSayisi;
        private System.Windows.Forms.ListView lstHareketRaporu;
        private System.Windows.Forms.ColumnHeader UrunKodu;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader Birimi;
        private System.Windows.Forms.ColumnHeader Miktari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}