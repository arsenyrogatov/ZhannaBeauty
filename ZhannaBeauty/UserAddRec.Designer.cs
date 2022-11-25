namespace ZhannaBeauty
{
    partial class UserAddRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddRec));
            this.caption_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.service_dataGridView = new System.Windows.Forms.DataGridView();
            this.rec_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.price_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // caption_label
            // 
            this.caption_label.AutoSize = true;
            this.caption_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.caption_label.Location = new System.Drawing.Point(21, 16);
            this.caption_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(310, 51);
            this.caption_label.TabIndex = 2;
            this.caption_label.Text = "Запись на услугу";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.service_dataGridView);
            this.panel1.Controls.Add(this.rec_dateTimePicker);
            this.panel1.Controls.Add(this.price_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(30, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 544);
            this.panel1.TabIndex = 13;
            // 
            // service_dataGridView
            // 
            this.service_dataGridView.AllowUserToAddRows = false;
            this.service_dataGridView.AllowUserToDeleteRows = false;
            this.service_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.service_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.service_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_dataGridView.Location = new System.Drawing.Point(150, 84);
            this.service_dataGridView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.service_dataGridView.MultiSelect = false;
            this.service_dataGridView.Name = "service_dataGridView";
            this.service_dataGridView.ReadOnly = true;
            this.service_dataGridView.RowHeadersVisible = false;
            this.service_dataGridView.RowHeadersWidth = 72;
            this.service_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.service_dataGridView.Size = new System.Drawing.Size(751, 397);
            this.service_dataGridView.TabIndex = 17;
            this.service_dataGridView.SelectionChanged += new System.EventHandler(this.service_dataGridView_SelectionChanged);
            // 
            // rec_dateTimePicker
            // 
            this.rec_dateTimePicker.Location = new System.Drawing.Point(149, 19);
            this.rec_dateTimePicker.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rec_dateTimePicker.Name = "rec_dateTimePicker";
            this.rec_dateTimePicker.Size = new System.Drawing.Size(751, 38);
            this.rec_dateTimePicker.TabIndex = 16;
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Italic);
            this.price_label.Location = new System.Drawing.Point(-5, 488);
            this.price_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(1038, 49);
            this.price_label.TabIndex = 11;
            this.price_label.Text = "Стоимость: 0 RUB";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(68, 24);
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
            this.label5.Location = new System.Drawing.Point(60, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Услуга";
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.Location = new System.Drawing.Point(570, 660);
            this.ok_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(242, 47);
            this.ok_button.TabIndex = 15;
            this.ok_button.Text = "Записаться!";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(822, 660);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(242, 47);
            this.cancel_button.TabIndex = 16;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // UserAddRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1088, 733);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caption_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAddRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Записаться на услугу";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView service_dataGridView;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        public System.Windows.Forms.DateTimePicker rec_dateTimePicker;
    }
}