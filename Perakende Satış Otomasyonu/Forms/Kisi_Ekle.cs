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
    public partial class Kisi_Ekle : Form
    {
        Database data = new Database();
        string[] dataName = { "User_name", "User_surname", "User_nickname", "User_position" };
        public Kisi_Ekle()
        {
            InitializeComponent();
           
        }

        private void Kisi_Ekle_Load(object sender, EventArgs e)
        {
            data.AddDataToListview("select * from Users" , dataName, lstUsers);

            data.AddItemCmb(cmbPosition, "select * from Personal_Positions", "Position_name");
            data.AddItemCmb(cmbYetki, "select * from Personal_Authority", "Authority_name");

            cmbPosition.Text = cmbPosition.Items[0].ToString();
            cmbYetki.Text = cmbYetki.Items[0].ToString();
        }

        
        
        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            ArrayList userDataValues = new ArrayList() { txtAdi.Text + "','" + txtSoyadi.Text + "','" + txtKullaniciAdi.Text + "','" + txtSifre.Text + "','" + txtEmail.Text + "','" + txtCep.Text + "','" + cmbPosition.Text + "','" + cmbYetki.Text };
            string[] userData = { "User_name, User_surname, User_nickname, User_password, User_email, User_tel, User_position, User_authority" };
            


            try
            {
                if (txtAdi.Text != "" && txtSoyadi.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "" && txtEmail.Text != "" && txtCep.Text != "")
                {
                    if (txtSifre.Text != txtSifreTekrar.Text)
                        MessageBox.Show("Şifreler Aynı Değil!", "Dikkat");
                    else if (!data.IsHaveData("select * from Users", "User_nickname", txtKullaniciAdi.Text) && !data.IsHaveData("select * from Users", "User_email", txtEmail.Text))
                        MessageBox.Show("Kullanıcı Zaten Mevcut!", "Dikkat");
                    else
                    {
                        data.SqlInsertData(userData, userDataValues, "Users");
                        MessageBox.Show("Kullanıcı Eklendi.", "Info");

                        lstUsers.Items.Clear();
                        data.AddDataToListview("select * from Users", dataName, lstUsers);
                    }
                }
                else
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!", "Dikkat");
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı eklenemedi! Lütfen Bilgilerinizi Kontrol Ediniz.", "Dikkat");
            }
            finally
            {
                userData = null;
                userDataValues = null;
            }
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
