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
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleForStudents.Controls
{
    public partial class LessonsControl : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public LessonsControl()
        {
            InitializeComponent();
            InitializeDBConnection();
            LoadLessons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <=  dataGridViewLessons.RowCount - 1; i++)
            {
                for (j = 0; j <=  dataGridViewLessons.ColumnCount - 1; j++)
                {
                    object cellValue = dataGridViewLessons[j, i].Value;
                    wsh.Cells[i + 1, j + 1] = cellValue != null ? cellValue.ToString() : ""; // Проверяем на null перед вызовом ToString()
                }
            }

            exApp.Visible = true;
        }

        private void InitializeDBConnection()
        {
            DBManager dbManager = new DBManager();
            connection = dbManager.GetConnection();
            dataAdapter = new MySqlDataAdapter();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM schedule_week";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();
            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewLessons.DataSource = dataTable;
                //AddComboBoxColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        
        private void LoadLessons()
        {
            string query = "SELECT * FROM schedule_week";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewLessons.DataSource = dataTable;
                AddComboBoxColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddComboBoxColumns()
        {
            

            if (dataGridViewLessons.Columns["Subject"] == null)
            {
                // Load data for ComboBoxes
                DataTable subjectsTable = LoadDataTable("SELECT id_subject, name_of_the_subject FROM subjects");
                DataTable teachersTable = LoadDataTable("SELECT id_teacher, fio FROM teacher");
                DataTable groupsTable = LoadDataTable("SELECT id_group, short_number FROM students_groups");

                // Create and configure Subject ComboBox column
                DataGridViewComboBoxColumn subjectComboBox = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "id_subject", // column name in schedule_week
                    HeaderText = "Наименование предмета",
                    DataSource = subjectsTable,
                    ValueMember = "id_subject",
                    DisplayMember = "name_of_the_subject",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                // Create and configure Teacher ComboBox column
                DataGridViewComboBoxColumn teacherComboBox = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "id_teacher", // column name in schedule_week
                    HeaderText = "Преподавателя",
                    DataSource = teachersTable,
                    ValueMember = "id_teacher",
                    DisplayMember = "fio",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                DataGridViewComboBoxColumn groupComboBox = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "id_group", // column name in schedule_week
                    HeaderText = "Номер группы",
                    DataSource = groupsTable,
                    ValueMember = "id_group",
                    DisplayMember = "short_number",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                // Add ComboBox columns to DataGridView
                dataGridViewLessons.Columns.Add(subjectComboBox);
                dataGridViewLessons.Columns.Add(teacherComboBox);
                dataGridViewLessons.Columns.Add(groupComboBox);
            }
        }

        private DataTable LoadDataTable(string query)
        {
            DataTable table = new DataTable();
            try
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            return table;
        }

        private void LessonsControl_Load(object sender, EventArgs e)
        {
            dataGridViewLessons.CellEndEdit += dataGridViewLessons_CellEndEdit;
            toolTip1.SetToolTip(button3, "Нажмите, чтобы синхронизировать данные");
            toolTip4.SetToolTip(button1, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip5.SetToolTip(VisiblebuttonDeleteLESS, "Нажмите, чтобы удалить данные");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("База данных синхронизирована");
        }

        private void dataGridViewLessons_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataAdapter.Update(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();

            DataView dv = dataTable.DefaultView;

            if (string.IsNullOrEmpty(searchText))
            {
                // Сбрасываем фильтр, если строка поиска пуста
                dv.RowFilter = string.Empty;
            }
            else
            {
                // Экранирование специальных символов для строки поиска
                searchText = searchText.Replace("[", "[[]")
                                       .Replace("%", "[%]")
                                       .Replace("_", "[_]")
                                       .Replace("'", "''");

                // Применяем фильтр для точного соответствия
                dv.RowFilter = string.Format("numb_week = '{0}' OR chet_or_nechet = '{0}' OR day_of_the_week = '{0}' OR cabinet = '{0}'", searchText);
            }

            dataGridViewLessons.DataSource = dv;
        }

        

        private void VisiblebuttonDeleteLESS_Click(object sender, EventArgs e)
        {
            if (dataGridViewLessons.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранную пару?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewLessons.SelectedRows[0];
                    int rowIndex = selectedRow.Index;
                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    DataRow selectedRowData = selectedRowView.Row;
                    int id_lesson = Convert.ToInt32(selectedRowData["id_lesson"]);

                    // Проверяем, используется ли учитель в таблице Расписание
                    string checkQuery = "SELECT COUNT(*) FROM semester WHERE id_lesson = @id_lesson";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@id_lesson", id_lesson);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Нельзя удалить пару, так как она используется в таблице 'Семестр'.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при проверке использования пары: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }


                    selectedRowData.Delete();

                    try
                    {
                        dataAdapter.Update(dataTable);
                        MessageBox.Show("Запись успешно удалена.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка удаления записи: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для удаления.");
            }
        }

        private void dataGridViewLessons_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataAdapter.Update(dataTable);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
