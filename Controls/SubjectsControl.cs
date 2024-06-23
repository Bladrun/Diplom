using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleForStudents.Controls
{
    public partial class SubjectsControl : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public SubjectsControl()
        {
            InitializeComponent();
            InitializeDBConnection();
            LoadSubjects();
        }

        private void SubjectsControl_Load(object sender, EventArgs e)
        {
            dataGridViewSubjects.CellEndEdit += dataGridViewSubjects_CellEndEdit;
            toolTip1.SetToolTip(button1, "Нажмите, чтобы синхронизировать данные");
            toolTip5.SetToolTip(button3, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip6.SetToolTip(VisiblebuttonDeleteSubject, "Нажмите, чтобы удалить данные");
        }
        private void InitializeDBConnection()
        {
            DBManager dbManager = new DBManager();
            connection = dbManager.GetConnection();
            dataAdapter = new MySqlDataAdapter();
        }

        private void LoadSubjects()
        {
            string query = "SELECT * FROM subjects";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewSubjects.DataSource = dataTable;
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
                dv.RowFilter = string.Format("name_of_the_subject = '{0}'", searchText);
            }

            dataGridViewSubjects.DataSource = dv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewSubjects.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridViewSubjects.ColumnCount - 1; j++)
                {
                    object cellValue = dataGridViewSubjects[j, i].Value;
                    wsh.Cells[i + 1, j + 1] = cellValue != null ? cellValue.ToString() : ""; // Проверяем на null перед вызовом ToString()
                }
            }

            exApp.Visible = true;
        }

        private void dataGridViewSubjects_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSubjects();
            MessageBox.Show("База данных синхронизирована");
        }

        private void dataGridViewSubjects_RowValidated(object sender, DataGridViewCellEventArgs e)
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

        private void VisiblebuttonDeleteSubject_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранный предмет?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewSubjects.SelectedRows[0];
                    int rowIndex = selectedRow.Index;
                    DataRowView selectedRowView = selectedRow.DataBoundItem as DataRowView;
                    DataRow selectedRowData = selectedRowView.Row;
                    int id_subject = Convert.ToInt32(selectedRowData["id_subject"]);

                    // Проверяем, используется ли предмеи в таблице Расписание
                    string checkQuery = "SELECT COUNT(*) FROM schedule_week WHERE id_subject = @id_subject";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@id_subject", id_subject);

                    try
                    {
                        connection.Open();
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Нельзя удалить предмет, так как он используется в таблице 'Расписание'.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при проверке использования предмета: " + ex.Message);
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
    }
}
