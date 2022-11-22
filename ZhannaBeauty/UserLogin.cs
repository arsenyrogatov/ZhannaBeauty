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
    public partial class UserLogin : Form
    {
        public UserLogin()
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
                    UserRec clientMainForm = new UserRec(user);
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
            UserRegistration clientRegistration = new UserRegistration();
            clientRegistration.ShowDialog();
        }

        private void worker_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WorkerLogin workerLogin = new WorkerLogin();
            workerLogin.FormClosing += (object se, FormClosingEventArgs ee) => { this.Visible = true; };
            this.Visible = false;
            workerLogin.ShowDialog();
        }
    }
}
