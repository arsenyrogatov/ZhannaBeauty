namespace ZhannaBeauty
{
    partial class UserMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.services_dataGridView = new System.Windows.Forms.DataGridView();
            this.editUser_linkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_pictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.servPrice_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.servWorker_label = new System.Windows.Forms.Label();
            this.servName_label = new System.Windows.Forms.Label();
            this.servDate_label = new System.Windows.Forms.Label();
            this.servID_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.addServ_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.find_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.services_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваши записи";
            // 
            // services_dataGridView
            // 
            this.services_dataGridView.AllowUserToAddRows = false;
            this.services_dataGridView.AllowUserToDeleteRows = false;
            this.services_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.services_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.services_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.services_dataGridView.Location = new System.Drawing.Point(17, 53);
            this.services_dataGridView.MultiSelect = false;
            this.services_dataGridView.Name = "services_dataGridView";
            this.services_dataGridView.ReadOnly = true;
            this.services_dataGridView.RowHeadersVisible = false;
            this.services_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.services_dataGridView.Size = new System.Drawing.Size(824, 365);
            this.services_dataGridView.TabIndex = 2;
            this.services_dataGridView.SelectionChanged += new System.EventHandler(this.services_dataGridView_SelectionChanged);
            // 
            // editUser_linkLabel
            // 
            this.editUser_linkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.editUser_linkLabel.Location = new System.Drawing.Point(847, 6);
            this.editUser_linkLabel.Name = "editUser_linkLabel";
            this.editUser_linkLabel.Size = new System.Drawing.Size(244, 38);
            this.editUser_linkLabel.TabIndex = 5;
            this.editUser_linkLabel.TabStop = true;
            this.editUser_linkLabel.Text = "Фамилия И.О.";
            this.editUser_linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(847, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Информация о записи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(59, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "№";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(40, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(35, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Услуга";
            // 
            // user_pictureBox
            // 
            this.user_pictureBox.Image = global::ZhannaBeauty.Properties.Resources.Female_User;
            this.user_pictureBox.Location = new System.Drawing.Point(1092, 4);
            this.user_pictureBox.Name = "user_pictureBox";
            this.user_pictureBox.Size = new System.Drawing.Size(39, 40);
            this.user_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox.TabIndex = 4;
            this.user_pictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сотрудник";
            // 
            // servPrice_label
            // 
            this.servPrice_label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Italic);
            this.servPrice_label.Location = new System.Drawing.Point(-1, 137);
            this.servPrice_label.Name = "servPrice_label";
            this.servPrice_label.Size = new System.Drawing.Size(276, 28);
            this.servPrice_label.TabIndex = 11;
            this.servPrice_label.Text = "Стоимость: 0 Руб";
            this.servPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.servWorker_label);
            this.panel1.Controls.Add(this.servName_label);
            this.panel1.Controls.Add(this.servDate_label);
            this.panel1.Controls.Add(this.servID_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.servPrice_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(851, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 171);
            this.panel1.TabIndex = 12;
            // 
            // servWorker_label
            // 
            this.servWorker_label.Location = new System.Drawing.Point(83, 108);
            this.servWorker_label.Name = "servWorker_label";
            this.servWorker_label.Size = new System.Drawing.Size(191, 17);
            this.servWorker_label.TabIndex = 15;
            this.servWorker_label.Text = "-";
            // 
            // servName_label
            // 
            this.servName_label.Location = new System.Drawing.Point(83, 74);
            this.servName_label.Name = "servName_label";
            this.servName_label.Size = new System.Drawing.Size(191, 17);
            this.servName_label.TabIndex = 14;
            this.servName_label.Text = "-";
            // 
            // servDate_label
            // 
            this.servDate_label.Location = new System.Drawing.Point(83, 40);
            this.servDate_label.Name = "servDate_label";
            this.servDate_label.Size = new System.Drawing.Size(191, 17);
            this.servDate_label.TabIndex = 13;
            this.servDate_label.Text = "-";
            // 
            // servID_label
            // 
            this.servID_label.Location = new System.Drawing.Point(83, 8);
            this.servID_label.Name = "servID_label";
            this.servID_label.Size = new System.Drawing.Size(191, 17);
            this.servID_label.TabIndex = 12;
            this.servID_label.Text = "-";
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(993, 259);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(138, 27);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Отменить запись";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // edit_button
            // 
            this.edit_button.AutoSize = true;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(850, 259);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(138, 27);
            this.edit_button.TabIndex = 14;
            this.edit_button.Text = "Изменить запись";
            this.edit_button.UseVisualStyleBackColor = true;
            // 
            // addServ_button
            // 
            this.addServ_button.AutoSize = true;
            this.addServ_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addServ_button.Location = new System.Drawing.Point(850, 388);
            this.addServ_button.Name = "addServ_button";
            this.addServ_button.Size = new System.Drawing.Size(281, 30);
            this.addServ_button.TabIndex = 15;
            this.addServ_button.Text = "Записаться на услугу!";
            this.addServ_button.UseVisualStyleBackColor = true;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(766, 13);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(75, 25);
            this.find_button.TabIndex = 16;
            this.find_button.Text = "Поиск";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // find_textBox
            // 
            this.find_textBox.ForeColor = System.Drawing.Color.Gray;
            this.find_textBox.Location = new System.Drawing.Point(429, 13);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(331, 25);
            this.find_textBox.TabIndex = 17;
            this.find_textBox.Text = "Поиск по ФИО мастера или названию услуги...";
            this.find_textBox.Enter += new System.EventHandler(this.find_textBox_Enter);
            this.find_textBox.Leave += new System.EventHandler(this.find_textBox_Leave);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 440);
            this.Controls.Add(this.find_textBox);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.addServ_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editUser_linkLabel);
            this.Controls.Add(this.user_pictureBox);
            this.Controls.Add(this.services_dataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Салон красоты ZHANNA";
            ((System.ComponentModel.ISupportInitialize)(this.services_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView services_dataGridView;
        private System.Windows.Forms.PictureBox user_pictureBox;
        private System.Windows.Forms.LinkLabel editUser_linkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label servPrice_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label servWorker_label;
        private System.Windows.Forms.Label servName_label;
        private System.Windows.Forms.Label servDate_label;
        private System.Windows.Forms.Label servID_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button addServ_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.TextBox find_textBox;
    }
}