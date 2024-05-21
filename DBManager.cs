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
        private string charset;

        public DBManager()
        {
            InitializeDB();
        }

        private void InitializeDB()
        {

            server = "sql7.freesqldatabase.com";
            port = "3306";
            database = "sql7707770";
            uid = "sql7707770";
            password = "kXTf81kkZI";
            charset = "utf8mb4";
            string connectionString;
            connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};CHARSET={charset};";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
