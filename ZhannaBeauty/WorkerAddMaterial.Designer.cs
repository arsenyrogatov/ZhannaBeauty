namespace ZhannaBeauty
{
    partial class WorkerAddMaterial
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
            this.count_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.caption_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mesunit_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(239, 173);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(138, 27);
            this.cancel_button.TabIndex = 28;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.Location = new System.Drawing.Point(95, 173);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(138, 27);
            this.ok_button.TabIndex = 27;
            this.ok_button.Text = "Ок";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mesunit_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.count_numericUpDown);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.name_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(17, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 114);
            this.panel1.TabIndex = 26;
            // 
            // count_numericUpDown
            // 
            this.count_numericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.count_numericUpDown.Location = new System.Drawing.Point(104, 40);
            this.count_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.count_numericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.count_numericUpDown.Name = "count_numericUpDown";
            this.count_numericUpDown.Size = new System.Drawing.Size(240, 25);
            this.count_numericUpDown.TabIndex = 37;
            this.count_numericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label22.Location = new System.Drawing.Point(17, 44);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 17);
            this.label22.TabIndex = 36;
            this.label22.Text = "Количество";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(104, 9);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(240, 25);
            this.name_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(34, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название";
            // 
            // caption_label
            // 
            this.caption_label.AutoSize = true;
            this.caption_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.caption_label.Location = new System.Drawing.Point(12, 9);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(256, 30);
            this.caption_label.TabIndex = 25;
            this.caption_label.Text = "Добавление материала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ед. измерения";
            // 
            // mesunit_textBox
            // 
            this.mesunit_textBox.Location = new System.Drawing.Point(104, 71);
            this.mesunit_textBox.Name = "mesunit_textBox";
            this.mesunit_textBox.Size = new System.Drawing.Size(240, 25);
            this.mesunit_textBox.TabIndex = 39;
            // 
            // WorkerAddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 222);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caption_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerAddMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Material";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown count_numericUpDown;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.TextBox mesunit_textBox;
        private System.Windows.Forms.Label label1;
    }
}