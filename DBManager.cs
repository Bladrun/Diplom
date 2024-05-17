using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace ScheduleForStudents
{
    public class DBManager
    {
        private MySqlConnection connection;
        private string server;
        private string port;
        private string database;
        private string uid;
        private string password;

        public DBManager()
        {
            InitializeDB();
        }

        private void InitializeDB()
        {
            server = "localhost";
            port = "3307";
            database = "schedule";
            uid = "root1";
            password = "";
            string connectionString;
            connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
