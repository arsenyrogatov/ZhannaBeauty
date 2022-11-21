namespace ZhannaBeauty
{
    partial class UserRec
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
            this.recs_dataGridView = new System.Windows.Forms.DataGridView();
            this.user_linkLabel = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.user_pictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recPrice_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recStatus_label = new System.Windows.Forms.Label();
            this.recName_label = new System.Windows.Forms.Label();
            this.recDate_label = new System.Windows.Forms.Label();
            this.recID_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.addRec_button = new System.Windows.Forms.Button();
            this.find_button = new System.Windows.Forms.Button();
            this.find_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.recs_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваши записи";
            // 
            // recs_dataGridView
            // 
            this.recs_dataGridView.AllowUserToAddRows = false;
            this.recs_dataGridView.AllowUserToDeleteRows = false;
            this.recs_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recs_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.recs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recs_dataGridView.Location = new System.Drawing.Point(30, 93);
            this.recs_dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.recs_dataGridView.MultiSelect = false;
            this.recs_dataGridView.Name = "recs_dataGridView";
            this.recs_dataGridView.ReadOnly = true;
            this.recs_dataGridView.RowHeadersVisible = false;
            this.recs_dataGridView.RowHeadersWidth = 72;
            this.recs_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recs_dataGridView.Size = new System.Drawing.Size(1442, 639);
            this.recs_dataGridView.TabIndex = 2;
            this.recs_dataGridView.SelectionChanged += new System.EventHandler(this.services_dataGridView_SelectionChanged);
            // 
            // user_linkLabel
            // 
            this.user_linkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.user_linkLabel.Location = new System.Drawing.Point(1482, 10);
            this.user_linkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.user_linkLabel.Name = "user_linkLabel";
            this.user_linkLabel.Size = new System.Drawing.Size(427, 66);
            this.user_linkLabel.TabIndex = 5;
            this.user_linkLabel.TabStop = true;
            this.user_linkLabel.Text = "Фамилия И.О.";
            this.user_linkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(1482, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "Информация о записи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(71, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "№";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(38, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(29, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Услуга";
            // 
            // user_pictureBox
            // 
            this.user_pictureBox.Image = global::ZhannaBeauty.Properties.Resources.Female_User;
            this.user_pictureBox.Location = new System.Drawing.Point(1911, 7);
            this.user_pictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.user_pictureBox.Name = "user_pictureBox";
            this.user_pictureBox.Size = new System.Drawing.Size(68, 70);
            this.user_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_pictureBox.TabIndex = 4;
            this.user_pictureBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(10, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Статус";
            // 
            // recPrice_label
            // 
            this.recPrice_label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Italic);
            this.recPrice_label.Location = new System.Drawing.Point(-2, 240);
            this.recPrice_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.recPrice_label.Name = "recPrice_label";
            this.recPrice_label.Size = new System.Drawing.Size(483, 49);
            this.recPrice_label.TabIndex = 11;
            this.recPrice_label.Text = "Стоимость: 0 Руб";
            this.recPrice_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.recStatus_label);
            this.panel1.Controls.Add(this.recName_label);
            this.panel1.Controls.Add(this.recDate_label);
            this.panel1.Controls.Add(this.recID_label);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.recPrice_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(1489, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 298);
            this.panel1.TabIndex = 12;
            // 
            // recStatus_label
            // 
            this.recStatus_label.Location = new System.Drawing.Point(115, 190);
            this.recStatus_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.recStatus_label.Name = "recStatus_label";
            this.recStatus_label.Size = new System.Drawing.Size(334, 30);
            this.recStatus_label.TabIndex = 15;
            this.recStatus_label.Text = "-";
            // 
            // recName_label
            // 
            this.recName_label.Location = new System.Drawing.Point(115, 131);
            this.recName_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.recName_label.Name = "recName_label";
            this.recName_label.Size = new System.Drawing.Size(334, 30);
            this.recName_label.TabIndex = 14;
            this.recName_label.Text = "-";
            // 
            // recDate_label
            // 
            this.recDate_label.Location = new System.Drawing.Point(115, 71);
            this.recDate_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.recDate_label.Name = "recDate_label";
            this.recDate_label.Size = new System.Drawing.Size(334, 30);
            this.recDate_label.TabIndex = 13;
            this.recDate_label.Text = "-";
            // 
            // recID_label
            // 
            this.recID_label.Location = new System.Drawing.Point(115, 15);
            this.recID_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.recID_label.Name = "recID_label";
            this.recID_label.Size = new System.Drawing.Size(334, 30);
            this.recID_label.TabIndex = 12;
            this.recID_label.Text = "-";
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(1738, 453);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(242, 47);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Отменить запись";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Visible = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.AutoSize = true;
            this.edit_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(1488, 453);
            this.edit_button.Margin = new System.Windows.Forms.Padding(5);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(242, 47);
            this.edit_button.TabIndex = 14;
            this.edit_button.Text = "Изменить запись";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Visible = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // addRec_button
            // 
            this.addRec_button.AutoSize = true;
            this.addRec_button.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRec_button.Location = new System.Drawing.Point(1488, 679);
            this.addRec_button.Margin = new System.Windows.Forms.Padding(5);
            this.addRec_button.Name = "addRec_button";
            this.addRec_button.Size = new System.Drawing.Size(492, 52);
            this.addRec_button.TabIndex = 15;
            this.addRec_button.Text = "Записаться на услугу!";
            this.addRec_button.UseVisualStyleBackColor = true;
            this.addRec_button.Click += new System.EventHandler(this.addServ_button_Click);
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(1340, 23);
            this.find_button.Margin = new System.Windows.Forms.Padding(5);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(131, 44);
            this.find_button.TabIndex = 16;
            this.find_button.Text = "Поиск";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // find_textBox
            // 
            this.find_textBox.ForeColor = System.Drawing.Color.Gray;
            this.find_textBox.Location = new System.Drawing.Point(751, 23);
            this.find_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.find_textBox.Name = "find_textBox";
            this.find_textBox.Size = new System.Drawing.Size(576, 38);
            this.find_textBox.TabIndex = 17;
            this.find_textBox.Text = "Поиск по названию услуги...";
            this.find_textBox.TextChanged += new System.EventHandler(this.find_button_Click);
            this.find_textBox.Enter += new System.EventHandler(this.find_textBox_Enter);
            this.find_textBox.Leave += new System.EventHandler(this.find_textBox_Leave);
            // 
            // UserRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1993, 770);
            this.Controls.Add(this.find_textBox);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.addRec_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user_linkLabel);
            this.Controls.Add(this.user_pictureBox);
            this.Controls.Add(this.recs_dataGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Салон красоты ZHANNA";
            ((System.ComponentModel.ISupportInitialize)(this.recs_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView recs_dataGridView;
        private System.Windows.Forms.PictureBox user_pictureBox;
        private System.Windows.Forms.LinkLabel user_linkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label recPrice_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label recStatus_label;
        private System.Windows.Forms.Label recName_label;
        private System.Windows.Forms.Label recDate_label;
        private System.Windows.Forms.Label recID_label;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button addRec_button;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.TextBox find_textBox;
    }
}