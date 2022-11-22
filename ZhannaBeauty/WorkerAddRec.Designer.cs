namespace ZhannaBeauty
{
    partial class WorkerAddRec
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
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.service_dataGridView = new System.Windows.Forms.DataGridView();
            this.rec_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.caption_label = new System.Windows.Forms.Label();
            this.client_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(383, 379);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(138, 27);
            this.cancel_button.TabIndex = 20;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.Location = new System.Drawing.Point(239, 379);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(138, 27);
            this.ok_button.TabIndex = 19;
            this.ok_button.Text = "Ок";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.client_dataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.service_dataGridView);
            this.panel1.Controls.Add(this.rec_dateTimePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(17, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 320);
            this.panel1.TabIndex = 18;
            // 
            // service_dataGridView
            // 
            this.service_dataGridView.AllowUserToAddRows = false;
            this.service_dataGridView.AllowUserToDeleteRows = false;
            this.service_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.service_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.service_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.service_dataGridView.Location = new System.Drawing.Point(61, 177);
            this.service_dataGridView.MultiSelect = false;
            this.service_dataGridView.Name = "service_dataGridView";
            this.service_dataGridView.ReadOnly = true;
            this.service_dataGridView.RowHeadersVisible = false;
            this.service_dataGridView.RowHeadersWidth = 72;
            this.service_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.service_dataGridView.Size = new System.Drawing.Size(431, 131);
            this.service_dataGridView.TabIndex = 17;
            // 
            // rec_dateTimePicker
            // 
            this.rec_dateTimePicker.Location = new System.Drawing.Point(61, 9);
            this.rec_dateTimePicker.Name = "rec_dateTimePicker";
            this.rec_dateTimePicker.Size = new System.Drawing.Size(431, 25);
            this.rec_dateTimePicker.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(9, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Услуга";
            // 
            // caption_label
            // 
            this.caption_label.AutoSize = true;
            this.caption_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.caption_label.Location = new System.Drawing.Point(12, 9);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(182, 30);
            this.caption_label.TabIndex = 17;
            this.caption_label.Text = "Запись на услугу";
            // 
            // client_dataGridView
            // 
            this.client_dataGridView.AllowUserToAddRows = false;
            this.client_dataGridView.AllowUserToDeleteRows = false;
            this.client_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.client_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.client_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_dataGridView.Location = new System.Drawing.Point(61, 40);
            this.client_dataGridView.MultiSelect = false;
            this.client_dataGridView.Name = "client_dataGridView";
            this.client_dataGridView.ReadOnly = true;
            this.client_dataGridView.RowHeadersVisible = false;
            this.client_dataGridView.RowHeadersWidth = 72;
            this.client_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.client_dataGridView.Size = new System.Drawing.Size(431, 131);
            this.client_dataGridView.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Клиент";
            // 
            // WorkerAddRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 422);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caption_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerAddRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerAddRec";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.service_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView service_dataGridView;
        public System.Windows.Forms.DateTimePicker rec_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.DataGridView client_dataGridView;
        private System.Windows.Forms.Label label1;
    }
}