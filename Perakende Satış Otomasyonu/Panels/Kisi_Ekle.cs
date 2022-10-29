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
    public partial class Kisi_Ekle : Form
    {
        Database data = new Database();
        public Kisi_Ekle()
        {
            InitializeComponent();
           
        }

        private void Kisi_Ekle_Load(object sender, EventArgs e)
        {
            data.AddItemCmb(cmbPosition, "select * from Personal_Positions", "Position_name");
            data.AddItemCmb(cmbYetki, "select * from Personal_Authority", "Authority_name");

            cmbPosition.Text=cmbPosition.Items[0].ToString();
            cmbYetki.Text = cmbYetki.Items[0].ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
                MessageBox.Show("Şifreler Aynı Değil!", "Dikkat");
            else if (!data.IsHaveData("select * from Users", "User_nickname", txtKullaniciAdi.Text) && !data.IsHaveData("select * from Users", "User_email", txtEmail.Text))
                MessageBox.Show("Kullanıcı Zaten Mevcut!", "Dikkat");
            else
            {
                data.ExecuteCommand("Insert into Users (User_name, User_surname, User_nickname, User_password, User_email, User_tel, User_position, User_authority) values ('" + txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "','" + txtEmail.Text + "','" + txtCep.Text + "','" + cmbPosition.Text + "','" + cmbYetki.Text + "')");
                MessageBox.Show("Kullanıcı Eklendi.", "Info");
            }
        }

       

    }
}
