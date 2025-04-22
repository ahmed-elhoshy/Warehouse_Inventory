using System;
using System.Windows.Forms;
using WinFormsApp1.Forms;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Attach click events
            manageCustomersToolStripMenuItem.Click += (s, e) => LoadForm(new FormCustomers());
            manageItemsToolStripMenuItem.Click += (s, e) => LoadForm(new FormItem());
            manageWarehousesToolStripMenuItem.Click += (s, e) => LoadForm(new FormWarehouses());
            manageSuppliersToolStripMenuItem.Click += (s, e) => LoadForm(new FormSupplier());
            addSupplyOrderToolStripMenuItem.Click += (s, e) => LoadForm(new FormSupplyOrder());
            addDisbursementOrderToolStripMenuItem.Click += (s, e) => LoadForm(new FormDisbursementOrder());
            transferItemsToolStripMenuItem.Click += (s, e) => LoadForm(new FormWarehouseTransfer());
        }

        private void LoadForm(Form form)
        {
            panelContainer.Controls.Clear(); // Clear previous form
            form.TopLevel = false; // Make it a child form
            form.Dock = DockStyle.Fill; // Fit inside the panel
            panelContainer.Controls.Add(form);
            form.Show();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();
            formReports.Show();
        }
    }
}
