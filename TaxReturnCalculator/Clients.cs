using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;
using System.Data.SQLite;

namespace TaxReturnCalculator
{
    public partial class Clients : Form
    {

        string path = "data source=clients.db3";
        string fileDB = "clients.db3";
        //JavaScriptSerializer serData = new JavaScriptSerializer();
        public Clients()
        {
            InitializeComponent();

            labelError.Text = "";
            CreateDataBaseAndTable();

            ReadData();

            //foreach (var client in ReadData().clients)
            //{
            //   listClientsBox.Items.Add(client.name);
            //}

            listClientsBox.Click += ListClientsBox_Click;
        }

        private void ListClientsBox_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM client";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (listClientsBox.SelectedItem.ToString() == reader["name"].ToString())
                {
                    nameClient.Text = reader["name"].ToString();
                    idClient.Text = reader["idName"].ToString();
                    passClient.Text = reader["pass"].ToString();
                    secondPassClient.Text = reader["secondPass"].ToString();
                }
            }
            conn.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string name = inputNameClient.Text;
            string idName = inputIdClient.Text;
            string pass = inputPassClient.Text;
            string secondPass = inputSecondPassClient.Text;

            InsertData(name, idName, pass, secondPass);

            inputNameClient.Text = "";
            inputIdClient.Text = "";
            inputPassClient.Text = "";
            inputSecondPassClient.Text = "";

            ReadData();
        }


        public void CreateDataBaseAndTable()
        {
            if (!File.Exists(fileDB))
            {
                string createQuerry = @"CREATE TABLE IF NOT EXISTS client
                                        (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                        name VARCHAR(255),
                                        idName VARCHAR(255),
                                        pass VARCHAR(255),
                                        secondPass VARCHAR(255))";

                SQLiteConnection.CreateFile("clients.db3");
                ConnectionSql(createQuerry);
            }
        }

        void ConnectionSql(string commandText)
        {
            SQLiteConnection conn = new SQLiteConnection(path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = commandText;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void InsertData(string name, string idName, string pass, string secondPass)
        {
            if (ValidateInputs(name, idName, pass, secondPass))
            {
                labelError.Text = "All fields are requared!";
            }
            else
            {
                string cmdText = $"INSERT INTO client (name, idName, pass, secondPass) VALUES ('{name}', '{idName}', '{pass}', '{secondPass}')";
                ConnectionSql(cmdText);
                labelError.Text = "";
            }
        }

        public void ReadData()
        {
            listClientsBox.Items.Clear();
            SQLiteConnection conn = new SQLiteConnection(path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM client";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listClientsBox.Items.Add(reader["name"]);
            }
            conn.Close();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            string name = listClientsBox.SelectedItem.ToString();
            string cmdText = $"DELETE FROM client WHERE name = '{name}'";
            ConnectionSql(cmdText);
            ReadData();
        }

        private void btnChangeClient_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM client";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    if (listClientsBox.SelectedItem.ToString() == reader["name"].ToString())
                    {
                        inputNameClient.Text = reader["name"].ToString();
                        inputIdClient.Text = reader["idName"].ToString();
                        inputPassClient.Text = reader["pass"].ToString();
                        inputSecondPassClient.Text = reader["secondPass"].ToString();
                    }
                }
                catch (Exception)
                {
   
                }

            }
            conn.Close();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            string selectName = listClientsBox.SelectedItem.ToString();
            string name = inputNameClient.Text;
            string idName = inputIdClient.Text;
            string pass = inputPassClient.Text;
            string secondPass = inputSecondPassClient.Text;

            if (ValidateInputs(name, idName, pass, secondPass))
            {
                labelError.Text = "All fields are requared!";
            }else
            {
                string cmdText = $"UPDATE client SET name = '{name}', idName = '{idName}', pass = '{pass}', secondPass = '{secondPass}' WHERE name = '{selectName}'";
                ConnectionSql(cmdText);
            } 
        }

        bool ValidateInputs(string name, string idName, string pass, string secondPass)
        {
            return (String.IsNullOrWhiteSpace(name) ||
                    String.IsNullOrWhiteSpace(idName) ||
                    String.IsNullOrWhiteSpace(pass) ||
                    String.IsNullOrWhiteSpace(secondPass)) ? true : false;
        }















        /*
                //Show info client by selecting in client box
                private void ListClientsBox_Click(object sender, EventArgs e)
                {
                    for (int i = 0; i < ReadData().clients.Count; i++)
                    {
                        if(listClientsBox.SelectedIndex == i)
                        {
                            nameClient.Text = ReadData().clients[i].name;
                            idClient.Text = ReadData().clients[i].id.ToString();
                            passClient.Text = ReadData().clients[i].pass;
                        }
                    }
                }

                ClientsList ReadData()
                {
                    String dataClient = File.ReadAllText("clientsList.json");
                    return serData.Deserialize<ClientsList>(dataClient);
                }

                void WriteData()
                {

                    Client clientInfo = new Client();
                    clientInfo.name = inputNameClient.Text;
                    clientInfo.id = double.Parse(inputIdClient.Text);
                    clientInfo.pass = inputPassClient.Text;

                    ClientsList dataClient = new ClientsList();
                    foreach (var client in ReadData().clients)
                    {
                        dataClient.clients.Add(client);
                    }
                    dataClient.clients.Add(clientInfo);
                    string outJson = serData.Serialize(dataClient);
                    File.WriteAllText("clientsList.json", outJson);
                    listClientsBox.Items.Add(clientInfo.name);
                }

                private void btnAddClient_Click(object sender, EventArgs e)
                {
                    WriteData();

                    inputNameClient.Text = "";
                    inputIdClient.Text= "";
                    inputPassClient.Text = "";
                }

            */
    }
}
