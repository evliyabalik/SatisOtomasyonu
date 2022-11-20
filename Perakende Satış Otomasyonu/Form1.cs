﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perakende_Satış_Otomasyonu.Panels;
using Perakende_Satış_Otomasyonu.Class.Database;

namespace Perakende_Satış_Otomasyonu
{
    public partial class MainForm : Form
    {
        Database data = new Database();

        Ürün_Girişi urunGiris;
        ÜrünKartları urunKartlari;
        Ürün_Çıkışı cikisUrun;

        public MainForm()
        {
            InitializeComponent();
            Firma_Bilgileri firmaBilgileri = new Firma_Bilgileri();
            urunGiris = new Ürün_Girişi();
            cikisUrun = new Ürün_Çıkışı();
            
            if(data.GetDataCount("select Firma_id from Firma_Bilgileri")>0)
                lblCompanyName.Text = data.GetData("select * from Firma_Bilgileri", "Firma_adi");

            if (data.GetDataCount("select Firma_id from Firma_Bilgileri") == 0)
                firmaBilgileri.Show();
            else
                return;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void firmaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSatisMenusu_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunKartlari_Click(object sender, EventArgs e)
        {
            urunKartlari = new ÜrünKartları();
            urunKartlari.Show();
        }

        private void kullanıcıHesaplarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kisi_Ekle kisi = new Kisi_Ekle();
            kisi.Show();
        }

        private void btnUrunGirisi_Click(object sender, EventArgs e)
        {
            
            urunGiris.Show();
        }

        private void btnUrunCikisi_Click(object sender, EventArgs e)
        {
            
            cikisUrun.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (data.GetDataCount("select Firma_id from Firma_Bilgileri") > 0)
                lblCompanyName.Text = data.GetData("select * from Firma_Bilgileri", "Firma_adi");
        }

        private void ürünKartlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunKartlari = new ÜrünKartları();
            urunKartlari.Show();
        }

        private void ürünGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            urunGiris.Show();
        }

        private void ürünÇıkışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cikisUrun.Show();
            
        }

        private void btnSatisRaporu_Click(object sender, EventArgs e)
        {
            
        }
    }
}