using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZhannaBeauty
{
    public partial class UserRec : Form
    {
        public User user;
        const string textHint = "Поиск по названию услуги...";

        public UserRec()
        {
            InitializeComponent();
        }

        public void InitializeUser (User user_)
        {
            user = user_;
            UpdateUser();
        }

        public void UpdateUser()
        {
            user_linkLabel.Text = user.FIO;
            recs_dataGridView.DataSource = user.GetUserRecs();
            recs_dataGridView.Columns[3].Visible = false;
            user_pictureBox.Image = user.Gen == 'Ж' ? Properties.Resources.Female_User : Properties.Resources.User_Male;
        }

        Rec currentRec;

        private void services_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            edit_button.Visible = false;
            cancel_button.Visible = false;

            if (recs_dataGridView.Rows.Count != 0)
            {
                currentRec = new Rec(int.Parse(recs_dataGridView.CurrentRow.Cells[0].Value.ToString()),
                   recs_dataGridView.CurrentRow.Cells[2].Value.ToString(),
                   DateTime.Parse(recs_dataGridView.CurrentRow.Cells[1].Value.ToString()),
                   recs_dataGridView.CurrentRow.Cells[4].Value.ToString());

                recID_label.Text = currentRec.ID.ToString();
                recDate_label.Text = currentRec.recDate.ToString();
                recName_label.Text = currentRec.Name;
                recPrice_label.Text = $"Стоимость: {recs_dataGridView.CurrentRow.Cells[3].Value.ToString()} Руб";
                recStatus_label.Text = recs_dataGridView.CurrentRow.Cells[4].Value.ToString();

                if (recStatus_label.Text == "Создана")
                {
                    edit_button.Visible = true;
                    cancel_button.Visible = true;
                }
            }
            else
            {
                recID_label.Text = "-";
                recDate_label.Text = "-";
                recName_label.Text = "-";
                recPrice_label.Text = $"Стоимость: 0 Руб";
                recStatus_label.Text = "-";
            }
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
                ((DataTable)recs_dataGridView.DataSource).DefaultView.RowFilter = $"[Услуга] LIKE '%{find_textBox.Text}%'";
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены что хотите отменить запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentRec.Status = "Отменена пользователем";
                currentRec.UpdateUserRec();
                MessageBox.Show("Запись отменена!");
                UpdateUser();
            }
        }

        private void addServ_button_Click(object sender, EventArgs e)
        {
            UserAddRec userRecs = new UserAddRec(currentRec, user.Id);
            userRecs.FormClosed += (object se, FormClosedEventArgs fcea) => { UpdateUser(); };
            userRecs.ShowDialog();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            UserAddRec userRecs = new UserAddRec(currentRec, user.Id, true);
            userRecs.rec_dateTimePicker.MinDate = DateTime.Parse(recDate_label.Text) < DateTime.Now? DateTime.Parse(recDate_label.Text) : DateTime.Now;
            userRecs.rec_dateTimePicker.Value = DateTime.Parse(recDate_label.Text);
            userRecs.FormClosed += (object se, FormClosedEventArgs fcea) => { UpdateUser(); };
            userRecs.ShowDialog();
        }

    }
}
