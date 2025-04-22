using System;
using System.Windows.Forms;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnManageWarehouses_Click(object sender, EventArgs e)
        {
            new FormWarehouses().Show();
        }

        private void btnExpiringItems_Click(object sender, EventArgs e)
        {
            new FormExpiringItems().Show();
        }
    }
}
