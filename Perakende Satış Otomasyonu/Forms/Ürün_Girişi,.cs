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
    public partial class Ürün_Girişi : Form
    {
        Database data = new Database();
        public Ürün_Girişi()
        {
            InitializeComponent();
            
        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            Ürün_Kartları_Arama search = new Ürün_Kartları_Arama();
            search.Show();
        }

        private void Ürün_Girişi_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            cmbTarih.Text = dt.ToString();
        }

        private void Ürün_Girişi_Activated(object sender, EventArgs e)
        {
            if (Database.selectValueId != null)
                data.GetDataforBox("select * from Urun where Urun_id like '", Database.selectValueId, new string[] { "Urun_barkod", "Urun_adi" }, txtBarkod, txtUrunAdi);
        }

        

        private void Ürün_Girişi_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void txtGirisMiktari_TextChanged(object sender, EventArgs e)
        {
            if (Database.selectValueId != null && txtGirisFiyati.Text != "")
            {
                btnKaydet.Enabled = true;
                btnKaydet.BackColor = Color.White;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string[] dataArray = { "Urun_giris_id, Urun_giris_tarih, Urun_giris_aciklama, Urun_giris_barkod, Urun_giris_adi, Urun_giris_fiyati, Urun_giris_miktari" };
            ArrayList valuesArray = new ArrayList() { Database.selectValueId + "','" + cmbTarih.Text + "','" + rtbAciklama.Text + "','" + txtBarkod.Text + "','" + txtUrunAdi.Text + "','" + float.Parse(txtGirisFiyati.Text) + "','" + Int32.Parse(txtGirisMiktari.Text) };

            try
            {
                DialogResult toDecide = MessageBox.Show(txtUrunAdi.Text + " ürününden " + txtGirisMiktari.Text + " adet giriş yapılacak onaylıyor musunuz?", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(toDecide==DialogResult.OK)
                    if (Database.selectValueId != null)
                    {
                        data.SqlInsertData(dataArray, valuesArray, "Urun_giris");
                        MessageBox.Show("Ürün girişi başarıyla eklendi.", "Bilgilendirme");
                    }
                if(toDecide==DialogResult.Cancel)
                    MessageBox.Show("Ürün Girişi Yapılmadı","Bilgilendirme"); 
            }
            catch (Exception error)
            {

                MessageBox.Show("Hata Ürün eklenmedi. "+error,"Hata", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            finally
            {
                dataArray = null;
                valuesArray = null;
            }

           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database.selectValueId = null;
        }

        private void Ürün_Girişi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Database.selectValueId = null;
        }

        private void Ürün_Girişi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.selectValueId = null;
        }
    }
}
