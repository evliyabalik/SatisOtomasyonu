﻿using Perakende_Satış_Otomasyonu.Class.Database;
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
    }
}
