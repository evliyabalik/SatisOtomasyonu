
namespace Perakende_Satış_Otomasyonu.Forms
{
    partial class StokDurumRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokDurumRaporu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdrBarkod = new System.Windows.Forms.RadioButton();
            this.rdrUrunAdi = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstStokRaporu = new System.Windows.Forms.ListView();
            this.Grubu = new System.Windows.Forms.ColumnHeader();
            this.Barkod = new System.Windows.Forms.ColumnHeader();
            this.UrunAdi = new System.Windows.Forms.ColumnHeader();
            this.GirisFiyat = new System.Windows.Forms.ColumnHeader();
            this.BirimFiyat = new System.Windows.Forms.ColumnHeader();
            this.TumGirisler = new System.Windows.Forms.ColumnHeader();
            this.TumCikislar = new System.Windows.Forms.ColumnHeader();
            this.UrunMiktar = new System.Windows.Forms.ColumnHeader();
            this.KritikSeviye = new System.Windows.Forms.ColumnHeader();
            this.GirisSermaye = new System.Windows.Forms.ColumnHeader();
            this.SatisSermaye = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTSatisSermaye = new System.Windows.Forms.Label();
            this.lblTGirisSermaye = new System.Windows.Forms.Label();
            this.lblToplamMiktar = new System.Windows.Forms.Label();
            this.lblToplamCikis = new System.Windows.Forms.Label();
            this.lblToplamGiris = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.rdrUrunAdi);
            this.groupBox1.Controls.Add(this.rdrBarkod);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKapat);
            this.groupBox2.Controls.Add(this.btnYazdir);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rdrBarkod
            // 
            resources.ApplyResources(this.rdrBarkod, "rdrBarkod");
            this.rdrBarkod.Name = "rdrBarkod";
            this.rdrBarkod.TabStop = true;
            this.rdrBarkod.UseVisualStyleBackColor = true;
            // 
            // rdrUrunAdi
            // 
            resources.ApplyResources(this.rdrUrunAdi, "rdrUrunAdi");
            this.rdrUrunAdi.Name = "rdrUrunAdi";
            this.rdrUrunAdi.TabStop = true;
            this.rdrUrunAdi.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            // 
            // btnYazdir
            // 
            resources.ApplyResources(this.btnYazdir, "btnYazdir");
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            resources.ApplyResources(this.btnKapat, "btnKapat");
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.lstStokRaporu);
            this.groupBox3.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lstStokRaporu
            // 
            this.lstStokRaporu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstStokRaporu.AllowColumnReorder = true;
            this.lstStokRaporu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstStokRaporu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Grubu,
            this.Barkod,
            this.UrunAdi,
            this.GirisFiyat,
            this.BirimFiyat,
            this.TumGirisler,
            this.TumCikislar,
            this.UrunMiktar,
            this.KritikSeviye,
            this.GirisSermaye,
            this.SatisSermaye});
            this.lstStokRaporu.FullRowSelect = true;
            this.lstStokRaporu.GridLines = true;
            this.lstStokRaporu.HideSelection = false;
            this.lstStokRaporu.HoverSelection = true;
            resources.ApplyResources(this.lstStokRaporu, "lstStokRaporu");
            this.lstStokRaporu.Name = "lstStokRaporu";
            this.lstStokRaporu.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstStokRaporu.UseCompatibleStateImageBehavior = false;
            this.lstStokRaporu.View = System.Windows.Forms.View.Details;
            // 
            // Grubu
            // 
            resources.ApplyResources(this.Grubu, "Grubu");
            // 
            // Barkod
            // 
            resources.ApplyResources(this.Barkod, "Barkod");
            // 
            // UrunAdi
            // 
            resources.ApplyResources(this.UrunAdi, "UrunAdi");
            // 
            // GirisFiyat
            // 
            resources.ApplyResources(this.GirisFiyat, "GirisFiyat");
            // 
            // BirimFiyat
            // 
            resources.ApplyResources(this.BirimFiyat, "BirimFiyat");
            // 
            // TumGirisler
            // 
            resources.ApplyResources(this.TumGirisler, "TumGirisler");
            // 
            // TumCikislar
            // 
            resources.ApplyResources(this.TumCikislar, "TumCikislar");
            // 
            // UrunMiktar
            // 
            resources.ApplyResources(this.UrunMiktar, "UrunMiktar");
            // 
            // KritikSeviye
            // 
            resources.ApplyResources(this.KritikSeviye, "KritikSeviye");
            // 
            // GirisSermaye
            // 
            resources.ApplyResources(this.GirisSermaye, "GirisSermaye");
            // 
            // SatisSermaye
            // 
            resources.ApplyResources(this.SatisSermaye, "SatisSermaye");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblTSatisSermaye);
            this.panel1.Controls.Add(this.lblTGirisSermaye);
            this.panel1.Controls.Add(this.lblToplamMiktar);
            this.panel1.Controls.Add(this.lblToplamCikis);
            this.panel1.Controls.Add(this.lblToplamGiris);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Name = "label8";
            // 
            // lblTSatisSermaye
            // 
            resources.ApplyResources(this.lblTSatisSermaye, "lblTSatisSermaye");
            this.lblTSatisSermaye.ForeColor = System.Drawing.Color.Lime;
            this.lblTSatisSermaye.Name = "lblTSatisSermaye";
            // 
            // lblTGirisSermaye
            // 
            resources.ApplyResources(this.lblTGirisSermaye, "lblTGirisSermaye");
            this.lblTGirisSermaye.ForeColor = System.Drawing.Color.Lime;
            this.lblTGirisSermaye.Name = "lblTGirisSermaye";
            // 
            // lblToplamMiktar
            // 
            resources.ApplyResources(this.lblToplamMiktar, "lblToplamMiktar");
            this.lblToplamMiktar.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamMiktar.Name = "lblToplamMiktar";
            // 
            // lblToplamCikis
            // 
            resources.ApplyResources(this.lblToplamCikis, "lblToplamCikis");
            this.lblToplamCikis.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamCikis.Name = "lblToplamCikis";
            // 
            // lblToplamGiris
            // 
            resources.ApplyResources(this.lblToplamGiris, "lblToplamGiris");
            this.lblToplamGiris.ForeColor = System.Drawing.Color.Lime;
            this.lblToplamGiris.Name = "lblToplamGiris";
            // 
            // StokDurumRaporu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StokDurumRaporu";
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdrUrunAdi;
        private System.Windows.Forms.RadioButton rdrBarkod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTSatisSermaye;
        private System.Windows.Forms.Label lblTGirisSermaye;
        private System.Windows.Forms.Label lblToplamMiktar;
        private System.Windows.Forms.Label lblToplamCikis;
        private System.Windows.Forms.Label lblToplamGiris;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstStokRaporu;
        private System.Windows.Forms.ColumnHeader Grubu;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader GirisFiyat;
        private System.Windows.Forms.ColumnHeader BirimFiyat;
        private System.Windows.Forms.ColumnHeader TumGirisler;
        private System.Windows.Forms.ColumnHeader TumCikislar;
        private System.Windows.Forms.ColumnHeader UrunMiktar;
        private System.Windows.Forms.ColumnHeader KritikSeviye;
        private System.Windows.Forms.ColumnHeader GirisSermaye;
        private System.Windows.Forms.ColumnHeader SatisSermaye;
        private System.Windows.Forms.Label label3;
    }
}