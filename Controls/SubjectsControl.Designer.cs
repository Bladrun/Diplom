namespace ScheduleForStudents.Controls
{
    partial class SubjectsControl
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
            this.dataGridViewSubjects = new System.Windows.Forms.DataGridView();
            this.id_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_of_the_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours_of_lectures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours_of_practicals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count_of_laboratories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours_of_conlsultaions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_of_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VisiblebuttonDeleteSubject = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1578, 51);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1578, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "ИЗМЕНЕНИЕ ПРЕДМЕТОВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewSubjects
            // 
            this.dataGridViewSubjects.AllowUserToDeleteRows = false;
            this.dataGridViewSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_subject,
            this.name_of_the_subject,
            this.hours_of_lectures,
            this.hours_of_practicals,
            this.count_of_laboratories,
            this.hours_of_conlsultaions,
            this.total_of_hours});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubjects.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSubjects.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewSubjects.Name = "dataGridViewSubjects";
            this.dataGridViewSubjects.RowHeadersVisible = false;
            this.dataGridViewSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubjects.Size = new System.Drawing.Size(1578, 693);
            this.dataGridViewSubjects.TabIndex = 8;
            this.dataGridViewSubjects.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubjects_CellEndEdit);
            this.dataGridViewSubjects.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubjects_RowValidated);
            // 
            // id_subject
            // 
            this.id_subject.DataPropertyName = "id_subject";
            this.id_subject.HeaderText = "id_subject";
            this.id_subject.Name = "id_subject";
            this.id_subject.Visible = false;
            // 
            // name_of_the_subject
            // 
            this.name_of_the_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_of_the_subject.DataPropertyName = "name_of_the_subject";
            this.name_of_the_subject.HeaderText = "Наименование предмета";
            this.name_of_the_subject.Name = "name_of_the_subject";
            // 
            // hours_of_lectures
            // 
            this.hours_of_lectures.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hours_of_lectures.DataPropertyName = "hours_of_lectures";
            this.hours_of_lectures.HeaderText = "Количество часов лекций";
            this.hours_of_lectures.Name = "hours_of_lectures";
            // 
            // hours_of_practicals
            // 
            this.hours_of_practicals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hours_of_practicals.DataPropertyName = "hours_of_practicals";
            this.hours_of_practicals.HeaderText = "Количество часов практик";
            this.hours_of_practicals.Name = "hours_of_practicals";
            // 
            // count_of_laboratories
            // 
            this.count_of_laboratories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count_of_laboratories.DataPropertyName = "count_of_laboratories";
            this.count_of_laboratories.HeaderText = "Количество лабораторных работ";
            this.count_of_laboratories.Name = "count_of_laboratories";
            // 
            // hours_of_conlsultaions
            // 
            this.hours_of_conlsultaions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hours_of_conlsultaions.DataPropertyName = "hours_of_conlsultaions";
            this.hours_of_conlsultaions.HeaderText = "Количество часов консультаций";
            this.hours_of_conlsultaions.Name = "hours_of_conlsultaions";
            // 
            // total_of_hours
            // 
            this.total_of_hours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_of_hours.DataPropertyName = "total_of_hours";
            this.total_of_hours.HeaderText = "Итоговое количество часов";
            this.total_of_hours.Name = "total_of_hours";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.VisiblebuttonDeleteSubject);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1577, 44);
            this.flowLayoutPanel1.TabIndex = 33;
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
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ScheduleForStudents.Properties.Resources.file;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(293, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ScheduleForStudents.Properties.Resources.sync;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(335, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 36);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisiblebuttonDeleteSubject
            // 
            this.VisiblebuttonDeleteSubject.AutoSize = true;
            this.VisiblebuttonDeleteSubject.BackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteSubject.BackgroundImage = global::ScheduleForStudents.Properties.Resources.bin;
            this.VisiblebuttonDeleteSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblebuttonDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisiblebuttonDeleteSubject.FlatAppearance.BorderSize = 0;
            this.VisiblebuttonDeleteSubject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisiblebuttonDeleteSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisiblebuttonDeleteSubject.Location = new System.Drawing.Point(379, 4);
            this.VisiblebuttonDeleteSubject.Margin = new System.Windows.Forms.Padding(4);
            this.VisiblebuttonDeleteSubject.Name = "VisiblebuttonDeleteSubject";
            this.VisiblebuttonDeleteSubject.Size = new System.Drawing.Size(29, 32);
            this.VisiblebuttonDeleteSubject.TabIndex = 21;
            this.VisiblebuttonDeleteSubject.UseVisualStyleBackColor = false;
            this.VisiblebuttonDeleteSubject.Click += new System.EventHandler(this.VisiblebuttonDeleteSubject_Click);
            // 
            // SubjectsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewSubjects);
            this.Controls.Add(this.panel1);
            this.Name = "SubjectsControl";
            this.Size = new System.Drawing.Size(1578, 791);
            this.Load += new System.EventHandler(this.SubjectsControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjects)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button VisiblebuttonDeleteSubject;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_of_the_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours_of_lectures;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours_of_practicals;
        private System.Windows.Forms.DataGridViewTextBoxColumn count_of_laboratories;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours_of_conlsultaions;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_of_hours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSubjects;
    }
}
