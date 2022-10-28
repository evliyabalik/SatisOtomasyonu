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
    public partial class Ürün_Kartları_Arama : Form
    {
        Database data = new Database();

        public Ürün_Kartları_Arama()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Database.selectValueId= data.GetData("select * from Urun where Urun_barkod like '" + lstSearchList.SelectedItems[0].SubItems[0].Text + "' ", "Urun_id");
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbUrunAdi.Checked)
                data.SearchData(lstSearchList, "select * from Urun where Urun_adi like '" + txtUrunAdi.Text + "'");
            else if (rdbBarkod.Checked)
                data.SearchData(lstSearchList, "select * from Urun where Urun_barkod like '" + txtUrunAdi.Text + "'");
                
        }

        private void Ürün_Kartları_Arama_Load(object sender, EventArgs e)
        {
            if(!rdbBarkod.Checked && !rdbUrunAdi.Checked)
                rdbUrunAdi.Checked = true;
        }
    }
}
