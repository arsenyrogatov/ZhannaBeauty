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
    public partial class WorkerLogin : Form
    {
        public WorkerLogin()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username_textBox.MaskCompleted && pwd_textBox.Text.Length != 0)
            {
                Worker worker = new Worker();
                if (!worker.TryLogin(int.Parse(username_textBox.Text), pwd_textBox.Text))
                    MessageBox.Show("Неправильный логин или пароль!");
                else
                {
                    WorkerProcedure workerProcedure = new WorkerProcedure(worker);
                    workerProcedure.FormClosing += (object se, FormClosingEventArgs ee) => { this.Visible = true; };
                    this.Visible = false;
                    workerProcedure.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных!");
            }
        }
    }
}
