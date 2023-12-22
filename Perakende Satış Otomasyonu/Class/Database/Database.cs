using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Perakende_Satış_Otomasyonu.Class.Database
{
    public class Database : Form
    {
        private string ConnectionString { get { return "Data Source=DESKTOP-VFCQAL0\\MSSQL;Initial Catalog=SatisOtomasyonu;Integrated Security=True; MultipleActiveResultSets=True;"; } }
        private int _dataCound;

        private SqlConnection sql = new SqlConnection();

        public int DataCount { get { return _dataCound; } set { _dataCound = value; } }
        public static string nData;
        public static string selectValueId;


        SqlCommand command;
        SqlDataReader reader;


        ////Constructer Method
        //public Database()
        //{
        //    //if (this.sql.ConnectionString == null || sql.ConnectionString == "")
        //    //    this.sql.ConnectionString = ConnectionString;

        //    //if (this.sql.State == System.Data.ConnectionState.Closed)
        //    //    this.sql.Open();

        //}

        //Add data to list view
        public void AddDataToListview(string query, string[] dataArray, ListView lstView)
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

        public void SqlInsertData(string[] data, ArrayList values, string tableName)
        {
            DatabaseConOpen();
            for (int i = 0; i < data.Length; i++)
            {
                command = new SqlCommand("Insert into " + tableName + " (" + data[i].ToString() + ") values ('" + values[i].ToString() + "')", sql);
            }
            command.ExecuteNonQuery();
            DatabaseConClose();
        }


        public void SqlUpdateData(string[] data, ArrayList value, string id, string whichCondition, string tableName)
        {
            DatabaseConOpen();

            for (int i = 0; i < data.Length; i++)
            {

                command = new SqlCommand("update " + tableName + " set " + data[i] + "='" + value[i] + "' where " + whichCondition + "=" + id, sql);
                command.ExecuteNonQuery();
            }

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

        public void GetDataInListView(string query, string[] getdata, string listData, params Control[] boxes)
        {
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].Text = GetData(query + listData + "'", getdata[i]);
            }
        }

        public void GetDataforBox(string query, string id, string[] getdata, params Control[] boxes)
        {
            for (int i = 0; i < boxes.Length; i++)
            {
                boxes[i].Text = GetData(query + id + "'", getdata[i]);
            }
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
            //if (this.sql.ConnectionString == null || sql.ConnectionString == "")
            //    this.sql.ConnectionString = ConnectionString;

            //if (this.sql.State == System.Data.ConnectionState.Closed)
            //    this.sql.Open();
        }


        //comman read data
        private SqlDataReader GetReadData(string query)
        {
            DatabaseConOpen();
            command = new SqlCommand(query, sql);
            reader = command.ExecuteReader();

            return reader;
        }
    }
}
