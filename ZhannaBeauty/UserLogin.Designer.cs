namespace ZhannaBeauty
{
    partial class UserLogin
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.userLogin_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username_textBox = new System.Windows.Forms.MaskedTextBox();
            this.regUser_linkLabel = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.worker_linkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Location = new System.Drawing.Point(82, 124);
            this.pwd_textBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.PasswordChar = '*';
            this.pwd_textBox.Size = new System.Drawing.Size(275, 38);
            this.pwd_textBox.TabIndex = 4;
            this.pwd_textBox.Text = "пар";
            // 
            // userLogin_button
            // 
            this.userLogin_button.AutoSize = true;
            this.userLogin_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLogin_button.Location = new System.Drawing.Point(82, 178);
            this.userLogin_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.userLogin_button.Name = "userLogin_button";
            this.userLogin_button.Size = new System.Drawing.Size(278, 72);
            this.userLogin_button.TabIndex = 5;
            this.userLogin_button.Text = "Войти!";
            this.userLogin_button.UseVisualStyleBackColor = true;
            this.userLogin_button.Click += new System.EventHandler(this.userLogin_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.username_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.userLogin_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pwd_textBox);
            this.panel1.Location = new System.Drawing.Point(196, 550);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 242);
            this.panel1.TabIndex = 6;
            // 
            // username_textBox
            // 
            this.username_textBox.Location = new System.Drawing.Point(84, 40);
            this.username_textBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.username_textBox.Mask = "000000000";
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(274, 38);
            this.username_textBox.TabIndex = 6;
            this.username_textBox.Text = "897726603";
            // 
            // regUser_linkLabel
            // 
            this.regUser_linkLabel.AutoSize = true;
            this.regUser_linkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regUser_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.regUser_linkLabel.Location = new System.Drawing.Point(424, 798);
            this.regUser_linkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.regUser_linkLabel.Name = "regUser_linkLabel";
            this.regUser_linkLabel.Size = new System.Drawing.Size(235, 31);
            this.regUser_linkLabel.TabIndex = 9;
            this.regUser_linkLabel.TabStop = true;
            this.regUser_linkLabel.Text = "Зарегистрируйтесь!";
            this.regUser_linkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.regUser_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regUser_linkLabel_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(187, 798);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Нет учетной записи?";
            // 
            // worker_linkLabel
            // 
            this.worker_linkLabel.AutoSize = true;
            this.worker_linkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.worker_linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.worker_linkLabel.Location = new System.Drawing.Point(597, 940);
            this.worker_linkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.worker_linkLabel.Name = "worker_linkLabel";
            this.worker_linkLabel.Size = new System.Drawing.Size(249, 31);
            this.worker_linkLabel.TabIndex = 10;
            this.worker_linkLabel.TabStop = true;
            this.worker_linkLabel.Text = "Вход для сотрудников";
            this.worker_linkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.worker_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.worker_linkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZhannaBeauty.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(161, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 518);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 985);
            this.Controls.Add(this.regUser_linkLabel);
            this.Controls.Add(this.worker_linkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.Button userLogin_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel regUser_linkLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel worker_linkLabel;
        private System.Windows.Forms.MaskedTextBox username_textBox;
    }
}

