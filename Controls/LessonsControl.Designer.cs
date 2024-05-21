namespace ScheduleForStudents.Controls
{
    partial class LessonsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLessons = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VisiblebuttonDeleteLESS = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.id_lesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numb_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet_or_nechet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_of_the_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1661, 51);
            this.panel1.TabIndex = 7;
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
            this.label1.Text = "ИЗМЕНЕНИЕ ПАР";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLessons
            // 
            this.dataGridViewLessons.AllowUserToDeleteRows = false;
            this.dataGridViewLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLessons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lesson,
            this.numb_week,
            this.chet_or_nechet,
            this.day_of_the_week,
            this.id_subject,
            this.start_time,
            this.end_time,
            this.id_cabinet,
            this.id_group,
            this.id_teacher});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLessons.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLessons.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewLessons.Name = "dataGridViewLessons";
            this.dataGridViewLessons.RowHeadersVisible = false;
            this.dataGridViewLessons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLessons.Size = new System.Drawing.Size(1661, 693);
            this.dataGridViewLessons.TabIndex = 8;
            this.dataGridViewLessons.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLessons_CellEndEdit);
            this.dataGridViewLessons.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewLessons_EditingControlShowing);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.VisiblebuttonDeleteLESS);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1660, 44);
            this.flowLayoutPanel1.TabIndex = 31;
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
            this.button3.TabIndex = 30;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VisiblebuttonDeleteLESS
            // 
            this.VisiblebuttonDeleteLESS.AutoSize = true;
            this.VisiblebuttonDeleteLESS.BackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteLESS.BackgroundImage = global::ScheduleForStudents.Properties.Resources.bin;
            this.VisiblebuttonDeleteLESS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblebuttonDeleteLESS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisiblebuttonDeleteLESS.FlatAppearance.BorderSize = 0;
            this.VisiblebuttonDeleteLESS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteLESS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteLESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisiblebuttonDeleteLESS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisiblebuttonDeleteLESS.Location = new System.Drawing.Point(379, 4);
            this.VisiblebuttonDeleteLESS.Margin = new System.Windows.Forms.Padding(4);
            this.VisiblebuttonDeleteLESS.Name = "VisiblebuttonDeleteLESS";
            this.VisiblebuttonDeleteLESS.Size = new System.Drawing.Size(29, 32);
            this.VisiblebuttonDeleteLESS.TabIndex = 21;
            this.VisiblebuttonDeleteLESS.UseVisualStyleBackColor = false;
            this.VisiblebuttonDeleteLESS.Click += new System.EventHandler(this.VisiblebuttonDeleteLESS_Click);
            // 
            // id_lesson
            // 
            this.id_lesson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_lesson.DataPropertyName = "id_lesson";
            this.id_lesson.HeaderText = "id_lesson";
            this.id_lesson.Name = "id_lesson";
            this.id_lesson.Visible = false;
            // 
            // numb_week
            // 
            this.numb_week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numb_week.DataPropertyName = "numb_week";
            this.numb_week.HeaderText = "Номер недели";
            this.numb_week.Name = "numb_week";
            // 
            // chet_or_nechet
            // 
            this.chet_or_nechet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chet_or_nechet.DataPropertyName = "chet_or_nechet";
            this.chet_or_nechet.HeaderText = "Четная/Нечетная";
            this.chet_or_nechet.Name = "chet_or_nechet";
            // 
            // day_of_the_week
            // 
            this.day_of_the_week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.day_of_the_week.DataPropertyName = "day_of_the_week";
            this.day_of_the_week.HeaderText = "День недели";
            this.day_of_the_week.Name = "day_of_the_week";
            // 
            // id_subject
            // 
            this.id_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_subject.DataPropertyName = "id_subject";
            this.id_subject.HeaderText = "id_subject";
            this.id_subject.Name = "id_subject";
            this.id_subject.Visible = false;
            // 
            // start_time
            // 
            this.start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_time.DataPropertyName = "start_time";
            this.start_time.HeaderText = "Время начала";
            this.start_time.Name = "start_time";
            // 
            // end_time
            // 
            this.end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_time.DataPropertyName = "end_time";
            this.end_time.HeaderText = "Время окончания";
            this.end_time.Name = "end_time";
            // 
            // id_cabinet
            // 
            this.id_cabinet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_cabinet.DataPropertyName = "id_cabinet";
            this.id_cabinet.HeaderText = "id_cabinet";
            this.id_cabinet.Name = "id_cabinet";
            this.id_cabinet.Visible = false;
            // 
            // id_group
            // 
            this.id_group.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_group.DataPropertyName = "id_group";
            this.id_group.HeaderText = "id_group";
            this.id_group.Name = "id_group";
            this.id_group.Visible = false;
            // 
            // id_teacher
            // 
            this.id_teacher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_teacher.DataPropertyName = "id_teacher";
            this.id_teacher.HeaderText = "id_teacher";
            this.id_teacher.Name = "id_teacher";
            this.id_teacher.Visible = false;
            // 
            // LessonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewLessons);
            this.Controls.Add(this.panel1);
            this.Name = "LessonsControl";
            this.Size = new System.Drawing.Size(1661, 791);
            this.Load += new System.EventHandler(this.LessonsControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VisiblebuttonDeleteLESS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridViewLessons;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn numb_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet_or_nechet;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_of_the_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_teacher;
    }
}
