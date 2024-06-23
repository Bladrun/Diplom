using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace ScheduleForStudents.Controls
{
    public partial class CabinetControl : UserControl
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataTable dataTable;
        public CabinetControl()
        {
            InitializeComponent();
            InitializeDBConnection();
            LoadCabinets();
            dataGridViewCabs.CellEndEdit += dataGridViewCabs_CellEndEdit;
        }

        private void CabinetControl_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button3, "Нажмите, чтобы синхронизировать данные");
            toolTip2.SetToolTip(button1, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip3.SetToolTip(VisiblebuttonDeleteCAb, "Нажмите, чтобы удалить данные");
        }

        private void InitializeDBConnection()
        {
            DBManager dbManager = new DBManager();
            connection = dbManager.GetConnection();
            dataAdapter = new MySqlDataAdapter();
        }

        private void LoadCabinets()
        {
            string query = "SELECT * FROM cabinets";
            dataAdapter = new MySqlDataAdapter(query, connection);
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(dataAdapter);
            dataTable = new DataTable();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridViewCabs.DataSource = dataTable;
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

        private void dataGridViewCabs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
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

        private void VisiblebuttonDeleteCAb_Click(object sender, EventArgs e)
        {
            if (dataGridViewCabs.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить выбранный кабинет?", "Подтверждение удаления", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewCabs.SelectedRows[0];
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

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;
            for (i = 0; i <= dataGridViewCabs.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridViewCabs.ColumnCount - 1; j++)
                {
                    object cellValue = dataGridViewCabs[j, i].Value;
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

                // фильтр для точного соответствия
                dv.RowFilter = string.Format("numb_cab = '{0}'", searchText);
            }

            dataGridViewCabs.DataSource = dv;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadCabinets();
            MessageBox.Show("База данных синхронизирована");
        }

        private void dataGridViewCabs_RowValidated(object sender, DataGridViewCellEventArgs e)
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
