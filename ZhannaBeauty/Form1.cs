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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userLogin_button_Click(object sender, EventArgs e)
        {
            if (username_textBox.MaskCompleted && pwd_textBox.Text.Length != 0)
            {
                User user = new User();
                if (!user.TryLogin(int.Parse(username_textBox.Text), pwd_textBox.Text))
                    MessageBox.Show("Неправильный логин или пароль!");
                else
                {
                    ClientMainForm clientMainForm = new ClientMainForm();
                    clientMainForm.InitializeUser(user);
                    clientMainForm.FormClosing += (object se, FormClosingEventArgs ee) => { this.Visible = true; };
                    this.Visible = false;
                    clientMainForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }

        private void regUser_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClientRegistration clientRegistration = new ClientRegistration();
            clientRegistration.ShowDialog();
        }
    }
}
