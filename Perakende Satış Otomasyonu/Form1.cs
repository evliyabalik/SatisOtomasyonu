using System;
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

        public MainForm()
        {
            InitializeComponent();
            Firma_Bilgileri firmaBilgileri = new Firma_Bilgileri();


            Database data = new Database();
            lblCompanyName.Text = data.GetData("select * from Firma_Bilgileri", "Firma_adi");

            if (data.DataCount == 0)
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
            ÜrünKartları urunKartlari = new ÜrünKartları();
            urunKartlari.Show();
        }

        private void kullanıcıHesaplarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kisi_Ekle kisi = new Kisi_Ekle();
            kisi.Show();
        }

        private void btnUrunGirisi_Click(object sender, EventArgs e)
        {
            Ürün_Girişi urunGiris = new Ürün_Girişi();
            urunGiris.Show();
        }

        private void btnUrunCikisi_Click(object sender, EventArgs e)
        {
            Ürün_Çıkışı cikisUrun = new Ürün_Çıkışı();
            cikisUrun.Show();
        }
    }
}