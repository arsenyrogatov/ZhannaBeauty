using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhannaBeauty
{
    public partial class WorkerAddService : Form
    {
        public WorkerAddService()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (servName_textBox.Text.Length > 0)
            {
                if (ServiceTools.AddService(servName_textBox.Text, servPrice_numericUpDown.Value) == 0)
                {
                    MessageBox.Show("Услуга добавлена!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при добавлении услуги!");
                }
            }
            else
            {
                MessageBox.Show("Заполните название услуги!");
            }
        }
    }
}
