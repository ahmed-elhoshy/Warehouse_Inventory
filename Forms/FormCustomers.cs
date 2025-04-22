using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.DataContext;  

namespace WinFormsApp1.Forms
{
    public partial class FormCustomers : Form
    {
        private WarehouseDbContext _context;

        public FormCustomers()
        {
            InitializeComponent();
            _context = new WarehouseDbContext();  // ✅ Use WarehouseDbContext instead of AppDbContext
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgvCustomers.DataSource = _context.Customers.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };

            _context.Customers.Add(customer);
            _context.SaveChanges();
            LoadCustomers();
        }
    }
}
