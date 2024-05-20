namespace ScheduleForStudents.Controls
{
    partial class SemesterControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSemester = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VisiblebuttonDeleteSemestr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.id_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_lesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemester)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1661, 51);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1661, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "ИЗМЕНЕНИЕ СЕМЕСТРА";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewSemester
            // 
            this.dataGridViewSemester.AllowUserToDeleteRows = false;
            this.dataGridViewSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSemester.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSemester.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSemester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSemester.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_semester,
            this.semester_number,
            this.year,
            this.id_group,
            this.id_lesson});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSemester.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSemester.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewSemester.Name = "dataGridViewSemester";
            this.dataGridViewSemester.RowHeadersVisible = false;
            this.dataGridViewSemester.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSemester.Size = new System.Drawing.Size(1661, 693);
            this.dataGridViewSemester.TabIndex = 7;
            this.dataGridViewSemester.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSemester_CellEndEdit);
            this.dataGridViewSemester.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSemester_RowValidated);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.VisiblebuttonDeleteSemestr);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1660, 44);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ScheduleForStudents.Properties.Resources.search;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.Location = new System.Drawing.Point(41, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(245, 32);
            this.textBoxSearch.TabIndex = 27;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ScheduleForStudents.Properties.Resources.file;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(293, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ScheduleForStudents.Properties.Resources.sync;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(335, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 36);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VisiblebuttonDeleteSemestr
            // 
            this.VisiblebuttonDeleteSemestr.AutoSize = true;
            this.VisiblebuttonDeleteSemestr.BackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteSemestr.BackgroundImage = global::ScheduleForStudents.Properties.Resources.bin;
            this.VisiblebuttonDeleteSemestr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblebuttonDeleteSemestr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisiblebuttonDeleteSemestr.FlatAppearance.BorderSize = 0;
            this.VisiblebuttonDeleteSemestr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteSemestr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteSemestr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisiblebuttonDeleteSemestr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisiblebuttonDeleteSemestr.Location = new System.Drawing.Point(379, 4);
            this.VisiblebuttonDeleteSemestr.Margin = new System.Windows.Forms.Padding(4);
            this.VisiblebuttonDeleteSemestr.Name = "VisiblebuttonDeleteSemestr";
            this.VisiblebuttonDeleteSemestr.Size = new System.Drawing.Size(29, 32);
            this.VisiblebuttonDeleteSemestr.TabIndex = 21;
            this.VisiblebuttonDeleteSemestr.UseVisualStyleBackColor = false;
            this.VisiblebuttonDeleteSemestr.Click += new System.EventHandler(this.VisiblebuttonDeleteSemestr_Click);
            // 
            // id_semester
            // 
            this.id_semester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_semester.DataPropertyName = "id_semester";
            this.id_semester.HeaderText = "id_semester";
            this.id_semester.Name = "id_semester";
            this.id_semester.Visible = false;
            // 
            // semester_number
            // 
            this.semester_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.semester_number.DataPropertyName = "semester_number";
            this.semester_number.HeaderText = "Номер семестра";
            this.semester_number.Name = "semester_number";
            this.semester_number.Width = 170;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            // 
            // id_group
            // 
            this.id_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_group.DataPropertyName = "id_group";
            this.id_group.HeaderText = "id_group";
            this.id_group.Name = "id_group";
            this.id_group.Visible = false;
            // 
            // id_lesson
            // 
            this.id_lesson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_lesson.DataPropertyName = "id_lesson";
            this.id_lesson.HeaderText = "id_lesson";
            this.id_lesson.Name = "id_lesson";
            this.id_lesson.Visible = false;
            // 
            // SemesterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewSemester);
            this.Controls.Add(this.panel1);
            this.Name = "SemesterControl";
            this.Size = new System.Drawing.Size(1661, 791);
            this.Load += new System.EventHandler(this.SemesterControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemester)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewSemester;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VisiblebuttonDeleteSemestr;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lesson;
    }
}
