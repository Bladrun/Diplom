namespace ScheduleForStudents
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxRemember = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckBoxPassShow = new MaterialSkin.Controls.MaterialCheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ScheduleForStudents.Properties.Resources.weekly;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(101, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "TimeTact\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(101, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Расписание занятий УниКИТ\r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 476);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ScheduleForStudents.Properties.Resources._5870_upto100x100;
            this.pictureBox5.Location = new System.Drawing.Point(12, 73);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(333, 318);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserPassword.Location = new System.Drawing.Point(89, 238);
            this.textBoxUserPassword.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(380, 42);
            this.textBoxUserPassword.TabIndex = 30;
            this.textBoxUserPassword.Text = "Пароль";
            this.textBoxUserPassword.UseSystemPasswordChar = true;
            this.textBoxUserPassword.Click += new System.EventHandler(this.textBoxUserPassword_Click);
            this.textBoxUserPassword.Leave += new System.EventHandler(this.textBoxUserPassword_Leave);
            // 
            // textBoxUserLogin
            // 
            this.textBoxUserLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserLogin.Location = new System.Drawing.Point(89, 188);
            this.textBoxUserLogin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBoxUserLogin.Multiline = true;
            this.textBoxUserLogin.Name = "textBoxUserLogin";
            this.textBoxUserLogin.Size = new System.Drawing.Size(380, 43);
            this.textBoxUserLogin.TabIndex = 29;
            this.textBoxUserLogin.Text = "Введите логин";
            this.textBoxUserLogin.Click += new System.EventHandler(this.textBoxUserLogin_Click);
            this.textBoxUserLogin.Leave += new System.EventHandler(this.textBoxUserLogin_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(193, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 42);
            this.label3.TabIndex = 34;
            this.label3.Text = "Авторизация";
            // 
            // CheckBoxRemember
            // 
            this.CheckBoxRemember.Depth = 0;
            this.CheckBoxRemember.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxRemember.Location = new System.Drawing.Point(28, 325);
            this.CheckBoxRemember.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxRemember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxRemember.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxRemember.Name = "CheckBoxRemember";
            this.CheckBoxRemember.Ripple = true;
            this.CheckBoxRemember.Size = new System.Drawing.Size(203, 30);
            this.CheckBoxRemember.TabIndex = 36;
            this.CheckBoxRemember.Text = "Запомнить пользователя";
            this.CheckBoxRemember.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPassShow
            // 
            this.CheckBoxPassShow.Depth = 0;
            this.CheckBoxPassShow.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckBoxPassShow.Location = new System.Drawing.Point(28, 297);
            this.CheckBoxPassShow.Margin = new System.Windows.Forms.Padding(0);
            this.CheckBoxPassShow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckBoxPassShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckBoxPassShow.Name = "CheckBoxPassShow";
            this.CheckBoxPassShow.Ripple = true;
            this.CheckBoxPassShow.Size = new System.Drawing.Size(150, 30);
            this.CheckBoxPassShow.TabIndex = 35;
            this.CheckBoxPassShow.Text = "Показать пароль";
            this.CheckBoxPassShow.UseVisualStyleBackColor = true;
            this.CheckBoxPassShow.CheckedChanged += new System.EventHandler(this.CheckBoxPassShow_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(28, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(441, 75);
            this.button1.TabIndex = 37;
            this.button1.Text = "Войти в систему";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ScheduleForStudents.Properties.Resources.user;
            this.pictureBox2.Location = new System.Drawing.Point(28, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = global::ScheduleForStudents.Properties.Resources.pass;
            this.pictureBox4.Location = new System.Drawing.Point(28, 240);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 43);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::ScheduleForStudents.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(28, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.textBoxUserPassword);
            this.panel3.Controls.Add(this.textBoxUserLogin);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.CheckBoxRemember);
            this.panel3.Controls.Add(this.CheckBoxPassShow);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(351, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(502, 476);
            this.panel3.TabIndex = 38;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(853, 576);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация TimeTact";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxRemember;
        private MaterialSkin.Controls.MaterialCheckBox CheckBoxPassShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel3;
    }
}