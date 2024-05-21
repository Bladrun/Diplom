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
using ComboBox = System.Windows.Forms.ComboBox;
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
                DataTable teachersTable = LoadDataTable("SELECT id_teacher, fio, does_work_or_not FROM teacher");
                DataTable groupsTable = LoadDataTable("SELECT id_group, short_number FROM students_groups");
                DataTable roomsTable = LoadDataTable("SELECT id_cabinet, numb_cab FROM cabinet");

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
                    HeaderText = "Преподаватель",
                    DataSource = teachersTable,
                    ValueMember = "id_teacher",
                    DisplayMember = "fio",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                // Handle the drawing of the ComboBox items and selection change
                dataGridViewLessons.EditingControlShowing += dataGridViewLessons_EditingControlShowing;

                DataGridViewComboBoxColumn groupComboBox = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "id_group", // column name in schedule_week
                    HeaderText = "Номер группы",
                    DataSource = groupsTable,
                    ValueMember = "id_group",
                    DisplayMember = "short_number",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                DataGridViewComboBoxColumn roomComboBox = new DataGridViewComboBoxColumn
                {
                    DataPropertyName = "id_cabinet", // column name in schedule_week
                    HeaderText = "Кабинет",
                    DataSource = roomsTable,
                    ValueMember = "id_cabinet",
                    DisplayMember = "numb_cab",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                };

                // Add ComboBox columns to DataGridView
                dataGridViewLessons.Columns.Add(subjectComboBox);
                dataGridViewLessons.Columns.Add(teacherComboBox);
                dataGridViewLessons.Columns.Add(groupComboBox);
                dataGridViewLessons.Columns.Add(roomComboBox);
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
            dataGridViewLessons.CellEndEdit += new DataGridViewCellEventHandler(dataGridViewLessons_CellEndEdit);
            toolTip1.SetToolTip(button3, "Нажмите, чтобы синхронизировать данные");
            toolTip4.SetToolTip(button1, "Нажмите, чтобы экспортировать данные в Excel-таблицу");
            toolTip5.SetToolTip(VisiblebuttonDeleteLESS, "Нажмите, чтобы удалить данные");
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

                // Применяем фильтр для точного соответствия
                dv.RowFilter = string.Format("numb_week = '{0}' OR chet_or_nechet = '{0}' OR day_of_the_week = '{0}'", searchText);
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

        private void dataGridViewLessons_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox comboBox)
            {
                // Check if the current cell is in the "Преподаватель" column
                if (dataGridViewLessons.CurrentCell.OwningColumn.HeaderText == "Преподаватель")
                {
                    comboBox.DrawMode = DrawMode.OwnerDrawFixed;
                    comboBox.DrawItem -= ComboBoxTeacher_DrawItem;
                    comboBox.DrawItem += ComboBoxTeacher_DrawItem;
                    comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                }
                else
                {
                    comboBox.DrawMode = DrawMode.Normal;
                    comboBox.DrawItem -= ComboBoxTeacher_DrawItem;
                    comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Check if the current cell is in the "Преподаватель" column
            if (dataGridViewLessons.CurrentCell?.OwningColumn?.HeaderText == "Преподаватель")
            {
                if (comboBox.SelectedItem is DataRowView selectedRow)
                {
                    bool isActive = Convert.ToBoolean(selectedRow["does_work_or_not"]);
                    if (!isActive)
                    {
                        MessageBox.Show("Этот преподаватель не работает и не может быть выбран.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        comboBox.SelectedIndex = -1; // Сбрасываем выбор
                    }
                }
            }
        }
        private void ComboBoxTeacher_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ComboBox comboBox = (ComboBox)sender;
            DataRowView row = (DataRowView)comboBox.Items[e.Index];
            string teacherName = row["fio"].ToString();
            bool isActive = Convert.ToBoolean(row["does_work_or_not"]);

            e.DrawBackground();

            // If teacher is inactive, draw in gray
            if (!isActive)
            {
                e.Graphics.DrawString(teacherName, e.Font, Brushes.Gray, e.Bounds);
            }
            else
            {
                e.Graphics.DrawString(teacherName, e.Font, Brushes.Black, e.Bounds);
            }

            e.DrawFocusRectangle();
        }
        private bool isConflictMessageShown = false;
        private void dataGridViewLessons_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (IsConflictInSchedule(e.RowIndex))
                {
                    if (!isConflictMessageShown)
                    {
                        // Если обнаружен конфликт, показываем сообщение и откатываем изменения
                        MessageBox.Show("Пара пересекается по времени с другой парой в этом кабинете", "Пересечение пар", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        isConflictMessageShown = true; // Устанавливаем флаг, чтобы не показывать сообщение снова
                        dataAdapter.Update(dataTable);
                        
                    }
                }
                else
                {
                    // Если конфликта нет, обновляем данные
                    dataAdapter.Update(dataTable);
                    isConflictMessageShown = false; // Сбрасываем флаг после успешного обновления данных
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isConflictMessageShown = false; // Сбрасываем флаг в случае ошибки
            }
        }

        private bool IsConflictInSchedule(int editedRowIndex)
        {
            // Получение данных строки, которая была изменена
            var editedRow = dataGridViewLessons.Rows[editedRowIndex];
            var editedRoom = editedRow.Cells["id_cabinet"].Value;
            var editedStartTime = editedRow.Cells["start_time"].Value;
            var editedEndTime = editedRow.Cells["end_time"].Value;

            // Проверка и приведение типов для времени
            if (!(editedStartTime is DateTime editedStartTimeDt) || !(editedEndTime is DateTime editedEndTimeDt))
            {
                // Если приведение невозможно, считаем, что конфликта нет, т.к. данные некорректны
                return false; // Или обработайте ситуацию другим способом, если необходимо
            }

            // Перебор всех строк в DataGridView для проверки конфликтов
            foreach (DataGridViewRow row in dataGridViewLessons.Rows)
            {
                if (row.Index == editedRowIndex) continue; // Пропустить текущую строку

                var room = row.Cells["id_cabinet"].Value;
                var startTime = row.Cells["start_time"].Value;
                var endTime = row.Cells["end_time"].Value;

                // Проверка и приведение типов для времени
                if (!(startTime is DateTime startTimeDt) || !(endTime is DateTime endTimeDt))
                {
                    continue; // Пропустить строки с некорректными данными
                }

                if (editedRoom.Equals(room) &&
                    ((editedStartTimeDt >= startTimeDt && editedStartTimeDt < endTimeDt) ||
                     (editedEndTimeDt > startTimeDt && editedEndTimeDt <= endTimeDt) ||
                     (editedStartTimeDt <= startTimeDt && editedEndTimeDt >= endTimeDt)))
                {
                    return true; // Обнаружен конфликт
                }
            }

            return false; // Конфликтов нет
        }


    }
}
