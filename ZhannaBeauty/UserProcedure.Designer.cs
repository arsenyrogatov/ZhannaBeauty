namespace ZhannaBeauty
{
    partial class UserProcedure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProcedure));
            this.find_textBox = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.user_pictureBox = new System.Windows.Forms.PictureBox();
            this.procs_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userReg_linkLabel = new System.Windows.Forms.LinkLabel();
            this.userPhone_label = new System.Windows.Forms.Label();
            this.userGen_label = new System.Windows.Forms.Label();
            this.userBDate_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.userFIO_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.procWorker_label = new System.Windows.Forms.Label();
            this.procName_label = new System.Windows.Forms.Label();
            this.procDate_label = new System.Windows.Forms.Label();
            this.procID_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.procPrice_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procs_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // find_textBox
            // 
            this.find_textBox.ForeColor = System.Drawing.Color.Gray;
            this.find_textBox.Location = new System.Drawing.Point(502, 23);
            this.find_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(576, 38);
            this.find_textBox.TabIndex = 28;
            this.find_textBox.Text = "Поиск по названию услуги или ФИО мастера...";
            this.find_textBox.TextChanged += new System.EventHandler(this.find_button_Click);
            this.find_textBox.Enter += new System.EventHandler(this.find_textBox_Enter);
            this.find_textBox.Leave += new System.EventHandler(this.find_textBox_Leave);
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(1092, 23);
            this.find_button.Margin = new System.Windows.Forms.Padding(5);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(131, 44);
            this.find_button.TabIndex = 27;
            this.find_button.Text = "Поиск";
            this.find_button.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(1227, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 38);
            this.label2.TabIndex = 22;
            this.label2.Text = "Информация о приеме";
            // 
            // user_pictureBox
            // 
            this.user_pictureBox.Image = global::ZhannaBeauty.Properties.Resources.Female_User;
            this.user_pictureBox.Location = new System.Drawing.Point(7, 5);
            this.user_pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.user_pictureBox.Name = "user_pictureBox";
            this.user_pictureBox.Size = new System.Drawing.Size(88, 88);
            this.user_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox.TabIndex = 20;
            this.user_pictureBox.TabStop = false;
            // 
            // procs_dataGridView
            // 
            this.procs_dataGridView.AllowUserToAddRows = false;
            this.procs_dataGridView.AllowUserToDeleteRows = false;
            this.procs_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.procs_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.procs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procs_dataGridView.Location = new System.Drawing.Point(30, 93);
            this.procs_dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.procs_dataGridView.MultiSelect = false;
            this.procs_dataGridView.Name = "procs_dataGridView";
            this.procs_dataGridView.ReadOnly = true;
            this.procs_dataGridView.RowHeadersVisible = false;
            this.procs_dataGridView.RowHeadersWidth = 72;
            this.procs_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.procs_dataGridView.Size = new System.Drawing.Size(1194, 539);
            this.procs_dataGridView.TabIndex = 19;
            this.procs_dataGridView.SelectionChanged += new System.EventHandler(this.procs_dataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 51);
            this.label1.TabIndex = 18;
            this.label1.Text = "История процедур";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.userReg_linkLabel);
            this.panel2.Controls.Add(this.userPhone_label);
            this.panel2.Controls.Add(this.userGen_label);
            this.panel2.Controls.Add(this.userBDate_label);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.userFIO_label);
            this.panel2.Controls.Add(this.user_pictureBox);
            this.panel2.Location = new System.Drawing.Point(1234, 23);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 278);
            this.panel2.TabIndex = 29;
            // 
            // userReg_linkLabel
            // 
            this.userReg_linkLabel.Location = new System.Drawing.Point(5, 234);
            this.userReg_linkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userReg_linkLabel.Name = "userReg_linkLabel";
            this.userReg_linkLabel.Size = new System.Drawing.Size(478, 37);
            this.userReg_linkLabel.TabIndex = 28;
            this.userReg_linkLabel.TabStop = true;
            this.userReg_linkLabel.Text = "Изменить данные";
            this.userReg_linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userReg_linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userReg_linkLabel_LinkClicked);
            // 
            // userPhone_label
            // 
            this.userPhone_label.Location = new System.Drawing.Point(201, 182);
            this.userPhone_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userPhone_label.Name = "userPhone_label";
            this.userPhone_label.Size = new System.Drawing.Size(270, 30);
            this.userPhone_label.TabIndex = 27;
            this.userPhone_label.Text = "-";
            // 
            // userGen_label
            // 
            this.userGen_label.Location = new System.Drawing.Point(201, 144);
            this.userGen_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userGen_label.Name = "userGen_label";
            this.userGen_label.Size = new System.Drawing.Size(270, 30);
            this.userGen_label.TabIndex = 26;
            this.userGen_label.Text = "-";
            // 
            // userBDate_label
            // 
            this.userBDate_label.Location = new System.Drawing.Point(201, 103);
            this.userBDate_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userBDate_label.Name = "userBDate_label";
            this.userBDate_label.Size = new System.Drawing.Size(270, 30);
            this.userBDate_label.TabIndex = 25;
            this.userBDate_label.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(12, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 31);
            this.label8.TabIndex = 22;
            this.label8.Text = "Дата рождения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(136, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 31);
            this.label9.TabIndex = 23;
            this.label9.Text = "Пол";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(89, 182);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = "Телефон";
            // 
            // userFIO_label
            // 
            this.userFIO_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.userFIO_label.Location = new System.Drawing.Point(105, 5);
            this.userFIO_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userFIO_label.Name = "userFIO_label";
            this.userFIO_label.Size = new System.Drawing.Size(378, 88);
            this.userFIO_label.TabIndex = 21;
            this.userFIO_label.Text = "Фамилия И.О.";
            this.userFIO_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.procWorker_label);
            this.panel1.Controls.Add(this.procName_label);
            this.panel1.Controls.Add(this.procDate_label);
            this.panel1.Controls.Add(this.procID_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.procPrice_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1234, 368);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 263);
            this.panel1.TabIndex = 30;
            // 
            // procWorker_label
            // 
            this.procWorker_label.Location = new System.Drawing.Point(116, 154);
            this.procWorker_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.procWorker_label.Name = "procWorker_label";
            this.procWorker_label.Size = new System.Drawing.Size(334, 30);
            this.procWorker_label.TabIndex = 15;
            this.procWorker_label.Text = "-";
            // 
            // procName_label
            // 
            this.procName_label.Location = new System.Drawing.Point(116, 107);
            this.procName_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.procName_label.Name = "procName_label";
            this.procName_label.Size = new System.Drawing.Size(334, 30);
            this.procName_label.TabIndex = 14;
            this.procName_label.Text = "-";
            // 
            // procDate_label
            // 
            this.procDate_label.Location = new System.Drawing.Point(116, 60);
            this.procDate_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.procDate_label.Name = "procDate_label";
            this.procDate_label.Size = new System.Drawing.Size(334, 30);
            this.procDate_label.TabIndex = 13;
            this.procDate_label.Text = "-";
            // 
            // procID_label
            // 
            this.procID_label.Location = new System.Drawing.Point(116, 16);
            this.procID_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.procID_label.Name = "procID_label";
            this.procID_label.Size = new System.Drawing.Size(334, 30);
            this.procID_label.TabIndex = 12;
            this.procID_label.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(72, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "№";
            // 
            // procPrice_label
            // 
            this.procPrice_label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Italic);
            this.procPrice_label.Location = new System.Drawing.Point(-2, 201);
            this.procPrice_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.procPrice_label.Name = "procPrice_label";
            this.procPrice_label.Size = new System.Drawing.Size(483, 49);
            this.procPrice_label.TabIndex = 11;
            this.procPrice_label.Text = "Стоимость: 0 Руб";
            this.procPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(38, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(12, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Мастер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(30, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Услуга";
            // 
            // UserProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1764, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.find_textBox);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procs_dataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserProcedure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procs_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox find_textBox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox user_pictureBox;
        private System.Windows.Forms.DataGridView procs_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label userFIO_label;
        private System.Windows.Forms.LinkLabel userReg_linkLabel;
        private System.Windows.Forms.Label userPhone_label;
        private System.Windows.Forms.Label userGen_label;
        private System.Windows.Forms.Label userBDate_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label procName_label;
        private System.Windows.Forms.Label procDate_label;
        private System.Windows.Forms.Label procID_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label procPrice_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label procWorker_label;
        private System.Windows.Forms.Label label6;
    }
}