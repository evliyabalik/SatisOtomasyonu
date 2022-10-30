using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Perakende_Satış_Otomasyonu.Class.Database
{
    public class Database : Form
    {
        private string ConnectionString { get { return "Data Source=DESKTOP-VFCQAL0\\MSSQL;Initial Catalog=SatisOtomasyonu;Integrated Security=True; MultipleActiveResultSets=True;"; } }
        private int _dataCound;

        private SqlConnection sql = new SqlConnection();

        public int DataCount { get { return _dataCound; } }
        public static string nData;
        public static string selectValueId;


        SqlCommand command;
        SqlDataReader reader;


        //Constructer Method
        public Database()
        {
            if (this.sql.ConnectionString == null || sql.ConnectionString == "")
                this.sql.ConnectionString = ConnectionString;

            if (this.sql.State == System.Data.ConnectionState.Closed)
                this.sql.Open();

            GetDataCount();
        }

        //Add data to list view
        public void AddDataToListview(string query,string[] dataArray, ListView lstView)
        {
            DatabaseConOpen();
            
            reader = GetReadData(query);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    for (int i = 0; i < lstView.Columns.Count; i++)
                    {
                        if (i == 0)
                        {
                            item.Text = (reader[dataArray[i].ToString()].ToString());
                            continue;
                        }
                        item.SubItems.Add(reader[dataArray[i].ToString()].ToString());
                        
                    }
                    lstView.Items.Add(item);
                }
            }

            DatabaseConClose();
        }


        //get data count
        public int GetDataCount(string query)
        {
            DatabaseConOpen();
            command = new SqlCommand(query, sql);
            int executeScalar = Convert.ToInt32(command.ExecuteScalar());
            DatabaseConClose();
            return executeScalar;
        }



        // Add new Company
        public void AddCompanyInformation(string compName, string compBoss, string address, string city, string district, string tel, string fax, string email, string webAddress, string taxAdministration, string taxNum)
        {
            DatabaseConOpen();
            command = new SqlCommand("INSERT INTO Firma_Bilgileri (Firma_adi, Firma_yetkilisi, Firma_adres, Firma_il, Firma_ilçe, Firma_telefon, Firma_fax, Firma_email, Firma_web_adresi, Firma_vergi_dairesi, Firma_vergi_numarası) values ('" + compName + "','" + compBoss + "','" + address + "','" + city + "','" + district + "','" + tel + "','" + fax + "','" + email + "','" + webAddress + "','" + taxAdministration + "','" + taxNum + "')", sql);
            command.ExecuteNonQuery();
            DatabaseConClose();
        }

        //Listview search data
        public void SearchDataInListView(string query, ListView listView, string[] dataName)
        {
            //Bir sorgu çevirecek
            reader = GetReadData(query);

            //listView içine aktaracak
            if (!reader.IsClosed && reader.HasRows)
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    
                    for (int i = 0; i < listView.Columns.Count; i++)
                    {
                        if (i == 0)
                        {
                            item.Text = (reader[dataName[i].ToString()].ToString());
                            continue;
                        }
                        item.SubItems.Add(reader[dataName[i].ToString()].ToString());
                    }

                    listView.Items.Add(item);
                }
            reader.Close();
        }



        //Add New Product
        public void AddNewProduct(string barcode, string group, string productName, string quantityType, int quantity, decimal price)
        {
            string query = "insert into Urun (Urun_barkod, Urun_grup, Urun_adi, Urun_birimi, Urun_miktari, Urun_fiyati) values (@barcode, @group, @productName, @quantityType, @quantity, @price)";


            DatabaseConOpen();
            SqlCommand command = new SqlCommand(query, sql);

            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@group", group);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@quantityType", quantityType);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@price", price);

            command.ExecuteNonQuery();

            DatabaseConClose();
        }

        //Delete Data
        public void Delete(string? query)
        {
            DatabaseConOpen();

            command = new SqlCommand(query, sql);
            command.ExecuteNonQuery();

            DatabaseConClose();

        }

        //Update Product 
        public void UpdateProduct(string barcode, string group, string productName, string quantityType, int quantity, decimal price, string urunID)
        {
            DatabaseConOpen();
            string query = "update Urun set Urun_barkod=@barcode, Urun_grup=@group, Urun_adi=@productName, Urun_birimi= @quantityType, Urun_miktari=@quantity, Urun_fiyati=@price where Urun_id=@urunID";
            command = new SqlCommand(query, sql);

            command.Parameters.AddWithValue("@urunID", urunID);
            command.Parameters.AddWithValue("@barcode", barcode);
            command.Parameters.AddWithValue("@group", group);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@quantityType", quantityType);
            command.Parameters.AddWithValue("@quantity", quantity.ToString());
            command.Parameters.AddWithValue("@price", price.ToString());

            command.ExecuteNonQuery();
            reader.Close();
            DatabaseConClose();
        }

        //Get select data
        public string GetData(string query, string data)
        {
            DatabaseConOpen();

            command = new SqlCommand(query, sql);
            reader = command.ExecuteReader();
            reader.Read();
            string getData = reader[data].ToString();

            return getData;
        }

        //ComboBox add items
        public void AddItemCmb(ComboBox cmb, string query, string data)
        {
            DatabaseConOpen();
            
            using (command = new SqlCommand(query, sql))
            {
                using (reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            cmb.Items.Add(reader[data].ToString());
                        }
                }
            }
        }

        //short command executed
        public void ExecuteCommand(string query)
        {
            DatabaseConOpen();
            command = new SqlCommand(query, sql);
            command.ExecuteNonQuery();
            DatabaseConClose();

        }

        //I don't use now, but one day I'll need it
        //I was going to use it to add data to datagridview
        public void DataAdapterMethod(DataGridView dgrid, string query)
        {
            DatabaseConOpen();
            using (SqlDataAdapter dataAdapter=new SqlDataAdapter(query, sql))
            {
                using (DataSet ds=new DataSet())
                {
                    dataAdapter.Fill(ds);
                    dgrid.DataSource = ds.Tables[0];
                }
            }
            DatabaseConClose();
        }

        //is have data
        public bool IsHaveData(string query, string data, string value)
        {
            DatabaseConOpen();

            reader = GetReadData(query);
            if (!reader.IsClosed && reader.HasRows)
                while (reader.Read())
                {
                    if (value == reader[data].ToString())
                    {
                        return false;
                    }

                }
            return true;


        }


        //Private Method

        //database close
        private void DatabaseConClose()
        {
            if (this.sql != null)
            {
                if (this.sql.State == System.Data.ConnectionState.Open)
                    this.sql.Close();

                this.sql.Dispose();
            }

        }

        //Database open
        private void DatabaseConOpen()
        {
            if (this.sql.ConnectionString == null || sql.ConnectionString == "")
                this.sql.ConnectionString = ConnectionString;

            if (this.sql.State == System.Data.ConnectionState.Closed)
                this.sql.Open();
        }


        //comman read data
        private SqlDataReader GetReadData(string query)
        {
            DatabaseConOpen();
            command = new SqlCommand(query, sql);
            reader = command.ExecuteReader();

            return reader;
        }

        //Data Count 
        private void GetDataCount()
        {
            DatabaseConOpen();

            command = new SqlCommand("select Firma_id from Firma_Bilgileri", sql);
            _dataCound = Convert.ToInt32(command.ExecuteScalar());

            DatabaseConClose();
        }



    }
}
