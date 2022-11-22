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
    public partial class WorkerAddProcMaterial : Form
    {
        int procId;

        public WorkerAddProcMaterial(int procId)
        {
            InitializeComponent();
            this.procId = procId;
            material_dataGridView.DataSource = MaterialTools.GetMaterials();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (material_dataGridView.Rows.Count > 0)
            {
                if (MaterialTools.AddProcMaterial(procId, material_dataGridView.CurrentRow.Cells[0].Value.ToString(), ((int)count_numericUpDown.Value)) == 0)
                {
                    MessageBox.Show("Материал добавлен!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении материала!");
                }
            }
        }
    }
}
