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
            try
            {
                data.AddCompanyInformation(txtFirmaİsmi.Text.ToString(), txtFirmaYetkilisi.Text.ToString(), txtAdres.Text.ToString(), txtİl.Text.ToString(), txtİlçe.Text.ToString(), txtTelefon.Text.ToString(), txtFax.Text.ToString(), txtEmail.Text.ToString(), txtWeb.Text.ToString(), txtVergiDairesi.Text.ToString(), txtVergiNo.Text.ToString());
                this.Hide();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Firma eklenemedi.");
            }

        }
    }
}
