using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.DataContext;
using WinFormsApp1.Entities;
using WinFormsApp1.Entities; // Ensure Supplier model is included

namespace WinFormsApp1.Forms
{
    public partial class FormSupplier : Form
    {
        private WarehouseDbContext _context;
        private int _selectedSupplierId = 0;

        public FormSupplier()
        {
            InitializeComponent();
            _context = new WarehouseDbContext();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource = _context.Suppliers
                .Select(s => new { s.Id, s.Name, s.Email, s.Phone })
                .ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedSupplierId == 0) // New Supplier
            {
                var newSupplier = new Supplier { Name = name, Email = email, Phone = phone };
                _context.Suppliers.Add(newSupplier);
            }
            else // Edit Existing Supplier
            {
                var existingSupplier = _context.Suppliers.Find(_selectedSupplierId);
                if (existingSupplier != null)
                {
                    existingSupplier.Name = name;
                    existingSupplier.Email = email;
                    existingSupplier.Phone = phone;
                }
            }

            _context.SaveChanges();
            LoadSuppliers();
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            _selectedSupplierId = 0;
            btnSave.Text = "Save";
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedSupplierId = Convert.ToInt32(dgvSuppliers.Rows[e.RowIndex].Cells["Id"].Value);
                txtName.Text = dgvSuppliers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtEmail.Text = dgvSuppliers.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtPhone.Text = dgvSuppliers.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                btnSave.Text = "Update";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSupplierId == 0)
            {
                MessageBox.Show("Select a supplier first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var supplier = _context.Suppliers.Find(_selectedSupplierId);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
                LoadSuppliers();
                ClearFields();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim().ToLower();
            dgvSuppliers.DataSource = _context.Suppliers
                .Where(s => s.Name.ToLower().Contains(searchText) ||
                            s.Email.ToLower().Contains(searchText) ||
                            s.Phone.Contains(searchText))
                .Select(s => new { s.Id, s.Name, s.Email, s.Phone })
                .ToList();
        }
    }
}
