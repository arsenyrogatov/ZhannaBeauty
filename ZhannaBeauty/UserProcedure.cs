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
    public partial class UserProcedure : Form
    {
        public User user;
        const string textHint = "Поиск по названию услуги или ФИО мастера...";
        Proc currentProc;

        public UserProcedure(User user)
        {
            InitializeComponent();
            this.user = user;
            UpdateUser();
        }

        private void find_textBox_Enter(object sender, EventArgs e)
        {
            if (find_textBox.Text == textHint)
            {
                find_textBox.Text = "";
                find_textBox.ForeColor = Color.Black;
            }
        }

        private void find_textBox_Leave(object sender, EventArgs e)
        {
            if (find_textBox.Text.Length == 0)
            {
                find_textBox.Text = textHint;
                find_textBox.ForeColor = Color.Gray;
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            if (find_textBox.Text != textHint)
            {
                ((DataTable)procs_dataGridView.DataSource).DefaultView.RowFilter = $"[Услуга] LIKE '%{find_textBox.Text}%' OR [ФИО мастера] LIKE '%{find_textBox.Text}%'";
            }
        }

        public void UpdateUser()
        {
            user.GetInfo();
            userFIO_label.Text = user.FIO;
            userBDate_label.Text = user.Birth.ToString("D");
            userGen_label.Text = user.Gen == 'Ж' ? "Женский" : "Мужской";
            userPhone_label.Text = user.Phone.ToString();

            procs_dataGridView.DataSource = user.GetUserProc();
            procs_dataGridView.Columns[4].Visible = false;
            user_pictureBox.Image = user.Gen == 'Ж' ? Properties.Resources.Female_User : Properties.Resources.User_Male;
        }

        private void procs_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (procs_dataGridView.Rows.Count != 0)
            {
                currentProc = new Proc(int.Parse(procs_dataGridView.CurrentRow.Cells[0].Value.ToString()),
                   procs_dataGridView.CurrentRow.Cells[1].Value.ToString(),
                   DateTime.Parse(procs_dataGridView.CurrentRow.Cells[2].Value.ToString()),
                   procs_dataGridView.CurrentRow.Cells[3].Value.ToString());

                procID_label.Text = currentProc.ID.ToString();
                procDate_label.Text = currentProc.recDate.ToString();
                procName_label.Text = currentProc.Name;
                procPrice_label.Text = $"Стоимость: {procs_dataGridView.CurrentRow.Cells[4].Value.ToString()} Руб";
                procWorker_label.Text = currentProc.WorkerFIO;
            }
            else
            {
                procID_label.Text = "-";
                procDate_label.Text = "-";
                procName_label.Text = "-";
                procPrice_label.Text = $"Стоимость: 0 Руб";
                procWorker_label.Text = "-";
            }
        }

        private void userReg_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration(true);
            userRegistration.fillUserInfo(user);
            userRegistration.FormClosing += (object se, FormClosingEventArgs ee) => { UpdateUser(); };
            userRegistration.ShowDialog();
        }
    }
}
