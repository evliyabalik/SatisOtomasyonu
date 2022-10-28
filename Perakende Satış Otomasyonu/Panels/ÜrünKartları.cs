using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perakende_Satış_Otomasyonu.Class.Database;

namespace Perakende_Satış_Otomasyonu.Panels
{
    public partial class ÜrünKartları : Form
    {
        Database data = new Database();
        int count;

        public ÜrünKartları()
        {
            InitializeComponent();
            count= data.GetDataCount("select count(*) from Urun");
            

            data.AddDataListView(lstUrunKartlari);


            if (Database.selectValueId != null)
                GetDataInListView();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (data.IsHaveData("Select * from Urun","Urun_barkod",txtBarkod.Text) && data.IsHaveData("Select * from Urun", "Urun_adi", txtUrunAdi.Text)) 
                {
                    data.AddNewProduct(txtBarkod.Text, cmbGrup.Text, txtUrunAdi.Text, cmbBirim.Text, Int32.Parse(txtKritikSeviye.Text), Decimal.Parse(txtBirimFiyati.Text));
                    //data.AddListView(lstUrunKartlari, txtBarkod.Text, cmbGrup.Text, txtUrunAdi.Text, cmbBirim.Text, Decimal.Parse(txtBirimFiyati.Text));
                    lstUrunKartlari.Items.Clear();
                    data.AddDataListView(lstUrunKartlari);
                }
                else
                {
                    data.UpdateProduct(txtBarkod.Text,cmbGrup.Text,txtUrunAdi.Text,cmbBirim.Text,Int32.Parse(txtKritikSeviye.Text), decimal.Parse(txtBirimFiyati.Text), Database.selectValueId);
                    lstUrunKartlari.Items.Clear();
                    data.AddDataListView(lstUrunKartlari);
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ürün Eklenemedi. " + ex);
            //}
        }

        private void ÜrünKartları_Load(object sender, EventArgs e)
        {
            lblUrunSayisi.Text = lstUrunKartlari.Items.Count.ToString();

            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstUrunKartlari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                GetDataInListView();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (Database.selectValueId != null)
            {
                data.Delete("Delete from Urun where Urun_id=" + Database.selectValueId);

                lstUrunKartlari.Items.Clear();
                data.AddDataListView(lstUrunKartlari);
            }
        }

        private void btnYeniUrun_Click(object sender, EventArgs e)
        {
            NewProductClick();
        }

        private void btnUrunArama_Click(object sender, EventArgs e)
        {
            Ürün_Kartları_Arama search = new Ürün_Kartları_Arama();
            search.Show();
        }



        private void GetDataInListView()
        {
            Database.selectValueId = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "' ", "Urun_id");
            if (Database.selectValueId != null)
            {
                cmbGrup.Text = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "' ", "Urun_grup");
                txtBarkod.Text = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "' ", "Urun_barkod");
                txtUrunAdi.Text = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "' ", "Urun_adi");
                cmbBirim.Text = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "' ", "Urun_birimi");
                txtKritikSeviye.Text = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "' ", "Urun_miktari");
                txtBirimFiyati.Text = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "' ", "Urun_fiyati");
            }
           
        }

        private void GetDataInListView(string valueId)
        {
            if (Database.selectValueId != null)
            {
                cmbGrup.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_grup");
                txtBarkod.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_barkod");
                txtUrunAdi.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_adi");
                cmbBirim.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_birimi");
                txtKritikSeviye.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_miktari");
                txtBirimFiyati.Text = data.GetData("select * from Urun where Urun_id like '" + valueId + "' ", "Urun_fiyati");
            }
        }

        private void NewProductClick()
        {
            Database.selectValueId = null;
            cmbGrup.Text = "Genel";
            txtBarkod.Text = null;
            txtUrunAdi.Text = null;
            cmbBirim.Text = "Adet";
            txtKritikSeviye.Text = null;
            txtBirimFiyati.Text = null;
        }

        private void ÜrünKartları_Activated(object sender, EventArgs e)
        {
            if (Database.selectValueId != null)
                GetDataInListView(Database.selectValueId);
        }

        private void ÜrünKartları_Deactivate(object sender, EventArgs e)
        {
            NewProductClick();
        }
    }
}
