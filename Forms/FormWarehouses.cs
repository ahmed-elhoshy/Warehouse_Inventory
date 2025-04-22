using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.DataContext;

namespace WinFormsApp1.Forms
{
    public partial class FormWarehouses : Form
    {
        public FormWarehouses()
        {
            InitializeComponent();
            btnSave.Click -= BtnSave_Click; // Unsubscribe first to avoid multiple subscriptions
            btnSave.Click += BtnSave_Click;

            LoadWarehouses();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter all details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new WarehouseDbContext())
            {
                var newWarehouse = new Warehouse
                {
                    Name = txtName.Text,
                    Location = txtLocation.Text
                };

                db.Warehouses.Add(newWarehouse);
                db.SaveChanges();

                MessageBox.Show("Warehouse saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWarehouses();
            }
        }

        private void LoadWarehouses()
        {
            using (var db = new WarehouseDbContext())
            {
                dgvWarehouses.DataSource = db.Warehouses
                    .Select(w => new { w.Id, w.Name, w.Location })
                    .ToList();
            }
        }
    }
}
