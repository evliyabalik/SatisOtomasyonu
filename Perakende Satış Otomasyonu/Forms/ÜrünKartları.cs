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
using Perakende_Satış_Otomasyonu.Class.Database;
using Perakende_Satış_Otomasyonu.Class.Program;

namespace Perakende_Satış_Otomasyonu.Panels
{
    public partial class ÜrünKartları : Form
    {
        Database data = new Database();
        SatisOtomasyon otomasyon = new SatisOtomasyon();

        string[] dataName = { "Urun_barkod", "Urun_grup", "Urun_adi", "Urun_birimi", "Urun_fiyati", "Urun_miktari" };
        string[] dataName2 = { "Urun_barkod", "Urun_grup", "Urun_adi", "Urun_birimi", "Urun_fiyati", "Urun_miktari" };


        public ÜrünKartları()
        {
            InitializeComponent();
            data.DataCount = data.GetDataCount("select*from Urun");
            if (data.DataCount != 0)
                data.AddDataToListview("select * from Urun order by Urun_id Desc", dataName, lstUrunKartlari);


            if (Database.selectValueId != null)
                data.GetDataInListView("select * from Urun where Urun_barkod like", dataName, lstUrunKartlari.SelectedItems[0].SubItems[0].Text, txtBarkod, cmbGrup, txtUrunAdi, cmbBirim, txtBirimFiyati, txtKritikSeviye);


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //For Insert command of Array
            string[] productData = { "Urun_barkod, Urun_grup, Urun_adi, Urun_birimi, Urun_miktari, Urun_fiyati" };
            ArrayList productDataValues=new ArrayList() { txtBarkod.Text+"','"+ cmbGrup.Text + "','" + txtUrunAdi.Text + "','" + cmbBirim.Text + "','" + Int32.Parse(txtKritikSeviye.Text) + "','" + Math.Round(double.Parse(txtBirimFiyati.Text),2) };

            //For Update command of Array
            string[] productDataU = { "Urun_barkod"," Urun_grup", " Urun_adi", " Urun_birimi", " Urun_miktari", " Urun_fiyati" };
            ArrayList productDataValuesU = new ArrayList() { txtBarkod.Text ,  cmbGrup.Text ,  txtUrunAdi.Text, cmbBirim.Text, Int32.Parse(txtKritikSeviye.Text), Math.Round(double.Parse(txtBirimFiyati.Text), 2) };

            try
            {
                if (Database.selectValueId==null) 
                {
                    
                    data.SqlInsertData(productData, productDataValues, "Urun");
                    lstUrunKartlari.Items.Clear();
                    data.AddDataToListview("select * from Urun order by Urun_id Desc", dataName, lstUrunKartlari);
                }
                else
                {
                    data.SqlUpdateData(productDataU, productDataValuesU, Database.selectValueId, "Urun_id", "Urun");
                    lstUrunKartlari.Items.Clear();
                    data.AddDataToListview("select * from Urun order by Urun_id Desc", dataName, lstUrunKartlari);
                }

                lblUrunSayisi.Text = lstUrunKartlari.Items.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Eklenemedi. " + ex);
            }
            finally
            {

                productData = null;
                productDataU = null;
                productDataValues = null;
                productDataValuesU = null;
            }
        }

        private void ÜrünKartları_Load(object sender, EventArgs e)
        {
            lblUrunSayisi.Text = lstUrunKartlari.Items.Count.ToString();
            data.AddItemCmb(cmbGrup, "select * from GroupsTable", "Group_name");
            data.AddItemCmb(cmbBirim, "select * from Units", "Unit_name");


            otomasyon.NewProductClick(txtBarkod, txtBirimFiyati, txtKritikSeviye, txtUrunAdi);
            otomasyon.NewProductClick(cmbBirim, cmbGrup);

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Database.selectValueId = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstUrunKartlari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Database.selectValueId = data.GetData("select * from Urun where Urun_barkod like '" + lstUrunKartlari.SelectedItems[0].SubItems[0].Text + "'", "Urun_id");
            data.GetDataInListView("select * from Urun where Urun_barkod like'", dataName, lstUrunKartlari.SelectedItems[0].SubItems[0].Text, txtBarkod, cmbGrup, txtUrunAdi, cmbBirim, txtBirimFiyati, txtKritikSeviye);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Database.selectValueId != null)
            {
                data.ExecuteCommand("Delete from Urun where Urun_id=" + Database.selectValueId);

                lstUrunKartlari.Items.Clear();
                data.AddDataToListview("select * from Urun order by Urun_id Desc", dataName, lstUrunKartlari);
            }

            if (!data.IsHaveData("Select * from Urun_cikis", "Urun_cikis_id", Database.selectValueId))
            {
                data.ExecuteCommand("Delete from Urun_cikis where Urun_cikis_id=" + Database.selectValueId);
            }

            if (!data.IsHaveData("Select * from Urun_giris", "Urun_giris_id", Database.selectValueId))
            {
                data.ExecuteCommand("Delete from Urun_giris where Urun_giris_id=" + Database.selectValueId);
            }

            Database.selectValueId = null;
            lblUrunSayisi.Text = lstUrunKartlari.Items.Count.ToString();
        }

        private void btnYeniUrun_Click(object sender, EventArgs e)
        {
            Database.selectValueId = null;
            otomasyon.NewProductClick(txtBarkod, txtBirimFiyati, txtKritikSeviye, txtUrunAdi);
            otomasyon.NewProductClick(cmbBirim,cmbGrup);
        }

        private void btnUrunArama_Click(object sender, EventArgs e)
        {
            Ürün_Kartları_Arama search = new Ürün_Kartları_Arama();
            search.Show();
        }

        private void ÜrünKartları_Activated(object sender, EventArgs e)
        {

            if (Database.selectValueId != null)
                data.GetDataInListView("select * from Urun where Urun_id like'", dataName, Database.selectValueId, txtBarkod, cmbGrup, txtUrunAdi, cmbBirim, txtBirimFiyati, txtKritikSeviye);
        }

        private void ÜrünKartları_Deactivate(object sender, EventArgs e)
        {

        }

        private void btnGrupEkle_Click(object sender, EventArgs e)
        {
            if (data.IsHaveData("Select*from GroupsTable", "Group_name", cmbGrup.Text))
            {
                data.ExecuteCommand("insert Into GroupsTable (Group_name) values('" + cmbGrup.Text + "')");
                cmbGrup.Items.Add(cmbGrup.Text);
            }
            else
            {
                MessageBox.Show("Grup ismi mevcut.", "Dikkat");
            }
        }

        private void ÜrünKartları_FormClosed(object sender, FormClosedEventArgs e)
        {

            otomasyon.NewProductClick(txtBarkod, txtBirimFiyati, txtKritikSeviye, txtUrunAdi);
            otomasyon.NewProductClick(cmbBirim, cmbGrup);
        }

        private void ÜrünKartları_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database.selectValueId = null;
        }
    }
}
