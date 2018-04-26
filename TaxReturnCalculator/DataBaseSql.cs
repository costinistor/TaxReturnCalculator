using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace TaxReturnCalculator
{
    class DataBaseSql
    {
        string path = "data source=clients.db3";
        string fileDB = "clients.db3";

        public void CreateDataBaseAndTable()
        {
            if (!File.Exists(fileDB))
            {
                string createQuerry = @"CREATE TABLE IF NOT EXISTS clients
                                        (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                        name VARCHAR(255),
                                        idName INT(11),
                                        pass VARCHAR(255)
                                        secondPass VARCHAR(255))";
                SQLiteConnection.CreateFile("clients.db3");
                SQLiteConnection conn = new SQLiteConnection(path);
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = createQuerry;
                cmd.ExecuteNonQuery();
                conn.Close(); 
            }
        }

        public void InsertData(string name, int idName, string pass, string secondPass)
        {
            SQLiteConnection conn = new SQLiteConnection(path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = $"INSERT INTO clients (name, idName, pass, secondPass) VALUES ({name}, {idName}, {pass}, {secondPass})";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ReadData()
        {
            SQLiteConnection conn = new SQLiteConnection(path);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM clients";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Name: " + reader["name"] + " " + "age: " + reader["age"]);
            }
            conn.Close();
        }
    }
}
