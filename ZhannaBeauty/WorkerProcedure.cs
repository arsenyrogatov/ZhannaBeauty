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
    public partial class WorkerProcedure : Form
    {
        private Worker worker;
        private Rec currentRec;
        private Service currentService;
        private User currentUser;
        private Worker currentWorker;
        private Material currentMaterial;

        const string recTextHint = "Название услуги, статус или ФИО...";
        const string servTextHint = "Название услуги...";
        const string userTextHint = "ФИО клиента...";
        const string workerTextHint = "ФИО сотрудника или должность...";
        const string matTextHint = "Название расходного материала...";
        const string procTextHint = "Название услуги или ФИО...";

        public WorkerProcedure(Worker wrkr)
        {
            InitializeComponent();

            rec_dateTimePicker.Format = DateTimePickerFormat.Custom;
            rec_dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";


            worker = wrkr;
            UpdateAll();
        }

        private void UpdateAll()
        {
            UpdateWorker();
            UpdateRecs();
            UpdateServices();
            UpdateUsers();
            UpdateWorkers();
            UpdateMaterials();
            UpdateProcedures();
        }

        private void UpdateWorker()
        {
            worker.GetInfo();
            workerFIO_label.Text = worker.FIO;
            workerPhone_label.Text = worker.Phone.ToString();
            workerRole_label.Text = worker.Role.ToString();
            workerWage_label.Text = worker.Wage.ToString() + " руб";

            if (worker.Role != "Менеджер")
            {
                tabControl.TabPages.Remove(Worker_tabPage);
                tabControl.TabPages.Remove(Client_tabPage);
            }
        }

        private void UpdateRecs()
        {
            recs_dataGridView.DataSource = RecTools.GetRecs();
        }

        private void UpdateServices()
        {
            services_dataGridView.DataSource = ServiceTools.GetServices();
        }

        private void UpdateUsers()
        {
            users_dataGridView.DataSource = UserTools.GetUsers();
            users_dataGridView.Columns[5].Visible = false;
        }

        private void UpdateWorkers()
        {
            workers_dataGridView.DataSource = WorkerTools.GetWorkers();
            workers_dataGridView.Columns[5].Visible = false;
            UpdateWorker();
        }

        private void UpdateMaterials()
        {
            materials_dataGridView.DataSource = MaterialTools.GetMaterials();
        }

        private void UpdateProcedures()
        {
            showWorkerOnly_checkBox.Text = "Показать процедуры оказанные " + worker.FIO;
            proc_dataGridView.DataSource = ProcTools.GetProcs();
        }

        private void recs_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (recs_dataGridView.SelectedRows.Count > 0)
            {
                currentRec = new Rec(int.Parse(recs_dataGridView.CurrentRow.Cells[0].Value.ToString()), recs_dataGridView.CurrentRow.Cells[3].Value.ToString(), DateTime.Parse(recs_dataGridView.CurrentRow.Cells[2].Value.ToString()), recs_dataGridView.CurrentRow.Cells[5].Value.ToString());
                rec_dateTimePicker.Value = currentRec.recDate;
                recStatus_comboBox.Text = currentRec.Status;
            }
        }

        private void saveRec_button_Click(object sender, EventArgs e)
        {
            if (recs_dataGridView.Rows.Count > 0)
            {
                currentRec.recDate = rec_dateTimePicker.Value;
                currentRec.Status = recStatus_comboBox.Text;
                currentRec.UpdateUserRec();
                if (currentRec.Status == "Проведена")
                {
                    currentRec.CreateProc(worker.Id);
                }
                MessageBox.Show("Данные записи обновлены!");
                UpdateRecs();
                UpdateProcedures();
            }
        }

        private void deleteRec_button_Click(object sender, EventArgs e)
        {
            if (recs_dataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    currentRec.DeleteRec();
                    MessageBox.Show("Запись удалена!");
                    UpdateRecs();
                }
            }
        }

        private void recSearch_textBox_Enter(object sender, EventArgs e)
        {
            if (recSearch_textBox.Text == recTextHint)
            {
                recSearch_textBox.Text = "";
                recSearch_textBox.ForeColor = Color.Black;
            }
        }

        private void recSearch_textBox_Leave(object sender, EventArgs e)
        {
            if (recSearch_textBox.Text.Length == 0)
            {
                recSearch_textBox.Text = recTextHint;
                recSearch_textBox.ForeColor = Color.Gray;
            }
        }

        private void recSearch_button_Click(object sender, EventArgs e)
        {
            if (recSearch_textBox.Text != recTextHint)
            {
                ((DataTable)recs_dataGridView.DataSource).DefaultView.RowFilter = $"[Услуга] LIKE '%{recSearch_textBox.Text}%' OR [ФИО клиента] LIKE '%{recSearch_textBox.Text}%' OR [Статус] LIKE '%{recSearch_textBox.Text}%'";
            }
        }

        private void addRec_button_Click(object sender, EventArgs e)
        {
            WorkerAddRec workerAddRec = new WorkerAddRec();
            workerAddRec.FormClosing += (object se, FormClosingEventArgs ee) => { this.Visible = true; UpdateRecs(); };
            workerAddRec.ShowDialog();
        }

        private void services_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (services_dataGridView.SelectedRows.Count > 0)
            {
                currentService = new Service(services_dataGridView.CurrentRow.Cells[0].Value.ToString(), decimal.Parse(services_dataGridView.CurrentRow.Cells[1].Value.ToString()));
                servName_textBox.Text = currentService.Name;
                servPrice_numericUpDown.Value = currentService.Price;
            }
        }

        private void servSave_button_Click(object sender, EventArgs e)
        {
            if (services_dataGridView.SelectedRows.Count > 0)
            {
                currentService.Price = servPrice_numericUpDown.Value;
                currentService.UpdateService();
                MessageBox.Show("Данные услуги обновлены!");
                UpdateServices();
            }
        }

        private void servDelete_button_Click(object sender, EventArgs e)
        {
            if (services_dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить услугу?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (currentService.DeleteService() == 0)
                    {
                        MessageBox.Show("Услуга удалена!");
                        UpdateServices();
                    }
                    else
                    {
                        MessageBox.Show("Невозможно удалить услугу, так как она используется в других записях!");
                    }
                }
            }
        }

        private void servAdd_button_Click(object sender, EventArgs e)
        {
            WorkerAddService workerAddService = new WorkerAddService();
            workerAddService.FormClosing += (object se, FormClosingEventArgs ee) => { UpdateServices(); };
            workerAddService.ShowDialog();
        }

        private void servSearch_textBox_Leave(object sender, EventArgs e)
        {
            if (servSearch_textBox.Text.Length == 0)
            {
                servSearch_textBox.Text = servTextHint;
                servSearch_textBox.ForeColor = Color.Gray;
            }
        }

        private void servSearch_textBox_Enter(object sender, EventArgs e)
        {
            if (servSearch_textBox.Text == servTextHint)
            {
                servSearch_textBox.Text = "";
                servSearch_textBox.ForeColor = Color.Black;
            }
        }

        private void servSearch_textBox_TextChanged(object sender, EventArgs e)
        {
            if (servSearch_textBox.Text != servTextHint)
            {
                ((DataTable)services_dataGridView.DataSource).DefaultView.RowFilter = $"[Услуга] LIKE '%{servSearch_textBox.Text}%'";
            }
        }

        private void userFind_textBox_Leave(object sender, EventArgs e)
        {
            if (userFind_textBox.Text.Length == 0)
            {
                userFind_textBox.Text = userTextHint;
                userFind_textBox.ForeColor = Color.Gray;
            }
        }

        private void userFind_textBox_Enter(object sender, EventArgs e)
        {
            if (userFind_textBox.Text == userTextHint)
            {
                userFind_textBox.Text = "";
                userFind_textBox.ForeColor = Color.Black;
            }
        }

        private void userFind_textBox_TextChanged(object sender, EventArgs e)
        {
            if (userFind_textBox.Text != userTextHint)
            {
                ((DataTable)users_dataGridView.DataSource).DefaultView.RowFilter = $"[ФИО] LIKE '%{userFind_textBox.Text}%'";
            }
        }

        private void users_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (users_dataGridView.SelectedRows.Count > 0)
            {
                currentUser = new User(int.Parse(users_dataGridView.CurrentRow.Cells[0].Value.ToString()), users_dataGridView.CurrentRow.Cells[1].Value.ToString(), DateTime.Parse(users_dataGridView.CurrentRow.Cells[2].Value.ToString()), char.Parse(users_dataGridView.CurrentRow.Cells[3].Value.ToString()), int.Parse(users_dataGridView.CurrentRow.Cells[4].Value.ToString()), users_dataGridView.CurrentRow.Cells[5].Value.ToString());

                userFIO_textBox.Text = currentUser.FIO;
                userBirth_dateTimePicker.Value = currentUser.Birth;
                userID_textBox.Text = currentUser.Id.ToString();
                genF_radioButton.Checked = currentUser.Gen == 'Ж';
                genM_radioButton.Checked = currentUser.Gen == 'М';
                userPhone_textBox.Text = currentUser.Phone.ToString();
                userPwd_textBox.Text = currentUser.pass;
            }
        }

        private void userSave_button_Click(object sender, EventArgs e)
        {
            if (users_dataGridView.SelectedRows.Count > 0)
            {
                currentUser.FIO = userFIO_textBox.Text;
                currentUser.Birth = userBirth_dateTimePicker.Value;
                currentUser.Gen = genF_radioButton.Checked ? 'Ж' : 'М';
                currentUser.Phone = int.Parse(userPhone_textBox.Text);
                currentUser.pass = userPwd_textBox.Text;
                currentUser.UpdateUserInfo();
                MessageBox.Show("Данные обновлены!");
                UpdateUsers();
            }
        }

        private void userAdd_button_Click(object sender, EventArgs e)
        {
            UserRegistration userRegistration = new UserRegistration(workerMode: true);
            userRegistration.FormClosing += (object se, FormClosingEventArgs ee) => { UpdateUsers(); };
            userRegistration.ShowDialog();
        }

        private void workersFind_textBox_TextChanged(object sender, EventArgs e)
        {
            if (workersFind_textBox.Text != workerTextHint)
            {
                ((DataTable)workers_dataGridView.DataSource).DefaultView.RowFilter = $"[ФИО] LIKE '%{workersFind_textBox.Text}%' OR [Должность] LIKE '%{workersFind_textBox.Text}%'";
            }
        }

        private void workersFind_textBox_Leave(object sender, EventArgs e)
        {
            if (workersFind_textBox.Text.Length == 0)
            {
                workersFind_textBox.Text = workerTextHint;
                workersFind_textBox.ForeColor = Color.Gray;
            }
        }

        private void workersFind_textBox_Enter(object sender, EventArgs e)
        {
            if (workersFind_textBox.Text == workerTextHint)
            {
                workersFind_textBox.Text = "";
                workersFind_textBox.ForeColor = Color.Black;
            }
        }

        private void workers_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (workers_dataGridView.SelectedRows.Count > 0)
            {
                currentWorker = new Worker(int.Parse(workers_dataGridView.CurrentRow.Cells[0].Value.ToString()), workers_dataGridView.CurrentRow.Cells[1].Value.ToString(), workers_dataGridView.CurrentRow.Cells[2].Value.ToString(), int.Parse(workers_dataGridView.CurrentRow.Cells[3].Value.ToString()), decimal.Parse(workers_dataGridView.CurrentRow.Cells[4].Value.ToString()), workers_dataGridView.CurrentRow.Cells[5].Value.ToString());

                workerID_textBox.Text = currentWorker.Id.ToString();
                workerFIO_textBox.Text = currentWorker.FIO;
                workerRole_textBox.Text = currentWorker.Role;
                workerPhone_maskedTextBox.Text = currentWorker.Phone.ToString();
                workerWage_numericUpDown.Value = currentWorker.Wage;
                workerPwd_textBox.Text = currentWorker.pass;
            }
        }

        private void workerSave_button_Click(object sender, EventArgs e)
        {
            if (workers_dataGridView.SelectedRows.Count > 0)
            {
                currentWorker.Id = int.Parse(workerID_textBox.Text);
                currentWorker.FIO = workerFIO_textBox.Text;
                currentWorker.Role = workerRole_textBox.Text;
                currentWorker.Phone = int.Parse(workerPhone_maskedTextBox.Text);
                currentWorker.Wage = decimal.Parse(workerWage_numericUpDown.Text);
                currentWorker.pass = workerPwd_textBox.Text;
                currentWorker.UpdateWorkerInfo();
                MessageBox.Show("Данные обновлены!");
                UpdateWorkers();
                UpdateWorker();
            }
        }

        private void workerAdd_button_Click(object sender, EventArgs e)
        {
            WorkerAddWorker workerAdd = new WorkerAddWorker();
            workerAdd.FormClosing += (object se, FormClosingEventArgs ee) => { UpdateWorkers(); };
            workerAdd.ShowDialog();
        }

        private void matDel_button_Click(object sender, EventArgs e)
        {
            if (materials_dataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить материал?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (currentMaterial.DeleteMaterial() == 0)
                    {
                        MessageBox.Show("Услуга удалена!");
                        UpdateMaterials();
                    }
                    else
                    {
                        MessageBox.Show("Невозможно удалить материал, так как он используется в других записях!");
                    }
                }
            }
        }

        private void materials_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (materials_dataGridView.Rows.Count > 0)
            {
                currentMaterial = new Material(materials_dataGridView.CurrentRow.Cells[0].Value.ToString(), int.Parse(materials_dataGridView.CurrentRow.Cells[1].Value.ToString()), materials_dataGridView.CurrentRow.Cells[2].Value.ToString());

                matName_textBox.Text = currentMaterial.Name;
                matCount_numericUpDown.Value = currentMaterial.Count;
                matEd_textBox.Text = currentMaterial.MesUnits;
            }
        }

        private void matSave_button_Click(object sender, EventArgs e)
        {
            if (materials_dataGridView.Rows.Count > 0)
            {
                if (matEd_textBox.Text.Length > 0 & matEd_textBox.Text.Length < 3)
                {
                    currentMaterial.Count = int.Parse(matCount_numericUpDown.Value.ToString());
                    currentMaterial.MesUnits = matEd_textBox.Text;

                    currentMaterial.UpdateMaterial();
                    MessageBox.Show("Данные обновлены!");
                    UpdateMaterials();
                }
                else
                {
                    MessageBox.Show("Проерьте введенные данные!");
                }
            }

        }

        private void materialsFind_textBox_Enter(object sender, EventArgs e)
        {
            if (materialsFind_textBox.Text == matTextHint)
            {
                materialsFind_textBox.Text = "";
                materialsFind_textBox.ForeColor = Color.Black;
            }
        }

        private void materialsFind_textBox_Leave(object sender, EventArgs e)
        {
            if (materialsFind_textBox.Text.Length == 0)
            {
                materialsFind_textBox.Text = matTextHint;
                materialsFind_textBox.ForeColor = Color.Gray;
            }
        }

        private void materialsFind_textBox_TextChanged(object sender, EventArgs e)
        {
            if (materialsFind_textBox.Text != matTextHint)
            {
                ((DataTable)materials_dataGridView.DataSource).DefaultView.RowFilter = $"[Наименование] LIKE '%{materialsFind_textBox.Text}%'";
            }
        }

        private void addMaterial_button_Click(object sender, EventArgs e)
        {
            WorkerAddMaterial workerAddMaterial = new WorkerAddMaterial();
            workerAddMaterial.FormClosing += (object se, FormClosingEventArgs ee) => { UpdateMaterials(); };
            workerAddMaterial.ShowDialog();
        }

        private void proc_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (proc_dataGridView.Rows.Count > 0)
            {
                procMaterial_dataGridView.DataSource = MaterialTools.GetMaterialsByProcedure(int.Parse(proc_dataGridView.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void procMaterial_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (procMaterial_dataGridView.Rows.Count > 0)
            {
                procMat_textBox.Text = procMaterial_dataGridView.CurrentRow.Cells[0].Value.ToString();
                procMat_numericUpDown.Value = int.Parse(procMaterial_dataGridView.CurrentRow.Cells[1].Value.ToString());
            }
        }

        private void saveProcMat_button_Click(object sender, EventArgs e)
        {
            if (procMaterial_dataGridView.Rows.Count > 0)
            {
                int procId = int.Parse(proc_dataGridView.CurrentRow.Cells[0].Value.ToString());
                if (MaterialTools.UpdateProcMaterial(procId, procMat_textBox.Text, int.Parse(procMat_numericUpDown.Value.ToString())) == 1)
                {
                    MessageBox.Show("Недостаточно материала на складе!");
                }
                else
                {
                    MessageBox.Show("Данные обновлены!");
                    UpdateProcedures();
                    UpdateMaterials();
                }
            }
        }

        private void deleteProcMaterial_button_Click(object sender, EventArgs e)
        {
            if (procMaterial_dataGridView.Rows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно хотите удалить материал?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MaterialTools.DeleteProcMaterial(int.Parse(proc_dataGridView.CurrentRow.Cells[0].Value.ToString()), procMat_textBox.Text);
                    UpdateProcedures();
                    UpdateMaterials();
                }
            }
        }

        private void addProcMaterial_button_Click(object sender, EventArgs e)
        {
            if (proc_dataGridView.Rows.Count > 0)
            {
                WorkerAddProcMaterial workerAddProcMaterial = new WorkerAddProcMaterial(int.Parse(proc_dataGridView.CurrentRow.Cells[0].Value.ToString()));
                workerAddProcMaterial.FormClosing += (object se, FormClosingEventArgs ee) =>
                {
                    UpdateProcedures();
                    UpdateMaterials();
                };
                workerAddProcMaterial.ShowDialog();
            }
        }

        private void procFind_textBox_TextChanged(object sender, EventArgs e)
        {
            if (procFind_textBox.Text != procTextHint)
            {
                ((DataTable)proc_dataGridView.DataSource).DefaultView.RowFilter = $"[ФИО клиента] LIKE '%{procFind_textBox.Text}%' OR [ФИО мастера] LIKE '%{procFind_textBox.Text}%' OR [Услуга] LIKE '%{procFind_textBox.Text}%'";
            }
        }

        private void procFind_textBox_Leave(object sender, EventArgs e)
        {
            if (procFind_textBox.Text.Length == 0)
            {
                procFind_textBox.Text = procTextHint;
                procFind_textBox.ForeColor = Color.Gray;
            }
        }

        private void procFind_textBox_Enter(object sender, EventArgs e)
        {
            if (procFind_textBox.Text == procTextHint)
            {
                procFind_textBox.Text = "";
                procFind_textBox.ForeColor = Color.Black;
            }
        }

        private void showWorkerOnly_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showWorkerOnly_checkBox.Checked)
            ((DataTable)proc_dataGridView.DataSource).DefaultView.RowFilter = $"[ФИО мастера] LIKE '%{worker.FIO}%'";
            else
                ((DataTable)proc_dataGridView.DataSource).DefaultView.RowFilter = $"[ФИО мастера] LIKE '%'";
        }
    }
}
