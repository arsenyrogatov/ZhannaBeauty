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
    public partial class WorkerAddMaterial : Form
    {
        public WorkerAddMaterial()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text.Length > 0 && mesunit_textBox.Text.Length < 3 && mesunit_textBox.Text.Length > 0)
            {
                if (MaterialTools.AddMaterial(name_textBox.Text, int.Parse(count_numericUpDown.Value.ToString()), mesunit_textBox.Text) == 0)
                {
                    MessageBox.Show("Материал добавлен!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при добавлении материала!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные!");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
