namespace ZhannaBeauty
{
    partial class WorkerAddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkerAddService));
            this.cancel_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.servPrice_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.servName_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.caption_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servPrice_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.AutoSize = true;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(418, 243);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(242, 47);
            this.cancel_button.TabIndex = 24;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // ok_button
            // 
            this.ok_button.AutoSize = true;
            this.ok_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_button.Location = new System.Drawing.Point(166, 243);
            this.ok_button.Margin = new System.Windows.Forms.Padding(5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(242, 47);
            this.ok_button.TabIndex = 23;
            this.ok_button.Text = "Ок";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.servPrice_numericUpDown);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.servName_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(30, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 138);
            this.panel1.TabIndex = 22;
            // 
            // servPrice_numericUpDown
            // 
            this.servPrice_numericUpDown.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.servPrice_numericUpDown.Location = new System.Drawing.Point(166, 70);
            this.servPrice_numericUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.servPrice_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.servPrice_numericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.servPrice_numericUpDown.Name = "servPrice_numericUpDown";
            this.servPrice_numericUpDown.Size = new System.Drawing.Size(436, 38);
            this.servPrice_numericUpDown.TabIndex = 37;
            this.servPrice_numericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label22.Location = new System.Drawing.Point(14, 77);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(144, 31);
            this.label22.TabIndex = 36;
            this.label22.Text = "Стоимость";
            // 
            // servName_textBox
            // 
            this.servName_textBox.Location = new System.Drawing.Point(166, 16);
            this.servName_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.servName_textBox.Name = "servName_textBox";
            this.servName_textBox.Size = new System.Drawing.Size(433, 38);
            this.servName_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(44, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название";
            // 
            // caption_label
            // 
            this.caption_label.AutoSize = true;
            this.caption_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic);
            this.caption_label.Location = new System.Drawing.Point(21, 16);
            this.caption_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.caption_label.Name = "caption_label";
            this.caption_label.Size = new System.Drawing.Size(350, 51);
            this.caption_label.TabIndex = 21;
            this.caption_label.Text = "Добавление услуги";
            // 
            // WorkerAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 313);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.caption_label);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerAddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление услуги";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servPrice_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label caption_label;
        private System.Windows.Forms.TextBox servName_textBox;
        private System.Windows.Forms.NumericUpDown servPrice_numericUpDown;
        private System.Windows.Forms.Label label22;
    }
}