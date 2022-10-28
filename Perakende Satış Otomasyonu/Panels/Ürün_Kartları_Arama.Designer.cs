
namespace Perakende_Satış_Otomasyonu.Panels
{
    partial class Ürün_Kartları_Arama
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
            this.lblUrunSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSearchList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.Adanba = new System.Windows.Forms.GroupBox();
            this.rdbUrunAdi = new System.Windows.Forms.RadioButton();
            this.rdbBarkod = new System.Windows.Forms.RadioButton();
            this.btnKapat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTumuArama = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Adanba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUrunSayisi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 30);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // lblUrunSayisi
            // 
            this.lblUrunSayisi.AutoSize = true;
            this.lblUrunSayisi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUrunSayisi.Location = new System.Drawing.Point(186, 4);
            this.lblUrunSayisi.Name = "lblUrunSayisi";
            this.lblUrunSayisi.Size = new System.Drawing.Size(17, 19);
            this.lblUrunSayisi.TabIndex = 1;
            this.lblUrunSayisi.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listelenen Ürün Sayısı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSearchList);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 315);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Listesi";
            // 
            // lstSearchList
            // 
            this.lstSearchList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstSearchList.HideSelection = false;
            this.lstSearchList.Location = new System.Drawing.Point(9, 19);
            this.lstSearchList.Name = "lstSearchList";
            this.lstSearchList.Size = new System.Drawing.Size(452, 290);
            this.lstSearchList.TabIndex = 0;
            this.lstSearchList.UseCompatibleStateImageBehavior = false;
            this.lstSearchList.View = System.Windows.Forms.View.Details;
            this.lstSearchList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Barkodu";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Grubu";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Birimi";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birim Fiyatı";
            this.columnHeader5.Width = 80;
            // 
            // Adanba
            // 
            this.Adanba.Controls.Add(this.rdbUrunAdi);
            this.Adanba.Controls.Add(this.rdbBarkod);
            this.Adanba.Controls.Add(this.btnKapat);
            this.Adanba.Controls.Add(this.button1);
            this.Adanba.Controls.Add(this.btnIptal);
            this.Adanba.Controls.Add(this.btnTumuArama);
            this.Adanba.Controls.Add(this.txtUrunAdi);
            this.Adanba.Controls.Add(this.label4);
            this.Adanba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adanba.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Adanba.Location = new System.Drawing.Point(8, 12);
            this.Adanba.Name = "Adanba";
            this.Adanba.Size = new System.Drawing.Size(470, 82);
            this.Adanba.TabIndex = 8;
            this.Adanba.TabStop = false;
            this.Adanba.Text = "Ürün Arama";
            // 
            // rdbUrunAdi
            // 
            this.rdbUrunAdi.AutoSize = true;
            this.rdbUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbUrunAdi.Location = new System.Drawing.Point(77, 22);
            this.rdbUrunAdi.Name = "rdbUrunAdi";
            this.rdbUrunAdi.Size = new System.Drawing.Size(74, 19);
            this.rdbUrunAdi.TabIndex = 25;
            this.rdbUrunAdi.TabStop = true;
            this.rdbUrunAdi.Text = "Ürün Adı";
            this.rdbUrunAdi.UseVisualStyleBackColor = true;
            // 
            // rdbBarkod
            // 
            this.rdbBarkod.AutoSize = true;
            this.rdbBarkod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdbBarkod.Location = new System.Drawing.Point(9, 22);
            this.rdbBarkod.Name = "rdbBarkod";
            this.rdbBarkod.Size = new System.Drawing.Size(65, 19);
            this.rdbBarkod.TabIndex = 24;
            this.rdbBarkod.TabStop = true;
            this.rdbBarkod.Text = "Barkod";
            this.rdbBarkod.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKapat.Location = new System.Drawing.Point(374, 17);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 24);
            this.btnKapat.TabIndex = 13;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(343, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 24);
            this.button1.TabIndex = 23;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIptal.Location = new System.Drawing.Point(289, 19);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(61, 24);
            this.btnIptal.TabIndex = 22;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnTumuArama
            // 
            this.btnTumuArama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTumuArama.Location = new System.Drawing.Point(222, 19);
            this.btnTumuArama.Name = "btnTumuArama";
            this.btnTumuArama.Size = new System.Drawing.Size(61, 24);
            this.btnTumuArama.TabIndex = 16;
            this.btnTumuArama.Text = "Tümü";
            this.btnTumuArama.UseVisualStyleBackColor = true;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(64, 49);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(273, 23);
            this.txtUrunAdi.TabIndex = 21;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Aranan:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Ürün_Kartları_Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Adanba);
            this.Name = "Ürün_Kartları_Arama";
            this.Text = "Ürün Kartları";
            this.Load += new System.EventHandler(this.Ürün_Kartları_Arama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Adanba.ResumeLayout(false);
            this.Adanba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUrunSayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox Adanba;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTumuArama;
        private System.Windows.Forms.RadioButton rdbUrunAdi;
        private System.Windows.Forms.RadioButton rdbBarkod;
        public System.Windows.Forms.ListView lstSearchList;
    }
}