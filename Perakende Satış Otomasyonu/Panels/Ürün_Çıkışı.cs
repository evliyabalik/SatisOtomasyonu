using Perakende_Satış_Otomasyonu.Class.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perakende_Satış_Otomasyonu.Panels
{
    public partial class Ürün_Çıkışı : Form
    {
        Database data = new Database();
        public Ürün_Çıkışı()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Database.selectValueId != null)
            {

                string urun_id = Database.selectValueId;
                string tarih = cmbTarih.Text;
                string aciklama = rtbAciklama.Text;


                txtBarkod.Text = data.GetData("select * from Urun where Urun_id like '" + Database.selectValueId + "' ", "Urun_barkod");
                txtUrunAdi.Text = data.GetData("select * from Urun where Urun_id like '" + Database.selectValueId + "' ", "Urun_adi");

                int cikisMiktari = Int32.Parse(txtCikisMiktari.Text);

                data.ExecuteCommand("insert into Urun_cikis (Urun_cikis_id, Urun_cikis_tarih, Urun_cikis_aciklama, Urun_cikis_barkod, Urun_cikis_adi, Urun_cikis_miktari) values ('" + urun_id + "','" + tarih + "','" + aciklama + "','" + txtBarkod.Text + "','" + txtUrunAdi.Text  + "','" + cikisMiktari + "')");
            }
        }

        private void txtCikisMiktari_TextChanged(object sender, EventArgs e)
        {
            if (Database.selectValueId != null)
            {
                btnKaydet.Enabled = true;
                btnKaydet.BackColor = Color.White;
            }
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            Ürün_Kartları_Arama search = new Ürün_Kartları_Arama();
            search.Show();
        }

        private void Ürün_Çıkışı_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            cmbTarih.Text = dt.ToString();
        }

        private void Ürün_Çıkışı_Activated(object sender, EventArgs e)
        {
            if (Database.selectValueId != null)
                GetDataInListView(Database.selectValueId);
        }

        private void GetDataInListView(string valueId)
        {
            if (Database.selectValueId != null)
            {
                txtBarkod.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_barkod");
                txtUrunAdi.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_adi");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database.selectValueId = null;
        }

        private void Ürün_Çıkışı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.selectValueId = null;
        }

        private void Ürün_Çıkışı_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.selectValueId = null;
        }
    }
}
