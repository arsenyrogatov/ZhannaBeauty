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
        User user;
        bool isEdit;
        bool isWorker;

        public UserRegistration(bool editMode = false, bool workerMode = false)
        {
            InitializeComponent();
            isEdit = editMode;
            birth_dateTimePicker.MaxDate = DateTime.Now;
            if (isEdit)
            {
                Text = "Изменение данных о пользователе";
                caption_label.Text = "Изменить данные";
                reg_button.Text = "Сохранить";
            }
            if (workerMode)
            {
                Text = "Добавление нового пользователя";
                caption_label.Text = "Добавить пользователя";
                reg_button.Text = "Сохранить";
            }
        }

        public void fillUserInfo (User usr)
        {
            user = usr;
            user.GetInfo();
            FIO_textBox.Text = user.FIO;
            birth_dateTimePicker.Value = user.Birth;
            genF_radioButton.Checked = user.Gen == 'Ж';
            genM_radioButton.Checked = user.Gen == 'М';
            phone_textBox.Text = user.Phone.ToString();
            pwd1_textBox.Text = user.pass;
            pwd2_textBox.Text = user.pass;
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
                    if (!isEdit)
                    {
                        if (UserTools.AddUser(FIO_textBox.Text, birth_dateTimePicker.Value, genF_radioButton.Checked ? 'Ж' : 'М', int.Parse(phone_textBox.Text), pwd1_textBox.Text))
                        {
                            if (!isWorker)
                                MessageBox.Show("Вы зарегистированы!");
                            else
                                MessageBox.Show("Пользователь добавлен!");
                            Close();
                        }
                        else
                            MessageBox.Show("Пользователь с таким номером уже существует!");
                    }
                    else
                    {
                        user.FIO = FIO_textBox.Text;
                        user.Birth = birth_dateTimePicker.Value;
                        user.Gen = genF_radioButton.Checked ? 'Ж' : 'М';
                        user.Phone = int.Parse(phone_textBox.Text);
                        user.pass = pwd1_textBox.Text;
                        user.UpdateUserInfo();
                        MessageBox.Show("Данные сохранены!");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Проверьте правильность введенных данных!");
                }
            }
        }
    }
}
