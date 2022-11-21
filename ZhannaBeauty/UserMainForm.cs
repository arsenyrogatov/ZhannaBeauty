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
    public partial class UserMainForm : Form
    {
        public User user;
        const string textHint = "Поиск по ФИО мастера или названию услуги...";

        public UserMainForm()
        {
            InitializeComponent();
        }

        public void InitializeUser (User user_)
        {
            user = user_;
            editUser_linkLabel.Text = user.FIO;
            services_dataGridView.DataSource = user.GetUserServices();

            user_pictureBox.Image = user.Gen == 'Ж' ? Properties.Resources.Female_User : Properties.Resources.User_Male;
        }

        private void services_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (services_dataGridView.Rows.Count != 0)
            {
                servID_label.Text = services_dataGridView.CurrentRow.Cells[0].Value.ToString();
                servDate_label.Text = services_dataGridView.CurrentRow.Cells[1].Value.ToString().Split(new char[] { ' ' }) [0];
                servName_label.Text = services_dataGridView.CurrentRow.Cells[2].Value.ToString();
                servPrice_label.Text = $"Стоимость: {services_dataGridView.CurrentRow.Cells[3].Value.ToString()} Руб";
                servWorker_label.Text = services_dataGridView.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                servID_label.Text = "-";
                servDate_label.Text = "-";
                servName_label.Text = "-";
                servPrice_label.Text = $"Стоимость: 0 Руб";
                servWorker_label.Text = "-";
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
                ((DataTable)services_dataGridView.DataSource).DefaultView.RowFilter = $"[Услуга] LIKE '%{find_textBox.Text}%' OR [ФИО мастера] LIKE '%{find_textBox.Text}%'";
                
            }
        }
    }
}
