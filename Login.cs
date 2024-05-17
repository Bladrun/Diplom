using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleForStudents
{
    public partial class Login : Form
    {
        Main secondform;
        string connectrionString = "server=localhost;port=3307;username=root;password=;database=schedule";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                textBoxUserLogin.Text = Properties.Settings.Default.Username;
                textBoxUserPassword.Text = Properties.Settings.Default.Password;
            }
        }
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connectrionString))
            {
                try
                {
                    connection.Open();
                    string surname = "";
                    MySqlCommand command = new MySqlCommand("SELECT fio FROM users WHERE username= @usn AND password = @pass", connection);
                    command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxUserLogin.Text;
                    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxUserPassword.Text;
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        
                        if (table.Rows.Count > 0)
                        {
                            if (reader.Read())
                            {
                                surname = reader.GetString("fio");
                                if (CheckBoxRemember.Checked == true)
                                {
                                Properties.Settings.Default.Username = textBoxUserLogin.Text;
                                Properties.Settings.Default.Password = textBoxUserPassword.Text;
                                Properties.Settings.Default.Save();
                                }
                                else
                                {
                                Properties.Settings.Default.Username = "";
                                Properties.Settings.Default.Password = "";
                                Properties.Settings.Default.Save();
                                }
                                secondform = new Main(surname);
                                secondform.FormClosed += Main_FormClosed;
                                secondform.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                    }

                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Ошибка MySQL: " + ex.Message);
                }
            }
        }

        public void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxUserLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserLogin.Text == "Введите логин")
            {
                textBoxUserLogin.Text = "";
                textBoxUserLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxUserLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxUserLogin.Text == "Введите логин")
            {
                textBoxUserLogin.Text = "";
                textBoxUserLogin.ForeColor = Color.Silver;
            }
        }

        private void textBoxUserPassword_Click(object sender, EventArgs e)
        {
            if (textBoxUserPassword.Text == "Пароль")
            {
                textBoxUserPassword.Text = "";
                textBoxUserPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxUserPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxUserPassword.Text == "Пароль")
            {
                textBoxUserPassword.Text = "";
                textBoxUserPassword.ForeColor = Color.Silver;
            }
        }

        private void CheckBoxPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPassShow.Checked)
            {
                textBoxUserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxUserPassword.UseSystemPasswordChar = true;
            }
        }

        
    }
}
