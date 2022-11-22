namespace ZhannaBeauty
{
    partial class WorkerAddWorker
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
            this.reg_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.phone_textBox = new System.Windows.Forms.MaskedTextBox();
            this.pwd2_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pwd1_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FIO_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.caption_label = new System.Windows.Forms.Label();
            this.role_textBox = new System.Windows.Forms.TextBox();
            this.wage_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wage_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_button
            // 
            this.reg_button.AutoSize = true;
            this.reg_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.Location = new System.Drawing.Point(242, 270);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(98, 27);
            this.reg_button.TabIndex = 13;
            this.reg_button.Text = "Добавить";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.wage_numericUpDown);
            this.panel1.Controls.Add(this.role_textBox);
            this.panel1.Controls.Add(this.phone_textBox);
            this.panel1.Controls.Add(this.pwd2_textBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pwd1_textBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FIO_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(17, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 213);
            this.panel1.TabIndex = 12;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(138, 42);
            this.phone_textBox.Mask = "000000000";
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(170, 25);
            this.phone_textBox.TabIndex = 14;
            // 
            // pwd2_textBox
            // 
            this.pwd2_textBox.Location = new System.Drawing.Point(138, 170);
            this.pwd2_textBox.Name = "pwd2_textBox";
            this.pwd2_textBox.Size = new System.Drawing.Size(170, 25);
            this.pwd2_textBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(5, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Повторите пароль";
            // 
            // pwd1_textBox
            // 
            this.pwd1_textBox.Location = new System.Drawing.Point(138, 135);
            this.pwd1_textBox.Name = "pwd1_textBox";
            this.pwd1_textBox.Size = new System.Drawing.Size(170, 25);
            this.pwd1_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(79, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(40, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия И.О.";
            // 
            // FIO_textBox
            // 
            this.FIO_textBox.Location = new System.Drawing.Point(138, 11);
            this.FIO_textBox.Name = "FIO_textBox";
            this.FIO_textBox.Size = new System.Drawing.Size(170, 25);
            this.FIO_textBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(73, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(53, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Должность";
            // 
            // caption_label
            // 
            this.caption_label.AutoSize = true;
            this.caption_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.caption_label.Location = new System.Drawing.Point(12, 9);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(246, 30);
            this.caption_label.TabIndex = 11;
            this.caption_label.Text = "Добавить сотрудника";
            // 
            // role_textBox
            // 
            this.role_textBox.Location = new System.Drawing.Point(138, 73);
            this.role_textBox.Name = "role_textBox";
            this.role_textBox.Size = new System.Drawing.Size(170, 25);
            this.role_textBox.TabIndex = 15;
            // 
            // wage_numericUpDown
            // 
            this.wage_numericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wage_numericUpDown.Location = new System.Drawing.Point(138, 104);
            this.wage_numericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.wage_numericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wage_numericUpDown.Name = "wage_numericUpDown";
            this.wage_numericUpDown.Size = new System.Drawing.Size(170, 25);
            this.wage_numericUpDown.TabIndex = 16;
            this.wage_numericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(63, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Зарплата";
            // 
            // WorkerAddWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 312);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caption_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerAddWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkerAddWorker";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wage_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox phone_textBox;
        private System.Windows.Forms.TextBox pwd2_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pwd1_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIO_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown wage_numericUpDown;
        private System.Windows.Forms.TextBox role_textBox;
    }
}