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
    public partial class UserAddRec : Form
    {
        Rec currentRec;
        int usrId;
        bool editMode;

        public UserAddRec(Rec rec, int userId, bool editMode = false)
        {
            InitializeComponent();
            usrId = userId;
            this.editMode = editMode; 
            currentRec = rec;

            rec_dateTimePicker.Format = DateTimePickerFormat.Custom;
            rec_dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            
            service_dataGridView.DataSource = ServiceTools.GetServices();
            rec_dateTimePicker.MinDate = DateTime.Now.AddHours(1);
            service_dataGridView.Columns[1].Visible = false;

            if (editMode)
            {
                caption_label.Text = "Изменить запись";
                ok_button.Text = "Изменить";
                rec_dateTimePicker.Value = rec.recDate;
            }
        }

        private void service_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ok_button.Enabled = false;
            if (service_dataGridView.SelectedRows.Count > 0)
            {
                ok_button.Enabled = true;
                price_label.Text = $"Стоимость: {service_dataGridView.SelectedRows[0].Cells[1].Value.ToString()} Руб";
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                RecTools.AddRec(usrId, rec_dateTimePicker.Value, service_dataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                currentRec.recDate = rec_dateTimePicker.Value;
                currentRec.Name = service_dataGridView.CurrentRow.Cells[0].Value.ToString();
                currentRec.UpdateUserRec();
            }
            Close();
        
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
