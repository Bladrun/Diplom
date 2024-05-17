using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using ScheduleForStudents.Controls;
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
    public partial class Main : Form
    {
        Login form;
        public string surname;
        public Main(string surname)
        {
            InitializeComponent();
            this.surname = surname;
            textBox1.Text = surname;
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form = new Login();
            form.FormClosed += Login_FormClosed;
            form.Show();
            this.Hide();
            
        }

        public void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void showControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LessonsControl dc = new LessonsControl();
            showControl(dc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SemesterControl dc = new SemesterControl();
            showControl(dc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TeachersControl dc = new TeachersControl();
            showControl(dc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GroupsControl dc = new GroupsControl();
            showControl(dc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SubjectsControl dc = new SubjectsControl();
            showControl(dc);
        }

        
    }
}
