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
    public partial class ClientMainForm : Form
    {
        public User user;

        public ClientMainForm()
        {
            InitializeComponent();
        }

        public void InitializeUser (User user_)
        {
            user = user_;
            editUser_linkLabel.Text = user.FIO;
            services_dataGridView.DataSource = user.GetUserServices();
        }
    }
}
