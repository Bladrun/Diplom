using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleForStudents.Controls
{
    public partial class TeachersControl : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public TeachersControl()
        {
            InitializeComponent();
            InitializeDBConnection();
            LoadTeachers();
            dataGridViewTeachers.CellEndEdit += new DataGridViewCellEventHandler(dataGridViewTeachers_CellEndEdit);
        }

        private void TeachersControl_Load(object sender, EventArgs e)
        {
            
            //dataGridViewTeachers.CellEndEdit += dataGridViewTeachers_CellEndEdit;
            toolTip1.SetToolTip(button1, "Нажмите, чтобы синхронизировать данные");
            toolTip4.SetToolTip(button3, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip5.SetToolTip(VisiblebuttonDeleteTeach, "Нажмите, чтобы удалить данные");
        }
        private void InitializeDBConnection()
        {
            DBManager dbManager = new DBManager();
            connection = dbManager.GetConnection();
            dataAdapter = new MySqlDataAdapter();
        }

        private void LoadData()
        {
            string query = "SELECT * FROM teacher";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();
            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewTeachers.DataSource = dataTable;
                
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

        private void LoadTeachers()
        {
            string query = "SELECT * FROM teacher";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewTeachers.DataSource = dataTable;
                AddCheckBoxColumn();
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

        private void AddCheckBoxColumn()
        {
            if (dataGridViewTeachers.Columns["Status"] == null)
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "does_work_or_not",
                    HeaderText = "Статус работы",
                    DataPropertyName = "does_work_or_not", // column name in database
                    TrueValue = true,
                    FalseValue = false,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };
                checkBoxColumn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewTeachers.Columns.Add(checkBoxColumn);
            }
        }

        private void dataGridViewTeachers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTeachers.Columns[e.ColumnIndex].Name == "does_work_or_not")
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

        private void VisiblebuttonDeleteTeach_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранного преподавателя?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewTeachers.SelectedRows[0];
                    int rowIndex = selectedRow.Index;
                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    DataRow selectedRowData = selectedRowView.Row;
                    int id_teacher = Convert.ToInt32(selectedRowData["id_teacher"]);

                    // Проверяем, используется ли учитель в таблице Расписание
                    string checkQuery = "SELECT COUNT(*) FROM schedule_week WHERE id_teacher = @id_teacher";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@id_teacher", id_teacher);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Нельзя удалить преподавателя, так как он используется в таблице 'Расписание'.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при проверке использования преподавателя: " + ex.Message);
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

        

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewTeachers.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridViewTeachers.ColumnCount - 1; j++)
                {
                    object cellValue = dataGridViewTeachers[j, i].Value;
                    wsh.Cells[i + 1, j + 1] = cellValue != null ? cellValue.ToString() : ""; // Проверяем на null перед вызовом ToString()
                }
            }

            exApp.Visible = true;
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
                dv.RowFilter = string.Format("fio = '{0}'", searchText);
            }

            dataGridViewTeachers.DataSource = dv;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("База данных синхронизирована");
        }

        private void dataGridViewTeachers_RowValidated(object sender, DataGridViewCellEventArgs e)
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
