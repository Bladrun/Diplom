using Google.Protobuf.Reflection;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleForStudents.Controls
{
    public partial class SemesterControl : UserControl
    {
        public SemesterControl()
        {
            InitializeComponent();
            toolTip1.SetToolTip(buttonEDITSem, "Нажмите, чтобы сохранить изменения");
            toolTip2.SetToolTip(buttonCANSELEDITSem, "Нажмите, чтобы очистить изменения в полях");
            toolTip3.SetToolTip(buttonEditVissibleSemestr, "Нажмите, чтобы ввести изменения в таблицу");
            toolTip4.SetToolTip(button1, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip5.SetToolTip(VisiblebuttonDeleteSemestr, "Нажмите, чтобы удалить данные");
            toolTip6.SetToolTip(buttonAddSemester, "Нажмите, чтобы добавить данные в таблицу");
        }

        private void SemesterControl_Load(object sender, EventArgs e)
        {
            //MY_DB.ConnectionDB();
            //SemesterControlClass.getSemestrs();
            //dataGridViewSemester.DataSource = SemesterControlClass.dtSemestrs;
            LoadComboBoxEditLesson();
            LoadComboBoxEditGroup();
        }

        private void buttonAddSemester_Click(object sender, EventArgs e)
        {
            SemestrAdd formadd = new SemestrAdd();
            formadd.DataGridViewUpdated += UpdateDataGridViewOnMainForm;
            formadd.Show();
        }

        private void UpdateDataGridViewOnMainForm()
        {
            // Обновляем DataGridView на основной форме
            // Например:
            //dataGridViewSemester.DataSource = SemesterControlClass.dtSemestrs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;
            int i, j;
            for (i = 0; i <= dataGridViewSemester.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridViewSemester.ColumnCount - 1; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridViewSemester[j, i].Value.ToString();
                }
            }



            exApp.Visible = true;
        }

        private void LoadComboBoxEditLesson()
        {
            //LessonsControlClass.getLessons();

            //comboBoxEditLesson.DataSource = LessonsControlClass.dtLessons;
            //comboBoxEditLesson.DisplayMember = "numb_week";
            //comboBoxEditLesson.ValueMember = "id_lesson";
        }

        private void LoadComboBoxEditGroup()
        {
            //GroupsControlCLass.getGroups();

            //comboBoxEditGroup.DataSource = GroupsControlCLass.dtGroups;
            //comboBoxEditGroup.DisplayMember = "short_number";
            //comboBoxEditGroup.ValueMember = "id_group";
        }
        static public string Editid, EditNumbSem, EditYear, EditIdGroup, EditIdLesson;

        private void VisiblebuttonDeleteSemestr_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string select = dataGridViewSemester.CurrentRow.Cells[0].Value.ToString();
            //    DialogResult del = MessageBox.Show("Вы действительно хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (del == DialogResult.Yes)
            //    {
            //        SemesterControlClass.DeleteSemester(select);
            //        SemesterControlClass.getSemestrs();
            //        dataGridViewSemester.DataSource = SemesterControlClass.dtSemestrs;
            //        MessageBox.Show("Пара удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка при удалении");
            //}
        }

        private void buttonEditVissibleSemestr_Click(object sender, EventArgs e)
        {
            Editid = dataGridViewSemester.CurrentRow.Cells[0].Value.ToString();
            EditNumbSem = dataGridViewSemester.CurrentRow.Cells[1].Value.ToString();
            EditYear = dataGridViewSemester.CurrentRow.Cells[2].Value.ToString();
            EditIdGroup = dataGridViewSemester.CurrentRow.Cells[3].Value.ToString();
            EditIdLesson = dataGridViewSemester.CurrentRow.Cells[4].Value.ToString();

            textBoxNumbSemest.Text = dataGridViewSemester.CurrentRow.Cells[1].Value.ToString();
            textBoxYearSemest.Text = dataGridViewSemester.CurrentRow.Cells[2].Value.ToString();
            comboBoxEditGroup.Text = dataGridViewSemester.CurrentRow.Cells[3].Value.ToString();
            comboBoxEditLesson.Text = dataGridViewSemester.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    // Вызов метода для получения данных из вашего класса
            //    SemesterControlClass.getSemestrs();

            //    // Создание DataView из DataTable вашего класса
            //    DataView dv = new DataView(SemesterControlClass.dtSemestrs);

            //    // Применение фильтра к DataView
            //    dv.RowFilter = string.Format("semester_number LIKE '%{0}%' OR year LIKE '%{0}%' OR numb_week LIKE '%{0}%' OR short_number LIKE '%{0}%'", textBoxSearch.Text);

            //    // Установка нового источника данных для DataGridView
            //    dataGridViewSemester.DataSource = dv;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void buttonCANSELEDITSem_Click(object sender, EventArgs e)
        {
            textBoxNumbSemest.Text = "";
            textBoxYearSemest.Text = "";
        }

        private void buttonEDITSem_Click(object sender, EventArgs e)
        {
            //if (textBoxNumbSemest.Text == EditNumbSem && textBoxYearSemest.Text == EditYear && comboBoxEditGroup.Text == EditIdGroup && comboBoxEditLesson.Text ==  EditIdLesson)
            //{
            //    if (textBoxNumbSemest.Text != "" && textBoxYearSemest.Text != "" && comboBoxEditGroup.Text != "" && comboBoxEditLesson.Text != "")
            //    {
            //        string q1 = comboBoxEditLesson.SelectedValue.ToString();
            //        int id_lesson = int.Parse(q1);

            //        string q2 = comboBoxEditGroup.SelectedValue.ToString();
            //        int id_group = int.Parse(q2);


            //        if (SemesterControlClass.EditSemester(int.Parse(Editid), textBoxNumbSemest.Text, textBoxYearSemest.Text, id_group, id_lesson))
            //        {
            //            MessageBox.Show("Редактирование успешно", "Редактирование завершено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //            SemesterControlClass.getSemestrs();
            //            textBoxNumbSemest.Text = "";
            //            textBoxYearSemest.Text = "";
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
            //    string sql = @"SELECT id_semester FROM semester WHERE semester_number = '"+textBoxNumbSemest.Text+"' AND year = '"+textBoxYearSemest.Text+"' AND id_group = '"+comboBoxEditGroup.Text+"' AND id_lesson = '"+comboBoxEditLesson.Text+"'";
            //    //MY_DB.msCommand.CommandText = sql;
            //    //Object result = MY_DB.msCommand.ExecuteScalar();
            //    //if (result == null)
            //    //{
            //    //    if (textBoxNumbSemest.Text != "" && textBoxYearSemest.Text != "" && comboBoxEditGroup.Text != "" && comboBoxEditLesson.Text != "")
            //    //    {
            //    //        string q1 = comboBoxEditLesson.SelectedValue.ToString();
            //    //        int id_lesson = int.Parse(q1);

            //    //        string q2 = comboBoxEditGroup.SelectedValue.ToString();
            //    //        int id_group = int.Parse(q2);

            //    //        if (SemesterControlClass.EditSemester(int.Parse(Editid), textBoxNumbSemest.Text, textBoxYearSemest.Text, id_group, id_lesson))
            //    //        {
            //    //            MessageBox.Show("Редактирование успешно", "Редактирование завершено", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //            SemesterControlClass.getSemestrs();
            //    //            textBoxNumbSemest.Text = "";
            //    //            textBoxYearSemest.Text = "";
            //    //        }
            //    //        else
            //    //        {
            //    //            MessageBox.Show("Ошибка при редактировании записи");
            //    //        }

            //    //    }
            //    //    else
            //    //    {
            //    //        MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }
            //    //}
            //}
        }
    }
}
