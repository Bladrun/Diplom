using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ScheduleForStudents
{
    public partial class SemestrAdd : Form
    {
        public delegate void UpdateDataGridView();
        public event UpdateDataGridView DataGridViewUpdated;
        public SemestrAdd()
        {
            InitializeComponent();
            toolTip1.SetToolTip(buttonAddSemestr, "Нажмите, чтобы добавить запись");
            toolTip2.SetToolTip(buttonCancelAddSemestr, "Нажмите, чтобы очистить поля");
        }

        

        private void SemestrAdd_Load(object sender, EventArgs e)
        {
            //SemesterControlClass.getSemestrs();

            //MY_DB.ConnectionDB();
            //LoadComboBoxAddLesson();
            //LoadComboBoxAddGroup();
        }

        private void LoadComboBoxAddLesson()
        {
            //LessonsControlClass.getLessons();

            //comboBoxAddLesson.DataSource = LessonsControlClass.dtLessons;
            //comboBoxAddLesson.DisplayMember = "numb_week";
            //comboBoxAddLesson.ValueMember = "id_lesson";
        }

        private void LoadComboBoxAddGroup()
        {
            //GroupsControlCLass.getGroups();

            //comboBoxAddGroups.DataSource = GroupsControlCLass.dtGroups;
            //comboBoxAddGroups.DisplayMember = "short_number";
            //comboBoxAddGroups.ValueMember = "id_group";
        }

        private void buttonCancelAddLESS_Click(object sender, EventArgs e)
        {
            textBoxNumbSemes.Text = "";
            textBoxYearSem.Text = "";
        }

        private void buttonAddSemestr_Click(object sender, EventArgs e)
        {
            //string q1 = comboBoxAddLesson.SelectedValue.ToString();
            //int id_lesson = int.Parse(q1);

            //string q2 = comboBoxAddGroups.SelectedValue.ToString();
            //int id_group = int.Parse(q2);


            //if (textBoxNumbSemes.Text != "" && textBoxYearSem.Text != "" && comboBoxAddGroups.Text != "" && comboBoxAddLesson.Text != "")
            //{

            //    string sql = @"SELECT id_group, id_lesson FROM semester WHERE semester_number = '"+textBoxNumbSemes.Text+"' AND year = '"+textBoxYearSem.Text+"' AND id_group = '"+id_group+"' AND id_lesson = '"+id_lesson+"'";
            //    MY_DB.msCommand.CommandText = sql;
            //    Object result = MY_DB.msCommand.ExecuteScalar();
            //    if (result == null)
            //    {
            //        if (SemesterControlClass.AddSemesters(textBoxNumbSemes.Text, textBoxYearSem.Text, id_group, id_lesson))
            //        {
            //            MessageBox.Show("Семестр добавлен", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            textBoxNumbSemes.Text = "";
            //            textBoxYearSem.Text = "";
            //            SemesterControlClass.getSemestrs();
            //            //dg.dataGridViewLessons.DataSource = LessonsControlClass.dtLessons;

            //            DataGridViewUpdated?.Invoke();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Семестр не был добавлен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
