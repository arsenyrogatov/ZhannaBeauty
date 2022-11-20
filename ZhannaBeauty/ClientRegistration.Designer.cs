namespace ZhannaBeauty
{
    partial class ClientRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.birth_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.genF_radioButton = new System.Windows.Forms.RadioButton();
            this.genM_radioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pwd2_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pwd1_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_button = new System.Windows.Forms.Button();
            this.phone_textBox = new System.Windows.Forms.MaskedTextBox();
            this.FIO_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(29, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата рождения";
            // 
            // birth_dateTimePicker
            // 
            this.birth_dateTimePicker.Location = new System.Drawing.Point(138, 46);
            this.birth_dateTimePicker.Name = "birth_dateTimePicker";
            this.birth_dateTimePicker.Size = new System.Drawing.Size(170, 25);
            this.birth_dateTimePicker.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(100, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пол";
            // 
            // genF_radioButton
            // 
            this.genF_radioButton.AutoSize = true;
            this.genF_radioButton.Checked = true;
            this.genF_radioButton.Location = new System.Drawing.Point(140, 84);
            this.genF_radioButton.Name = "genF_radioButton";
            this.genF_radioButton.Size = new System.Drawing.Size(83, 21);
            this.genF_radioButton.TabIndex = 6;
            this.genF_radioButton.TabStop = true;
            this.genF_radioButton.Text = "Женщина";
            this.genF_radioButton.UseVisualStyleBackColor = true;
            // 
            // genM_radioButton
            // 
            this.genM_radioButton.AutoSize = true;
            this.genM_radioButton.Location = new System.Drawing.Point(229, 84);
            this.genM_radioButton.Name = "genM_radioButton";
            this.genM_radioButton.Size = new System.Drawing.Size(81, 21);
            this.genM_radioButton.TabIndex = 7;
            this.genM_radioButton.Text = "Мужчина";
            this.genM_radioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(73, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Телефон";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.phone_textBox);
            this.panel1.Controls.Add(this.pwd2_textBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pwd1_textBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FIO_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.genM_radioButton);
            this.panel1.Controls.Add(this.birth_dateTimePicker);
            this.panel1.Controls.Add(this.genF_radioButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(17, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 229);
            this.panel1.TabIndex = 10;
            // 
            // pwd2_textBox
            // 
            this.pwd2_textBox.Location = new System.Drawing.Point(138, 186);
            this.pwd2_textBox.Name = "pwd2_textBox";
            this.pwd2_textBox.Size = new System.Drawing.Size(170, 25);
            this.pwd2_textBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(5, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Повторите пароль";
            // 
            // pwd1_textBox
            // 
            this.pwd1_textBox.Location = new System.Drawing.Point(138, 151);
            this.pwd1_textBox.Name = "pwd1_textBox";
            this.pwd1_textBox.Size = new System.Drawing.Size(170, 25);
            this.pwd1_textBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(79, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пароль";
            // 
            // reg_button
            // 
            this.reg_button.AutoSize = true;
            this.reg_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_button.Location = new System.Drawing.Point(181, 286);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(159, 27);
            this.reg_button.TabIndex = 10;
            this.reg_button.Text = "Зарегистрироваться!";
            this.reg_button.UseVisualStyleBackColor = true;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(138, 116);
            this.phone_textBox.Mask = "000000000";
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(170, 25);
            this.phone_textBox.TabIndex = 14;
            // 
            // FIO_textBox
            // 
            this.FIO_textBox.Location = new System.Drawing.Point(138, 11);
            this.FIO_textBox.Name = "FIO_textBox";
            this.FIO_textBox.Size = new System.Drawing.Size(170, 25);
            this.FIO_textBox.TabIndex = 2;
            // 
            // ClientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 328);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birth_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton genF_radioButton;
        private System.Windows.Forms.RadioButton genM_radioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reg_button;
        private System.Windows.Forms.TextBox pwd2_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pwd1_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox phone_textBox;
        private System.Windows.Forms.TextBox FIO_textBox;
    }
}