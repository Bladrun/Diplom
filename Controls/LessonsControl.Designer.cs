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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonsControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLessons = new System.Windows.Forms.DataGridView();
            this.id_lesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numb_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chet_or_nechet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_of_the_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_of_the_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.short_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxnumbweek = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEDITLESS = new System.Windows.Forms.Button();
            this.buttonCANSELEDITLESS = new System.Windows.Forms.Button();
            this.textBoxeditendtime = new System.Windows.Forms.TextBox();
            this.comboBoxEDITEACH = new System.Windows.Forms.ComboBox();
            this.textBoxEditstarttime = new System.Windows.Forms.TextBox();
            this.comboBoxEDITGROUP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEditsubject = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEdittypeweek = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxEDITCAB = new System.Windows.Forms.TextBox();
            this.textBoxEDITDAY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEditVissibleLESS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.VisiblebuttonDeleteLESS = new System.Windows.Forms.Button();
            this.buttonAddLesson = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dataGridViewLessons.AllowUserToAddRows = false;
            this.dataGridViewLessons.AllowUserToDeleteRows = false;
            this.dataGridViewLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_lesson,
            this.numb_week,
            this.chet_or_nechet,
            this.day_of_the_week,
            this.name_of_the_subject,
            this.start_time,
            this.end_time,
            this.cabinet,
            this.short_number,
            this.fio});
            this.dataGridViewLessons.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewLessons.Name = "dataGridViewLessons";
            this.dataGridViewLessons.ReadOnly = true;
            this.dataGridViewLessons.RowHeadersVisible = false;
            this.dataGridViewLessons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLessons.Size = new System.Drawing.Size(1661, 456);
            this.dataGridViewLessons.TabIndex = 8;
            // 
            // id_lesson
            // 
            this.id_lesson.DataPropertyName = "id_lesson";
            this.id_lesson.HeaderText = "id_lesson";
            this.id_lesson.Name = "id_lesson";
            this.id_lesson.ReadOnly = true;
            this.id_lesson.Visible = false;
            // 
            // numb_week
            // 
            this.numb_week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numb_week.DataPropertyName = "numb_week";
            this.numb_week.HeaderText = "Номер недели";
            this.numb_week.Name = "numb_week";
            this.numb_week.ReadOnly = true;
            // 
            // chet_or_nechet
            // 
            this.chet_or_nechet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chet_or_nechet.DataPropertyName = "chet_or_nechet";
            this.chet_or_nechet.HeaderText = "Четная/Нечетная";
            this.chet_or_nechet.Name = "chet_or_nechet";
            this.chet_or_nechet.ReadOnly = true;
            // 
            // day_of_the_week
            // 
            this.day_of_the_week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.day_of_the_week.DataPropertyName = "day_of_the_week";
            this.day_of_the_week.HeaderText = "День недели";
            this.day_of_the_week.Name = "day_of_the_week";
            this.day_of_the_week.ReadOnly = true;
            // 
            // name_of_the_subject
            // 
            this.name_of_the_subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name_of_the_subject.DataPropertyName = "name_of_the_subject";
            this.name_of_the_subject.HeaderText = "Наименование предмета";
            this.name_of_the_subject.Name = "name_of_the_subject";
            this.name_of_the_subject.ReadOnly = true;
            this.name_of_the_subject.Width = 195;
            // 
            // start_time
            // 
            this.start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_time.DataPropertyName = "start_time";
            this.start_time.HeaderText = "Время начала";
            this.start_time.Name = "start_time";
            this.start_time.ReadOnly = true;
            // 
            // end_time
            // 
            this.end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_time.DataPropertyName = "end_time";
            this.end_time.HeaderText = "Время окончания";
            this.end_time.Name = "end_time";
            this.end_time.ReadOnly = true;
            // 
            // cabinet
            // 
            this.cabinet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cabinet.DataPropertyName = "cabinet";
            this.cabinet.HeaderText = "Аудитория";
            this.cabinet.Name = "cabinet";
            this.cabinet.ReadOnly = true;
            // 
            // short_number
            // 
            this.short_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.short_number.DataPropertyName = "short_number";
            this.short_number.HeaderText = "Группа";
            this.short_number.Name = "short_number";
            this.short_number.ReadOnly = true;
            // 
            // fio
            // 
            this.fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fio.DataPropertyName = "fio";
            this.fio.HeaderText = "Преподаватель";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.textBoxnumbweek);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonEDITLESS);
            this.groupBox1.Controls.Add(this.buttonCANSELEDITLESS);
            this.groupBox1.Controls.Add(this.textBoxeditendtime);
            this.groupBox1.Controls.Add(this.comboBoxEDITEACH);
            this.groupBox1.Controls.Add(this.textBoxEditstarttime);
            this.groupBox1.Controls.Add(this.comboBoxEDITGROUP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxEditsubject);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxEdittypeweek);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxEDITCAB);
            this.groupBox1.Controls.Add(this.textBoxEDITDAY);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 560);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 228);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактирование";
            // 
            // textBoxnumbweek
            // 
            this.textBoxnumbweek.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxnumbweek.Location = new System.Drawing.Point(305, 26);
            this.textBoxnumbweek.Multiline = true;
            this.textBoxnumbweek.Name = "textBoxnumbweek";
            this.textBoxnumbweek.Size = new System.Drawing.Size(298, 27);
            this.textBoxnumbweek.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 26);
            this.label8.TabIndex = 45;
            this.label8.Text = "Введите номер недели";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(609, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Выберите группу";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(609, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 61);
            this.label11.TabIndex = 23;
            this.label11.Text = "Выберите преподавателя";
            // 
            // buttonEDITLESS
            // 
            this.buttonEDITLESS.BackgroundImage = global::ScheduleForStudents.Properties.Resources.accept;
            this.buttonEDITLESS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEDITLESS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEDITLESS.FlatAppearance.BorderSize = 0;
            this.buttonEDITLESS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEDITLESS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEDITLESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEDITLESS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEDITLESS.ForeColor = System.Drawing.Color.Black;
            this.buttonEDITLESS.Location = new System.Drawing.Point(11, 164);
            this.buttonEDITLESS.Name = "buttonEDITLESS";
            this.buttonEDITLESS.Size = new System.Drawing.Size(56, 55);
            this.buttonEDITLESS.TabIndex = 16;
            this.buttonEDITLESS.UseVisualStyleBackColor = true;
            this.buttonEDITLESS.Click += new System.EventHandler(this.buttonEDITLESS_Click);
            // 
            // buttonCANSELEDITLESS
            // 
            this.buttonCANSELEDITLESS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCANSELEDITLESS.BackgroundImage")));
            this.buttonCANSELEDITLESS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCANSELEDITLESS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCANSELEDITLESS.FlatAppearance.BorderSize = 0;
            this.buttonCANSELEDITLESS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCANSELEDITLESS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCANSELEDITLESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCANSELEDITLESS.ForeColor = System.Drawing.Color.Black;
            this.buttonCANSELEDITLESS.Location = new System.Drawing.Point(73, 164);
            this.buttonCANSELEDITLESS.Name = "buttonCANSELEDITLESS";
            this.buttonCANSELEDITLESS.Size = new System.Drawing.Size(56, 55);
            this.buttonCANSELEDITLESS.TabIndex = 17;
            this.buttonCANSELEDITLESS.UseVisualStyleBackColor = true;
            this.buttonCANSELEDITLESS.Click += new System.EventHandler(this.buttonCANSELEDITLESS_Click);
            // 
            // textBoxeditendtime
            // 
            this.textBoxeditendtime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxeditendtime.Location = new System.Drawing.Point(908, 57);
            this.textBoxeditendtime.Multiline = true;
            this.textBoxeditendtime.Name = "textBoxeditendtime";
            this.textBoxeditendtime.Size = new System.Drawing.Size(206, 27);
            this.textBoxeditendtime.TabIndex = 44;
            // 
            // comboBoxEDITEACH
            // 
            this.comboBoxEDITEACH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEDITEACH.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEDITEACH.FormattingEnabled = true;
            this.comboBoxEDITEACH.Location = new System.Drawing.Point(836, 170);
            this.comboBoxEDITEACH.Name = "comboBoxEDITEACH";
            this.comboBoxEDITEACH.Size = new System.Drawing.Size(278, 31);
            this.comboBoxEDITEACH.TabIndex = 21;
            // 
            // textBoxEditstarttime
            // 
            this.textBoxEditstarttime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEditstarttime.Location = new System.Drawing.Point(908, 24);
            this.textBoxEditstarttime.Multiline = true;
            this.textBoxEditstarttime.Name = "textBoxEditstarttime";
            this.textBoxEditstarttime.Size = new System.Drawing.Size(206, 27);
            this.textBoxEditstarttime.TabIndex = 43;
            // 
            // comboBoxEDITGROUP
            // 
            this.comboBoxEDITGROUP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEDITGROUP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEDITGROUP.FormattingEnabled = true;
            this.comboBoxEDITGROUP.Location = new System.Drawing.Point(836, 127);
            this.comboBoxEDITGROUP.Name = "comboBoxEDITGROUP";
            this.comboBoxEDITGROUP.Size = new System.Drawing.Size(278, 31);
            this.comboBoxEDITGROUP.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(609, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 26);
            this.label5.TabIndex = 42;
            this.label5.Text = "Введите время окончания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(609, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "Введите время начала";
            // 
            // comboBoxEditsubject
            // 
            this.comboBoxEditsubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditsubject.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditsubject.FormattingEnabled = true;
            this.comboBoxEditsubject.Location = new System.Drawing.Point(305, 125);
            this.comboBoxEditsubject.Name = "comboBoxEditsubject";
            this.comboBoxEditsubject.Size = new System.Drawing.Size(298, 31);
            this.comboBoxEditsubject.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 26);
            this.label4.TabIndex = 37;
            this.label4.Text = "Выберите предмет";
            // 
            // textBoxEdittypeweek
            // 
            this.textBoxEdittypeweek.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEdittypeweek.Location = new System.Drawing.Point(305, 59);
            this.textBoxEdittypeweek.Multiline = true;
            this.textBoxEdittypeweek.Name = "textBoxEdittypeweek";
            this.textBoxEdittypeweek.Size = new System.Drawing.Size(298, 27);
            this.textBoxEdittypeweek.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "Введите тип недели";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Введите день";
            // 
            // textBoxEDITCAB
            // 
            this.textBoxEDITCAB.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEDITCAB.Location = new System.Drawing.Point(836, 91);
            this.textBoxEDITCAB.Multiline = true;
            this.textBoxEDITCAB.Name = "textBoxEDITCAB";
            this.textBoxEDITCAB.Size = new System.Drawing.Size(278, 27);
            this.textBoxEDITCAB.TabIndex = 26;
            // 
            // textBoxEDITDAY
            // 
            this.textBoxEDITDAY.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEDITDAY.Location = new System.Drawing.Point(305, 92);
            this.textBoxEDITDAY.Multiline = true;
            this.textBoxEDITDAY.Name = "textBoxEDITDAY";
            this.textBoxEDITDAY.Size = new System.Drawing.Size(298, 27);
            this.textBoxEDITDAY.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(609, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Введите аудиторию";
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
            this.flowLayoutPanel1.Controls.Add(this.buttonEditVissibleLESS);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.VisiblebuttonDeleteLESS);
            this.flowLayoutPanel1.Controls.Add(this.buttonAddLesson);
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
            // buttonEditVissibleLESS
            // 
            this.buttonEditVissibleLESS.AutoSize = true;
            this.buttonEditVissibleLESS.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditVissibleLESS.BackgroundImage = global::ScheduleForStudents.Properties.Resources.edit;
            this.buttonEditVissibleLESS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEditVissibleLESS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditVissibleLESS.FlatAppearance.BorderSize = 0;
            this.buttonEditVissibleLESS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEditVissibleLESS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEditVissibleLESS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditVissibleLESS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditVissibleLESS.Location = new System.Drawing.Point(293, 4);
            this.buttonEditVissibleLESS.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditVissibleLESS.Name = "buttonEditVissibleLESS";
            this.buttonEditVissibleLESS.Size = new System.Drawing.Size(32, 33);
            this.buttonEditVissibleLESS.TabIndex = 22;
            this.buttonEditVissibleLESS.UseVisualStyleBackColor = false;
            this.buttonEditVissibleLESS.Click += new System.EventHandler(this.buttonEditVissibleLESS_Click);
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
            this.VisiblebuttonDeleteLESS.Location = new System.Drawing.Point(376, 4);
            this.VisiblebuttonDeleteLESS.Margin = new System.Windows.Forms.Padding(4);
            this.VisiblebuttonDeleteLESS.Name = "VisiblebuttonDeleteLESS";
            this.VisiblebuttonDeleteLESS.Size = new System.Drawing.Size(29, 32);
            this.VisiblebuttonDeleteLESS.TabIndex = 21;
            this.VisiblebuttonDeleteLESS.UseVisualStyleBackColor = false;
            this.VisiblebuttonDeleteLESS.Click += new System.EventHandler(this.VisiblebuttonDeleteLESS_Click);
            // 
            // buttonAddLesson
            // 
            this.buttonAddLesson.BackColor = System.Drawing.Color.Transparent;
            
            this.buttonAddLesson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddLesson.FlatAppearance.BorderSize = 0;
            this.buttonAddLesson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddLesson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddLesson.ForeColor = System.Drawing.Color.Black;
            this.buttonAddLesson.Location = new System.Drawing.Point(412, 3);
            this.buttonAddLesson.Name = "buttonAddLesson";
            this.buttonAddLesson.Size = new System.Drawing.Size(38, 40);
            this.buttonAddLesson.TabIndex = 16;
            this.buttonAddLesson.UseVisualStyleBackColor = false;
            this.buttonAddLesson.Click += new System.EventHandler(this.buttonAddLesson_Click);
            // 
            // LessonsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewLessons);
            this.Controls.Add(this.panel1);
            this.Name = "LessonsControl";
            this.Size = new System.Drawing.Size(1661, 791);
            this.Load += new System.EventHandler(this.LessonsControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLessons)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditVissibleLESS;
        private System.Windows.Forms.Button buttonAddLesson;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCANSELEDITLESS;
        private System.Windows.Forms.Button buttonEDITLESS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxEDITCAB;
        private System.Windows.Forms.TextBox textBoxEDITDAY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxEDITGROUP;
        private System.Windows.Forms.ComboBox comboBoxEDITEACH;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button VisiblebuttonDeleteLESS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.DataGridView dataGridViewLessons;
        private System.Windows.Forms.TextBox textBoxEdittypeweek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEditsubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxeditendtime;
        private System.Windows.Forms.TextBox textBoxEditstarttime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.TextBox textBoxnumbweek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_lesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn numb_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn chet_or_nechet;
        private System.Windows.Forms.DataGridViewTextBoxColumn day_of_the_week;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_of_the_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
    }
}
