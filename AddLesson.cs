using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScheduleForStudents
{
    public partial class AddLesson : Form
    {
        public delegate void UpdateDataGridView();
        public event UpdateDataGridView DataGridViewUpdated;
        public AddLesson()
        {
            InitializeComponent();
            toolTip1.SetToolTip(buttonAddLesson, "Нажмите, чтобы добавить запись");
            toolTip2.SetToolTip(buttonCancelAddLESS, "Нажмите, чтобы очистить поля");
        }

        private void buttonAddLesson_Click(object sender, EventArgs e)
        {
            //string q1 = comboBoxTeach.SelectedValue.ToString();
            //int id_teacher = int.Parse(q1);

            //string q2 = comboBoxGroupsAdd.SelectedValue.ToString();
            //int id_group = int.Parse(q2);

            //string q3 = comboBoxSubj.SelectedValue.ToString();
            //int id_subject = int.Parse(q3);

            //if (textBoxNumbDay.Text != "" && textBoxTypeWeek.Text != "" && textBoxDay.Text != "" && comboBoxSubj.Text != "" && textBoxStart.Text != "" && textBoxEnd.Text != "" && textBoxCab.Text != "" && comboBoxGroupsAdd.Text != "" && comboBoxTeach.Text != "")
            //{

            //    string sql = @"SELECT id_subject, id_group, id_teacher FROM schedule_week WHERE numb_week = '"+textBoxTypeWeek.Text+"' AND chet_or_nechet = '"+textBoxTypeWeek.Text+"' AND day_of_the_week = '"+textBoxDay.Text+"' AND id_subject = '"+id_subject+"' AND start_time = '"+textBoxStart.Text+"' AND end_time = '"+textBoxEnd.Text+"' AND cabinet = '"+textBoxCab.Text+"' AND id_group = '"+id_group+"' AND id_teacher = '"+id_teacher+"'";
            //    MY_DB.msCommand.CommandText = sql;
            //    Object result = MY_DB.msCommand.ExecuteScalar();
            //    if (result == null)
            //    {
            //        if (LessonsControlClass.AddLessons(textBoxNumbDay.Text, textBoxTypeWeek.Text, textBoxDay.Text, id_subject, textBoxStart.Text, textBoxEnd.Text, textBoxCab.Text, id_group, id_teacher))
            //        {
            //            MessageBox.Show("Пара добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            textBoxNumbDay.Text = "";
            //            textBoxTypeWeek.Text = "";
            //            textBoxDay.Text = "";
            //            textBoxStart.Text = "";
            //            textBoxEnd.Text = "";
            //            textBoxCab.Text = "";
            //            LessonsControlClass.getLessons();
            //            //dg.dataGridViewLessons.DataSource = LessonsControlClass.dtLessons;

            //            DataGridViewUpdated?.Invoke();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Пара не была добавлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void AddLesson_Load(object sender, EventArgs e)
        {
            //LessonsControlClass.getLessons();

            //MY_DB.ConnectionDB();
            //LoadComboBoxTeacherAdd();
            //LoadComboBoxGroupAdd();
            //LoadComboBoxSubjectAdd();
        }

        private void LoadComboBoxTeacherAdd()
        {
            //TeachersControlClass.getTeachers();

            //comboBoxTeach.DataSource = TeachersControlClass.dtTeachers;
            //comboBoxTeach.DisplayMember = "fio";
            //comboBoxTeach.ValueMember = "id_teacher";
        }

        private void LoadComboBoxGroupAdd()
        {
            //GroupsControlCLass.getGroups();

            //comboBoxGroupsAdd.DataSource = GroupsControlCLass.dtGroups;
            //comboBoxGroupsAdd.DisplayMember = "short_number";
            //comboBoxGroupsAdd.ValueMember = "id_group";
        }

        private void LoadComboBoxSubjectAdd()
        {
            //SubjectControlClass.getSubjects();

            //comboBoxSubj.DataSource = SubjectControlClass.dtSubjects;
            //comboBoxSubj.DisplayMember = "name_of_the_subject";
            //comboBoxSubj.ValueMember = "id_subject";
        }

        private void buttonCancelAddLESS_Click(object sender, EventArgs e)
        {
            textBoxNumbDay.Text = "";
            textBoxTypeWeek.Text = "";
            textBoxDay.Text = "";
            textBoxStart.Text = "";
            textBoxEnd.Text = "";
            textBoxCab.Text = "";
        }
    }
}
