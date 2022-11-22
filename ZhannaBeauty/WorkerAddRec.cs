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
    public partial class WorkerAddRec : Form
    {
        public WorkerAddRec()
        {
            InitializeComponent();

            rec_dateTimePicker.Format = DateTimePickerFormat.Custom;
            rec_dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";

            client_dataGridView.DataSource = UserTools.GetUsers();
            client_dataGridView.Columns[2].Visible = false;
            client_dataGridView.Columns[3].Visible = false;
            client_dataGridView.Columns[5].Visible = false;

            service_dataGridView.DataSource = ServiceTools.GetServices();
            service_dataGridView.Columns[1].Visible = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (client_dataGridView.Rows.Count > 0 && service_dataGridView.SelectedRows.Count > 0)
            {
                RecTools.AddRec(int.Parse(client_dataGridView.CurrentRow.Cells[0].Value.ToString()), rec_dateTimePicker.Value, service_dataGridView.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Запись добавлена");
                Close();
            }
            else
            {
                MessageBox.Show("Выберите клиента и услугу для записи!");
            }
        }
    }
}
