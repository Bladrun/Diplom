using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void InitializeDB() ///Инциализация бд
        {

            server = "schedulemgkit.c1.is";
            port = "3306";
            database = "schedul5_scheduledb";
            uid = "schedul5_admin";
            password = "admin_228";
            charset = "utf8mb4";
            string connectionString;
            connectionString = $"SERVER={server};PORT={port};DATABASE={database};UID={uid};PASSWORD={password};CHARSET={charset};";

            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection() ///Подлючение бд
        {
            return connection;
        }
    }
}
