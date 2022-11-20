using Perakende_Satış_Otomasyonu.Class.Database;
using System;
using System.Collections;
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
            string[] dataArray = { "Urun_cikis_id, Urun_cikis_tarih, Urun_cikis_aciklama, Urun_cikis_barkod, Urun_cikis_adi, Urun_cikis_miktari" };
            ArrayList valuesArray = new ArrayList() { Database.selectValueId + "','" + cmbTarih.Text + "','" + rtbAciklama.Text + "','" + txtBarkod.Text + "','" + txtUrunAdi.Text + "','" +Int32.Parse(txtCikisMiktari.Text) };

            try
            {
                DialogResult toDecide = MessageBox.Show(txtUrunAdi.Text + " ürününden " + txtCikisMiktari.Text + " adet çıkış yapılacak onaylıyor musunuz?", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (toDecide == DialogResult.OK)
                    if (Database.selectValueId != null)
                    {
                        data.SqlInsertData(dataArray, valuesArray, "Urun_cikis");
                        MessageBox.Show("Ürün çıkışı başarıyla Yapıldı.", "Bilgilendirme");
                    }
                if (toDecide == DialogResult.Cancel)
                    MessageBox.Show("Ürün Çıkışı Yapılmadı", "Bilgilendirme");
            }
            catch (Exception error)
            {

                MessageBox.Show("Hata Ürün eklenmedi. " + error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataArray = null;
                valuesArray = null;
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
                data.GetDataforBox("select * from Urun where Urun_id like '", Database.selectValueId, new string[] { "Urun_barkod", "Urun_adi" }, txtBarkod, txtUrunAdi);
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
