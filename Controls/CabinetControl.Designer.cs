namespace ScheduleForStudents.Controls
{
    partial class CabinetControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.VisiblebuttonDeleteCAb = new System.Windows.Forms.Button();
            this.dataGridViewCabs = new System.Windows.Forms.DataGridView();
            this.id_cabinet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numb_cab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number_of_seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabs)).BeginInit();
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
            this.panel1.TabIndex = 8;
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
            this.label1.Text = "ИЗМЕНЕНИЕ КАБИНЕТОВ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.VisiblebuttonDeleteCAb);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 54);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1660, 44);
            this.flowLayoutPanel1.TabIndex = 32;
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
            // VisiblebuttonDeleteCAb
            // 
            this.VisiblebuttonDeleteCAb.AutoSize = true;
            this.VisiblebuttonDeleteCAb.BackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteCAb.BackgroundImage = global::ScheduleForStudents.Properties.Resources.bin;
            this.VisiblebuttonDeleteCAb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VisiblebuttonDeleteCAb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisiblebuttonDeleteCAb.FlatAppearance.BorderSize = 0;
            this.VisiblebuttonDeleteCAb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteCAb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.VisiblebuttonDeleteCAb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisiblebuttonDeleteCAb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisiblebuttonDeleteCAb.Location = new System.Drawing.Point(379, 4);
            this.VisiblebuttonDeleteCAb.Margin = new System.Windows.Forms.Padding(4);
            this.VisiblebuttonDeleteCAb.Name = "VisiblebuttonDeleteCAb";
            this.VisiblebuttonDeleteCAb.Size = new System.Drawing.Size(29, 32);
            this.VisiblebuttonDeleteCAb.TabIndex = 21;
            this.VisiblebuttonDeleteCAb.UseVisualStyleBackColor = false;
            this.VisiblebuttonDeleteCAb.Click += new System.EventHandler(this.VisiblebuttonDeleteCAb_Click);
            // 
            // dataGridViewCabs
            // 
            this.dataGridViewCabs.AllowUserToDeleteRows = false;
            this.dataGridViewCabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCabs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCabs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCabs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cabinet,
            this.numb_cab,
            this.number_of_seats});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCabs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCabs.Location = new System.Drawing.Point(0, 98);
            this.dataGridViewCabs.Name = "dataGridViewCabs";
            this.dataGridViewCabs.RowHeadersVisible = false;
            this.dataGridViewCabs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCabs.Size = new System.Drawing.Size(1661, 693);
            this.dataGridViewCabs.TabIndex = 33;
            this.dataGridViewCabs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCabs_CellEndEdit);
            this.dataGridViewCabs.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCabs_RowValidated);
            // 
            // id_cabinet
            // 
            this.id_cabinet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_cabinet.DataPropertyName = "id_cabinet";
            this.id_cabinet.HeaderText = "id_cabinet";
            this.id_cabinet.Name = "id_cabinet";
            this.id_cabinet.Visible = false;
            // 
            // numb_cab
            // 
            this.numb_cab.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numb_cab.DataPropertyName = "numb_cab";
            this.numb_cab.HeaderText = "Номер кабинета";
            this.numb_cab.Name = "numb_cab";
            // 
            // number_of_seats
            // 
            this.number_of_seats.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number_of_seats.DataPropertyName = "number_of_seats";
            this.number_of_seats.HeaderText = "Вмещаемость";
            this.number_of_seats.Name = "number_of_seats";
            // 
            // CabinetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.dataGridViewCabs);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "CabinetControl";
            this.Size = new System.Drawing.Size(1661, 791);
            this.Load += new System.EventHandler(this.CabinetControl_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button VisiblebuttonDeleteCAb;
        public System.Windows.Forms.DataGridView dataGridViewCabs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cabinet;
        private System.Windows.Forms.DataGridViewTextBoxColumn numb_cab;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_of_seats;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}
