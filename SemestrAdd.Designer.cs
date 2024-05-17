namespace ScheduleForStudents
{
    partial class SemestrAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SemestrAdd));
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNumbSemes = new System.Windows.Forms.TextBox();
            this.textBoxYearSem = new System.Windows.Forms.TextBox();
            this.comboBoxAddGroups = new System.Windows.Forms.ComboBox();
            this.comboBoxAddLesson = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonCancelAddSemestr = new System.Windows.Forms.Button();
            this.buttonAddSemestr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 26);
            this.label8.TabIndex = 67;
            this.label8.Text = "Введите номер семестра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 26);
            this.label4.TabIndex = 66;
            this.label4.Text = "Выберите номер недели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 26);
            this.label2.TabIndex = 65;
            this.label2.Text = "Введите год семестра";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(311, 26);
            this.label7.TabIndex = 64;
            this.label7.Text = "Выберите группу студентов";
            // 
            // textBoxNumbSemes
            // 
            this.textBoxNumbSemes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumbSemes.Location = new System.Drawing.Point(339, 19);
            this.textBoxNumbSemes.Name = "textBoxNumbSemes";
            this.textBoxNumbSemes.Size = new System.Drawing.Size(382, 32);
            this.textBoxNumbSemes.TabIndex = 68;
            // 
            // textBoxYearSem
            // 
            this.textBoxYearSem.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYearSem.Location = new System.Drawing.Point(339, 59);
            this.textBoxYearSem.Name = "textBoxYearSem";
            this.textBoxYearSem.Size = new System.Drawing.Size(382, 32);
            this.textBoxYearSem.TabIndex = 69;
            // 
            // comboBoxAddGroups
            // 
            this.comboBoxAddGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddGroups.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAddGroups.FormattingEnabled = true;
            this.comboBoxAddGroups.Location = new System.Drawing.Point(339, 100);
            this.comboBoxAddGroups.Name = "comboBoxAddGroups";
            this.comboBoxAddGroups.Size = new System.Drawing.Size(382, 31);
            this.comboBoxAddGroups.TabIndex = 70;
            // 
            // comboBoxAddLesson
            // 
            this.comboBoxAddLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddLesson.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAddLesson.FormattingEnabled = true;
            this.comboBoxAddLesson.Location = new System.Drawing.Point(339, 142);
            this.comboBoxAddLesson.Name = "comboBoxAddLesson";
            this.comboBoxAddLesson.Size = new System.Drawing.Size(382, 31);
            this.comboBoxAddLesson.TabIndex = 71;
            // 
            // buttonCancelAddSemestr
            // 
            this.buttonCancelAddSemestr.BackgroundImage = global::ScheduleForStudents.Properties.Resources.cancel;
            this.buttonCancelAddSemestr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelAddSemestr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelAddSemestr.FlatAppearance.BorderSize = 0;
            this.buttonCancelAddSemestr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelAddSemestr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCancelAddSemestr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelAddSemestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelAddSemestr.ForeColor = System.Drawing.Color.Black;
            this.buttonCancelAddSemestr.Location = new System.Drawing.Point(104, 192);
            this.buttonCancelAddSemestr.Name = "buttonCancelAddSemestr";
            this.buttonCancelAddSemestr.Size = new System.Drawing.Size(75, 73);
            this.buttonCancelAddSemestr.TabIndex = 63;
            this.buttonCancelAddSemestr.UseVisualStyleBackColor = true;
            this.buttonCancelAddSemestr.Click += new System.EventHandler(this.buttonCancelAddLESS_Click);
            // 
            // buttonAddSemestr
            // 
            this.buttonAddSemestr.BackgroundImage = global::ScheduleForStudents.Properties.Resources.accept;
            this.buttonAddSemestr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddSemestr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddSemestr.FlatAppearance.BorderSize = 0;
            this.buttonAddSemestr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddSemestr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddSemestr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSemestr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddSemestr.ForeColor = System.Drawing.Color.Black;
            this.buttonAddSemestr.Location = new System.Drawing.Point(23, 192);
            this.buttonAddSemestr.Name = "buttonAddSemestr";
            this.buttonAddSemestr.Size = new System.Drawing.Size(75, 73);
            this.buttonAddSemestr.TabIndex = 62;
            this.buttonAddSemestr.UseVisualStyleBackColor = true;
            this.buttonAddSemestr.Click += new System.EventHandler(this.buttonAddSemestr_Click);
            // 
            // SemestrAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(742, 275);
            this.Controls.Add(this.comboBoxAddLesson);
            this.Controls.Add(this.comboBoxAddGroups);
            this.Controls.Add(this.textBoxYearSem);
            this.Controls.Add(this.textBoxNumbSemes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonCancelAddSemestr);
            this.Controls.Add(this.buttonAddSemestr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SemestrAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.SemestrAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAddSemestr;
        private System.Windows.Forms.Button buttonAddSemestr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNumbSemes;
        private System.Windows.Forms.TextBox textBoxYearSem;
        private System.Windows.Forms.ComboBox comboBoxAddGroups;
        private System.Windows.Forms.ComboBox comboBoxAddLesson;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}