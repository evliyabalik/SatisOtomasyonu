
namespace Perakende_Satış_Otomasyonu.Forms
{
    partial class UrunHareketRaporu
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
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRapor = new System.Windows.Forms.Button();
            this.bntGenelRapor = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstHareketRaporu = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHareketIptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHareketSayisi = new System.Windows.Forms.Label();
            this.Tarih = new System.Windows.Forms.ColumnHeader();
            this.Hareket = new System.Windows.Forms.ColumnHeader();
            this.Aciklama = new System.Windows.Forms.ColumnHeader();
            this.Barkod = new System.Windows.Forms.ColumnHeader();
            this.UrunAdi = new System.Windows.Forms.ColumnHeader();
            this.Birimi = new System.Windows.Forms.ColumnHeader();
            this.Miktari = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKapat);
            this.groupBox1.Controls.Add(this.btnYazdir);
            this.groupBox1.Controls.Add(this.bntGenelRapor);
            this.groupBox1.Controls.Add(this.btnRapor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dtpBitis);
            this.groupBox1.Controls.Add(this.dtpBaslangic);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(418, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "İşlem Tipi";
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(6, 37);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtpBaslangic.TabIndex = 3;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(212, 37);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 23);
            this.dtpBitis.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(418, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(604, 22);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(86, 23);
            this.btnRapor.TabIndex = 6;
            this.btnRapor.Text = "Rapor Ver";
            this.btnRapor.UseVisualStyleBackColor = true;
            // 
            // bntGenelRapor
            // 
            this.bntGenelRapor.Location = new System.Drawing.Point(604, 51);
            this.bntGenelRapor.Name = "bntGenelRapor";
            this.bntGenelRapor.Size = new System.Drawing.Size(86, 23);
            this.bntGenelRapor.TabIndex = 7;
            this.bntGenelRapor.Text = "Genel Rapor";
            this.bntGenelRapor.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(729, 22);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(86, 23);
            this.btnYazdir.TabIndex = 8;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(729, 51);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(86, 23);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstHareketRaporu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(841, 427);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(382, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hareket Raporu";
            // 
            // lstHareketRaporu
            // 
            this.lstHareketRaporu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstHareketRaporu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tarih,
            this.Hareket,
            this.Aciklama,
            this.Barkod,
            this.UrunAdi,
            this.Birimi,
            this.Miktari});
            this.lstHareketRaporu.FullRowSelect = true;
            this.lstHareketRaporu.GridLines = true;
            this.lstHareketRaporu.HideSelection = false;
            this.lstHareketRaporu.Location = new System.Drawing.Point(6, 18);
            this.lstHareketRaporu.Name = "lstHareketRaporu";
            this.lstHareketRaporu.Size = new System.Drawing.Size(829, 403);
            this.lstHareketRaporu.TabIndex = 11;
            this.lstHareketRaporu.UseCompatibleStateImageBehavior = false;
            this.lstHareketRaporu.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblHareketSayisi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnHareketIptal);
            this.panel1.Location = new System.Drawing.Point(12, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 30);
            this.panel1.TabIndex = 12;
            // 
            // btnHareketIptal
            // 
            this.btnHareketIptal.Location = new System.Drawing.Point(6, 3);
            this.btnHareketIptal.Name = "btnHareketIptal";
            this.btnHareketIptal.Size = new System.Drawing.Size(86, 23);
            this.btnHareketIptal.TabIndex = 10;
            this.btnHareketIptal.Text = "Hareket İptali";
            this.btnHareketIptal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(642, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hareket Sayısı:";
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
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 150;
            // 
            // Hareket
            // 
            this.Hareket.Text = "Hareket";
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            this.Aciklama.Width = 250;
            // 
            // Barkod
            // 
            this.Barkod.Text = "Barkodu";
            this.Barkod.Width = 145;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 100;
            // 
            // Birimi
            // 
            this.Birimi.Text = "Birimi";
            // 
            // Miktari
            // 
            this.Miktari.Text = "Miktarı";
            // 
            // UrunHareketRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(865, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UrunHareketRaporu";
            this.Text = "Ürün Hareket Raporu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button bntGenelRapor;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lstHareketRaporu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHareketSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHareketIptal;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Hareket;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader Birimi;
        private System.Windows.Forms.ColumnHeader Miktari;
    }
}