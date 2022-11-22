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
    public partial class WorkerAddWorker : Form
    {
        public WorkerAddWorker()
        {
            InitializeComponent();
        }

        private void reg_button_Click(object sender, EventArgs e)
        {
            if (pwd1_textBox.Text != pwd2_textBox.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else
            {
                if (phone_textBox.MaskCompleted && FIO_textBox.Text.Split(new char[] { '.' }).Length == 3 && pwd1_textBox.Text.Length != 0)
                {
                        if (WorkerTools.AddWorker(FIO_textBox.Text, role_textBox.Text, int.Parse(phone_textBox.Text), wage_numericUpDown.Value, pwd1_textBox.Text))
                        {
                                MessageBox.Show("Сотрудник добавлен!");
                            Close();
                        }
                        else
                            MessageBox.Show("Сотрудник с таким номером уже существует!");
               
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных!");
                }
            }
        }
    }
}
