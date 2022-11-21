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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
            birth_dateTimePicker.MaxDate = DateTime.Now;
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
                    if (UserTools.AddUser(FIO_textBox.Text, birth_dateTimePicker.Value, genF_radioButton.Checked ? 'М' : 'Ж', int.Parse(phone_textBox.Text), pwd1_textBox.Text))
                    {
                        MessageBox.Show("Вы зарегистированы!");
                        Close();
                    }
                    else
                        MessageBox.Show("Пользователь с таким номером уже существует!");
                    
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных!");
                }
            }
        }
    }
}
