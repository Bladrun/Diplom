using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.Reflection;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleForStudents.Controls
{
    public partial class LessonsControl : UserControl
    {
       
        public LessonsControl()
        {
            InitializeComponent();
            toolTip1.SetToolTip(buttonEDITLESS, "Нажмите, чтобы сохранить изменения");
            toolTip2.SetToolTip(buttonCANSELEDITLESS, "Нажмите, чтобы очистить изменения в полях");
            toolTip3.SetToolTip(buttonEditVissibleLESS, "Нажмите, чтобы ввести изменения в таблицу");
            toolTip4.SetToolTip(button1, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip5.SetToolTip(VisiblebuttonDeleteLESS, "Нажмите, чтобы удалить данные");
            toolTip6.SetToolTip(buttonAddLesson, "Нажмите, чтобы добавить данные в таблицу");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridViewLessons.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridViewLessons.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridViewLessons[j, i].Value.ToString();
                }
            }



            exApp.Visible = true;
        }


        public void LoadEditComboBoxTeacher()
        {
            //TeachersControlClass.getTeachers();

            //comboBoxEDITEACH.DataSource = TeachersControlClass.dtTeachers;
            //comboBoxEDITEACH.DisplayMember = "fio";
            //comboBoxEDITEACH.ValueMember = "id_teacher";
        }


        public void LoadEditComboBoxGroup()
        {
            //GroupsControlCLass.getGroups();

            //comboBoxEDITGROUP.DataSource = GroupsControlCLass.dtGroups;
            //comboBoxEDITGROUP.DisplayMember = "short_number";
            //comboBoxEDITGROUP.ValueMember = "id_group";
        }

        public void LoadEditComboBoxSubject()
        {
            //SubjectControlClass.getSubjects();

            //comboBoxEditsubject.DataSource = SubjectControlClass.dtSubjects;
            //comboBoxEditsubject.DisplayMember = "name_of_the_subject";
            //comboBoxEditsubject.ValueMember = "id_subject";
        }

      

        private void LessonsControl_Load(object sender, EventArgs e)
        {
            
            LoadEditComboBoxTeacher();
            LoadEditComboBoxGroup();
            LoadEditComboBoxSubject();
            //MY_DB.ConnectionDB();
            //LessonsControlClass.getLessons();
            //dataGridViewLessons.DataSource = LessonsControlClass.dtLessons;
            


        }

        
        

        private void buttonAddLesson_Click(object sender, EventArgs e)
        {
            AddLesson formadd = new AddLesson();
            formadd.DataGridViewUpdated += UpdateDataGridViewOnMainForm;
            formadd.Show();
            
        }

        private void UpdateDataGridViewOnMainForm()
        {
            // Обновляем DataGridView на основной форме
            // Например:
            //dataGridViewLessons.DataSource = LessonsControlClass.dtLessons;
        }

        private void buttonEDITLESS_Click(object sender, EventArgs e)
        {
            //if (textBoxnumbweek.Text == EditNumb && textBoxEdittypeweek.Text == EditChet && textBoxEDITDAY.Text == EditDay && comboBoxEditsubject.Text ==  EditLesson && textBoxEditstarttime.Text == EditStart && textBoxeditendtime.Text == EditEnd && textBoxEDITCAB.Text == EditCabinet && comboBoxEDITGROUP.Text == EditGroup && comboBoxEDITEACH.Text == EditTeacher)
            //{
            //    if (textBoxnumbweek.Text != "" && textBoxEdittypeweek.Text != "" && textBoxEDITDAY.Text != "" && comboBoxEditsubject.Text != "" && textBoxEditstarttime.Text != "" && textBoxeditendtime.Text != "" && textBoxEDITCAB.Text != "" && comboBoxEDITGROUP.Text != "" && comboBoxEDITEACH.Text != "" )
            //    {
            //        string q1 = comboBoxEDITEACH.SelectedValue.ToString();
            //        int id_teacher = int.Parse(q1);

            //        string q2 = comboBoxEDITGROUP.SelectedValue.ToString();
            //        int id_group = int.Parse(q2);

            //        string q3 = comboBoxEditsubject.SelectedValue.ToString();
            //        int id_subject= int.Parse(q3);

            //        if (LessonsControlClass.EditLesson(int.Parse(Editid), textBoxnumbweek.Text, textBoxEdittypeweek.Text, textBoxEDITDAY.Text, id_subject, textBoxEditstarttime.Text, textBoxeditendtime.Text, textBoxEDITCAB.Text, id_group, id_teacher))
            //        {
            //            MessageBox.Show("Редактирование успешно", "Редактирование завершено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            LessonsControlClass.getLessons();
            //            textBoxnumbweek.Text = "";
            //            textBoxEdittypeweek.Text = "";
            //            textBoxEDITDAY.Text = "";
            //            textBoxEditstarttime.Text = "";
            //            textBoxeditendtime.Text = "";
            //            textBoxEDITCAB.Text = "";
            //        }
            //        else
            //        {
            //            MessageBox.Show("Ошибка при редактировании записи");
            //        }

            //    }
            //    else
            //    {
            //        MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    string sql = @"SELECT id_lesson FROM schedule_week WHERE numb_week = '"+textBoxnumbweek.Text+"' AND chet_or_nechet = '"+textBoxEdittypeweek.Text+"' AND day_of_the_week = '"+textBoxEDITDAY.Text+"' AND id_subject = '"+comboBoxEditsubject.Text+"' AND start_time = '"+textBoxEditstarttime.Text+"' AND end_time = '"+textBoxeditendtime.Text+"' AND cabinet = '"+textBoxEDITCAB.Text+"' AND id_group = '"+comboBoxEDITGROUP.Text+"' AND id_teacher = '"+comboBoxEDITEACH.Text+"'";
            //    MY_DB.msCommand.CommandText = sql;
            //    Object result = MY_DB.msCommand.ExecuteScalar();
            //    if (result == null)
            //    {
            //        if (textBoxnumbweek.Text != "" && textBoxEdittypeweek.Text != "" && textBoxEDITDAY.Text != "" && comboBoxEditsubject.Text != "" && textBoxEditstarttime.Text != "" && textBoxeditendtime.Text != "" && textBoxEDITCAB.Text != "" && comboBoxEDITGROUP.Text != "" && comboBoxEDITEACH.Text != "" )
            //        {
            //            string q1 = comboBoxEDITEACH.SelectedValue.ToString();
            //            int id_teacher = int.Parse(q1);

            //            string q2 = comboBoxEDITGROUP.SelectedValue.ToString();
            //            int id_group = int.Parse(q2);

            //            string q3 = comboBoxEditsubject.SelectedValue.ToString();
            //            int id_subject = int.Parse(q3);

            //            if (LessonsControlClass.EditLesson(int.Parse(Editid), textBoxnumbweek.Text, textBoxEdittypeweek.Text, textBoxEDITDAY.Text, id_subject, textBoxEditstarttime.Text, textBoxeditendtime.Text, textBoxEDITCAB.Text, id_group, id_teacher))
            //            {
            //                MessageBox.Show("Редактирование успешно", "Редактирование завершено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                LessonsControlClass.getLessons();
            //                textBoxnumbweek.Text = "";
            //                textBoxEdittypeweek.Text = "";
            //                textBoxEDITDAY.Text = "";
            //                textBoxEditstarttime.Text = "";
            //                textBoxeditendtime.Text = "";
            //                textBoxEDITCAB.Text = "";
            //            }
            //            else
            //            {
            //                MessageBox.Show("Ошибка при редактировании записи");
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
        }

      

        private void buttonCANSELEDITLESS_Click(object sender, EventArgs e)
        {
            textBoxnumbweek.Text = "";
            textBoxEdittypeweek.Text = "";
            textBoxEDITDAY.Text = "";
            textBoxEditstarttime.Text = "";
            textBoxeditendtime.Text = "";
            textBoxEDITCAB.Text = "";
        }


        static public string Editid, EditNumb, EditChet, EditDay, EditLesson, EditStart, EditEnd, EditCabinet, EditTeacher, EditGroup;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    // Вызов метода для получения данных из вашего класса
            //    LessonsControlClass.getLessons();

            //    // Создание DataView из DataTable вашего класса
            //    DataView dv = new DataView(LessonsControlClass.dtLessons);

            //    // Применение фильтра к DataView
            //    dv.RowFilter = string.Format("numb_week LIKE '%{0}%' OR chet_or_nechet LIKE '%{0}%' OR day_of_the_week LIKE '%{0}%' OR name_of_the_subject LIKE '%{0}%' OR cabinet LIKE '%{0}%' OR fio LIKE '%{0}%' OR short_number LIKE '%{0}%'", textBoxSearch.Text);

            //    // Установка нового источника данных для DataGridView
            //    dataGridViewLessons.DataSource = dv;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void buttonEditVissibleLESS_Click(object sender, EventArgs e)
        {
            
            Editid = dataGridViewLessons.CurrentRow.Cells[0].Value.ToString();
            EditNumb = dataGridViewLessons.CurrentRow.Cells[1].Value.ToString();
            EditChet = dataGridViewLessons.CurrentRow.Cells[2].Value.ToString();
            EditDay = dataGridViewLessons.CurrentRow.Cells[3].Value.ToString();
            EditLesson = dataGridViewLessons.CurrentRow.Cells[4].Value.ToString();
            EditStart = dataGridViewLessons.CurrentRow.Cells[5].Value.ToString();
            EditEnd = dataGridViewLessons.CurrentRow.Cells[6].Value.ToString();
            EditCabinet = dataGridViewLessons.CurrentRow.Cells[7].Value.ToString();
            EditGroup = dataGridViewLessons.CurrentRow.Cells[8].Value.ToString();
            EditTeacher = dataGridViewLessons.CurrentRow.Cells[9].Value.ToString();

            textBoxnumbweek.Text = dataGridViewLessons.CurrentRow.Cells[1].Value.ToString();
            textBoxEdittypeweek.Text = dataGridViewLessons.CurrentRow.Cells[2].Value.ToString();
            textBoxEDITDAY.Text = dataGridViewLessons.CurrentRow.Cells[3].Value.ToString();
            comboBoxEditsubject.Text = dataGridViewLessons.CurrentRow.Cells[4].Value.ToString();
            textBoxEditstarttime.Text = dataGridViewLessons.CurrentRow.Cells[5].Value.ToString();
            textBoxeditendtime.Text = dataGridViewLessons.CurrentRow.Cells[6].Value.ToString();
            textBoxEDITCAB.Text = dataGridViewLessons.CurrentRow.Cells[7].Value.ToString();
            comboBoxEDITGROUP.Text = dataGridViewLessons.CurrentRow.Cells[8].Value.ToString();
            comboBoxEDITEACH.Text = dataGridViewLessons.CurrentRow.Cells[9].Value.ToString();
            
        }

        private void VisiblebuttonDeleteLESS_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string select = dataGridViewLessons.CurrentRow.Cells[0].Value.ToString();
            //    DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (del == DialogResult.Yes)
            //    {
            //        string sql = @"SELECT id_lesson FROM semester WHERE id_lesson = '"+select+"'";
            //        MY_DB.msCommand.CommandText= sql;
            //        Object result = MY_DB.msCommand.ExecuteScalar();
            //        if (result != null)
            //        {
            //            MessageBox.Show("В таблице 'Семестр' данная запись используется", "Удаление невозможно");
            //        }
            //        else
            //        {
            //            LessonsControlClass.DeleteLesson(select);
            //            LessonsControlClass.getLessons();
            //            dataGridViewLessons.DataSource = LessonsControlClass.dtLessons;
            //            MessageBox.Show("Пара удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }    
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка при удалении");
            //}
        }
    }
}
