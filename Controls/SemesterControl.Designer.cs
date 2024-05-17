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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemesterControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSemester = new System.Windows.Forms.DataGridView();
            this.id_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.short_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numb_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonEditVissibleSemestr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VisiblebuttonDeleteSemestr = new System.Windows.Forms.Button();
            this.buttonAddSemester = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEditGroup = new System.Windows.Forms.ComboBox();
            this.textBoxNumbSemest = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonEDITSem = new System.Windows.Forms.Button();
            this.buttonCANSELEDITSem = new System.Windows.Forms.Button();
            this.comboBoxEditLesson = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxYearSemest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSemester)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.dataGridViewSemester.AllowUserToAddRows = false;
            this.dataGridViewSemester.AllowUserToDeleteRows = false;
            this.dataGridViewSemester.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.short_number,
            this.numb_week});
            this.dataGridViewSemester.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewSemester.Name = "dataGridViewSemester";
            this.dataGridViewSemester.ReadOnly = true;
            this.dataGridViewSemester.RowHeadersVisible = false;
            this.dataGridViewSemester.Size = new System.Drawing.Size(1661, 456);
            this.dataGridViewSemester.TabIndex = 7;
            // 
            // id_semester
            // 
            this.id_semester.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_semester.DataPropertyName = "id_semester";
            this.id_semester.HeaderText = "id_semester";
            this.id_semester.Name = "id_semester";
            this.id_semester.ReadOnly = true;
            this.id_semester.Visible = false;
            // 
            // semester_number
            // 
            this.semester_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.semester_number.DataPropertyName = "semester_number";
            this.semester_number.HeaderText = "Номер семестра";
            this.semester_number.Name = "semester_number";
            this.semester_number.ReadOnly = true;
            this.semester_number.Width = 137;
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.DataPropertyName = "year";
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // short_number
            // 
            this.short_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.short_number.DataPropertyName = "short_number";
            this.short_number.HeaderText = "Группа студентов";
            this.short_number.Name = "short_number";
            this.short_number.ReadOnly = true;
            // 
            // numb_week
            // 
            this.numb_week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numb_week.DataPropertyName = "numb_week";
            this.numb_week.HeaderText = "Номер недели";
            this.numb_week.Name = "numb_week";
            this.numb_week.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.buttonEditVissibleSemestr);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.VisiblebuttonDeleteSemestr);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddSemester);
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
            // buttonEditVissibleSemestr
            // 
            this.buttonEditVissibleSemestr.AutoSize = true;
            this.buttonEditVissibleSemestr.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditVissibleSemestr.BackgroundImage = global::ScheduleForStudents.Properties.Resources.edit;
            this.buttonEditVissibleSemestr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditVissibleSemestr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditVissibleSemestr.FlatAppearance.BorderSize = 0;
            this.buttonEditVissibleSemestr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEditVissibleSemestr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEditVissibleSemestr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditVissibleSemestr.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditVissibleSemestr.Location = new System.Drawing.Point(293, 4);
            this.buttonEditVissibleSemestr.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditVissibleSemestr.Name = "buttonEditVissibleSemestr";
            this.buttonEditVissibleSemestr.Size = new System.Drawing.Size(32, 33);
            this.buttonEditVissibleSemestr.TabIndex = 22;
            this.buttonEditVissibleSemestr.UseVisualStyleBackColor = false;
            this.buttonEditVissibleSemestr.Click += new System.EventHandler(this.buttonEditVissibleSemestr_Click);
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
            this.button1.Location = new System.Drawing.Point(333, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.VisiblebuttonDeleteSemestr.Location = new System.Drawing.Point(376, 4);
            this.VisiblebuttonDeleteSemestr.Margin = new System.Windows.Forms.Padding(4);
            this.VisiblebuttonDeleteSemestr.Name = "VisiblebuttonDeleteSemestr";
            this.VisiblebuttonDeleteSemestr.Size = new System.Drawing.Size(29, 32);
            this.VisiblebuttonDeleteSemestr.TabIndex = 21;
            this.VisiblebuttonDeleteSemestr.UseVisualStyleBackColor = false;
            this.VisiblebuttonDeleteSemestr.Click += new System.EventHandler(this.VisiblebuttonDeleteSemestr_Click);
            // 
            // buttonAddSemester
            // 
            this.buttonAddSemester.BackColor = System.Drawing.Color.Transparent;
            
            this.buttonAddSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddSemester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSemester.FlatAppearance.BorderSize = 0;
            this.buttonAddSemester.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddSemester.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSemester.ForeColor = System.Drawing.Color.Black;
            this.buttonAddSemester.Location = new System.Drawing.Point(412, 3);
            this.buttonAddSemester.Name = "buttonAddSemester";
            this.buttonAddSemester.Size = new System.Drawing.Size(38, 40);
            this.buttonAddSemester.TabIndex = 16;
            this.buttonAddSemester.UseVisualStyleBackColor = false;
            this.buttonAddSemester.Click += new System.EventHandler(this.buttonAddSemester_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.comboBoxEditGroup);
            this.groupBox1.Controls.Add(this.textBoxNumbSemest);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonEDITSem);
            this.groupBox1.Controls.Add(this.buttonCANSELEDITSem);
            this.groupBox1.Controls.Add(this.comboBoxEditLesson);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxYearSemest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 560);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 228);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            // 
            // comboBoxEditGroup
            // 
            this.comboBoxEditGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditGroup.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditGroup.FormattingEnabled = true;
            this.comboBoxEditGroup.Location = new System.Drawing.Point(319, 90);
            this.comboBoxEditGroup.Name = "comboBoxEditGroup";
            this.comboBoxEditGroup.Size = new System.Drawing.Size(298, 31);
            this.comboBoxEditGroup.TabIndex = 47;
            // 
            // textBoxNumbSemest
            // 
            this.textBoxNumbSemest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumbSemest.Location = new System.Drawing.Point(319, 20);
            this.textBoxNumbSemest.Multiline = true;
            this.textBoxNumbSemest.Name = "textBoxNumbSemest";
            this.textBoxNumbSemest.Size = new System.Drawing.Size(298, 27);
            this.textBoxNumbSemest.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Введите номер семестра";
            // 
            // buttonEDITSem
            // 
            this.buttonEDITSem.BackgroundImage = global::ScheduleForStudents.Properties.Resources.accept;
            this.buttonEDITSem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEDITSem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEDITSem.FlatAppearance.BorderSize = 0;
            this.buttonEDITSem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEDITSem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEDITSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEDITSem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEDITSem.ForeColor = System.Drawing.Color.Black;
            this.buttonEDITSem.Location = new System.Drawing.Point(11, 165);
            this.buttonEDITSem.Name = "buttonEDITSem";
            this.buttonEDITSem.Size = new System.Drawing.Size(56, 55);
            this.buttonEDITSem.TabIndex = 16;
            this.buttonEDITSem.UseVisualStyleBackColor = true;
            this.buttonEDITSem.Click += new System.EventHandler(this.buttonEDITSem_Click);
            // 
            // buttonCANSELEDITSem
            // 
            this.buttonCANSELEDITSem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCANSELEDITSem.BackgroundImage")));
            this.buttonCANSELEDITSem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCANSELEDITSem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCANSELEDITSem.FlatAppearance.BorderSize = 0;
            this.buttonCANSELEDITSem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCANSELEDITSem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCANSELEDITSem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCANSELEDITSem.ForeColor = System.Drawing.Color.Black;
            this.buttonCANSELEDITSem.Location = new System.Drawing.Point(73, 165);
            this.buttonCANSELEDITSem.Name = "buttonCANSELEDITSem";
            this.buttonCANSELEDITSem.Size = new System.Drawing.Size(56, 55);
            this.buttonCANSELEDITSem.TabIndex = 17;
            this.buttonCANSELEDITSem.UseVisualStyleBackColor = true;
            this.buttonCANSELEDITSem.Click += new System.EventHandler(this.buttonCANSELEDITSem_Click);
            // 
            // comboBoxEditLesson
            // 
            this.comboBoxEditLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditLesson.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditLesson.FormattingEnabled = true;
            this.comboBoxEditLesson.Location = new System.Drawing.Point(319, 130);
            this.comboBoxEditLesson.Name = "comboBoxEditLesson";
            this.comboBoxEditLesson.Size = new System.Drawing.Size(298, 31);
            this.comboBoxEditLesson.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Выберите номер недели";
            // 
            // textBoxYearSemest
            // 
            this.textBoxYearSemest.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYearSemest.Location = new System.Drawing.Point(319, 55);
            this.textBoxYearSemest.Multiline = true;
            this.textBoxYearSemest.Name = "textBoxYearSemest";
            this.textBoxYearSemest.Size = new System.Drawing.Size(298, 27);
            this.textBoxYearSemest.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Введите год семестра";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Выберите группу студентов";
            // 
            // SemesterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewSemester;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonEditVissibleSemestr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VisiblebuttonDeleteSemestr;
        private System.Windows.Forms.Button buttonAddSemester;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEDITSem;
        private System.Windows.Forms.Button buttonCANSELEDITSem;
        private System.Windows.Forms.ComboBox comboBoxEditLesson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxYearSemest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumbSemest;
        private System.Windows.Forms.ComboBox comboBoxEditGroup;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn numb_week;
    }
}
