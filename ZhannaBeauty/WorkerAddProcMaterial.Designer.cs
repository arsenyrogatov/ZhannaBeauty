namespace ZhannaBeauty
{
    partial class WorkerAddProcMaterial
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
            this.material_dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.caption_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.material_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(383, 248);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(138, 27);
            this.cancel_button.TabIndex = 24;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.Location = new System.Drawing.Point(239, 248);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(138, 27);
            this.ok_button.TabIndex = 23;
            this.ok_button.Text = "Ок";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.count_numericUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.material_dataGridView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(17, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 189);
            this.panel1.TabIndex = 22;
            // 
            // material_dataGridView
            // 
            this.material_dataGridView.AllowUserToAddRows = false;
            this.material_dataGridView.AllowUserToDeleteRows = false;
            this.material_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.material_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.material_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.material_dataGridView.Location = new System.Drawing.Point(94, 13);
            this.material_dataGridView.MultiSelect = false;
            this.material_dataGridView.Name = "material_dataGridView";
            this.material_dataGridView.ReadOnly = true;
            this.material_dataGridView.RowHeadersVisible = false;
            this.material_dataGridView.RowHeadersWidth = 72;
            this.material_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.material_dataGridView.Size = new System.Drawing.Size(399, 131);
            this.material_dataGridView.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Материал";
            // 
            // caption_label
            // 
            this.caption_label.AutoSize = true;
            this.caption_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.caption_label.Location = new System.Drawing.Point(12, 9);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(341, 30);
            this.caption_label.TabIndex = 21;
            this.caption_label.Text = "Добавить расходный материал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(7, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Количество";
            // 
            // count_numericUpDown
            // 
            this.count_numericUpDown.Location = new System.Drawing.Point(94, 149);
            this.count_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_numericUpDown.Name = "count_numericUpDown";
            this.count_numericUpDown.Size = new System.Drawing.Size(399, 25);
            this.count_numericUpDown.TabIndex = 21;
            this.count_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // WorkerAddProcMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 295);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caption_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerAddProcMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerAddProcMaterial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.material_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView material_dataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.NumericUpDown count_numericUpDown;
        private System.Windows.Forms.Label label2;
    }
}