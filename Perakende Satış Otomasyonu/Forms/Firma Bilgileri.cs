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

namespace Perakende_Satış_Otomasyonu.Panels
{
    public partial class Firma_Bilgileri : Form
    {
        Database data = new Database();

        public Firma_Bilgileri()
        {
            InitializeComponent();
        }

       

        private void Firma_Bilgileri_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string[] companyData = { "Firma_adi, Firma_yetkilisi, Firma_adres, Firma_il, Firma_ilçe, Firma_telefon, Firma_fax, Firma_email, Firma_web_adresi, Firma_vergi_dairesi, Firma_vergi_numarası" };
            ArrayList companyDataValues = new ArrayList() { txtFirmaİsmi.Text + "','" + txtFirmaYetkilisi.Text + "','" + txtAdres.Text + "','" + txtİl.Text + "','" +txtİlçe.Text +"','" + txtTelefon.Text + "','" + txtFax.Text+ "','"+ txtEmail.Text+ "','"+ txtWeb.Text + "','" + txtVergiDairesi.Text + "','" + txtVergiNo.Text };

            try
            {
                data.SqlInsertData(companyData, companyDataValues, "Firma_Bilgileri");
                companyData = null;
                companyDataValues = null;
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Firma eklenemedi.");
            }
            finally
            {
                companyData = null;
                companyDataValues = null;
            }

        }
    }
}
