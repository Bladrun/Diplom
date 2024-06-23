using Google.Protobuf.Reflection;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleForStudents.Controls
{
    public partial class SemesterControl : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public SemesterControl()
        {
            InitializeComponent();
            InitializeDBConnection();
            LoadSemester();
        }

        private void SemesterControl_Load(object sender, EventArgs e)
        {
            dataGridViewSemester.CellEndEdit += dataGridViewSemester_CellEndEdit;
            toolTip1.SetToolTip(button3, "Нажмите, чтобы синхронизировать данные");
            toolTip4.SetToolTip(button1, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip5.SetToolTip(VisiblebuttonDeleteSemestr, "Нажмите, чтобы удалить данные");
        }

        private void InitializeDBConnection()
        {
            DBManager dbManager = new DBManager();
            connection = dbManager.GetConnection();
            dataAdapter = new MySqlDataAdapter();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM semester";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();
            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewSemester.DataSource = dataTable;
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

        private void LoadSemester()
        {
            string query = "SELECT * FROM semester";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewSemester.DataSource = dataTable;
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


            if (dataGridViewSemester.Columns["Subject"] == null)
            {
                // Загружаем данные в комбобоксы
                DataTable weekTable = LoadDataTable("SELECT id_lesson, numb_week FROM schedule_week");
                DataTable groupsTable = LoadDataTable("SELECT id_group, short_number FROM students_groups");

                // Создаем и конфигурируем колонку с комбобоксом
                DataGridViewComboBoxColumn weekComboBox = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "id_lesson", // название колонки в таблице
                    HeaderText = "Номер недели",
                    DataSource = weekTable,
                    ValueMember = "id_lesson",
                    DisplayMember = "numb_week",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                // Создаем и конфигурируем колонку с комбобоксом
                DataGridViewComboBoxColumn groupComboBox = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "id_group", // название колонки в таблице
                    HeaderText = "Номер группы",
                    DataSource = groupsTable,
                    ValueMember = "id_group",
                    DisplayMember = "short_number",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                // Добавляем комбобоксы на датагрид
                dataGridViewSemester.Columns.Add(weekComboBox);
                dataGridViewSemester.Columns.Add(groupComboBox);
            }
        }

        private DataTable LoadDataTable(string query) ///Грузим данные в таблицу
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

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <=  dataGridViewSemester.RowCount - 1; i++)
            {
                for (j = 0; j <=  dataGridViewSemester.ColumnCount - 1; j++)
                {
                    object cellValue = dataGridViewSemester[j, i].Value;
                    wsh.Cells[i + 1, j + 1] = cellValue != null ? cellValue.ToString() : ""; // Проверяем на null перед вызовом ToString()
                }
            }

            exApp.Visible = true;
        }


        private void VisiblebuttonDeleteSemestr_Click(object sender, EventArgs e)
        {
            if (dataGridViewSemester.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранный семестр?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewSemester.SelectedRows[0];
                    int rowIndex = selectedRow.Index;
                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    DataRow selectedRowData = selectedRowView.Row;


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

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("База данных синхронизирована");
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

                // фильтр для точного соответствия
                dv.RowFilter = string.Format("semester_number = '{0}' OR year = '{0}'", searchText);
            }

            dataGridViewSemester.DataSource = dv;
        }

        private void dataGridViewSemester_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

        private void dataGridViewSemester_RowValidated(object sender, DataGridViewCellEventArgs e)
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
