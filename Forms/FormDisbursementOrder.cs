using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using WinFormsApp1.DataContext;
using WinFormsApp1.Entities;

namespace WinFormsApp1.Forms
{
    public partial class FormDisbursementOrder : Form
    {
        private readonly WarehouseDbContext _context;

        public FormDisbursementOrder()
        {
            InitializeComponent();
            _context = new WarehouseDbContext();
            LoadWarehouses();
            LoadItems();
            LoadCustomers();
        }

        private void LoadWarehouses()
        {
            cmbWarehouse.DataSource = _context.Warehouses.ToList();
            cmbWarehouse.DisplayMember = "Name";
            cmbWarehouse.ValueMember = "Id";
        }

        private void LoadItems()
        {
            cmbItem.DataSource = _context.Items.ToList();
            cmbItem.DisplayMember = "Name";
            cmbItem.ValueMember = "Id";
        }

        private void LoadCustomers()
        {
            cmbCustomer.DataSource = _context.Customers.ToList();
            cmbCustomer.DisplayMember = "Name";
            cmbCustomer.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var disbursementOrder = new DisbursementOrder
            {
                WarehouseId = (int)cmbWarehouse.SelectedValue,
                ItemId = (int)cmbItem.SelectedValue,
                CustomerId = (int)cmbCustomer.SelectedValue,
                Quantity = int.Parse(txtQuantity.Text),
                DisbursementDate = DateTime.Now
            };

            _context.DisbursementOrders.Add(disbursementOrder);
            _context.SaveChanges();
            MessageBox.Show("Disbursement order added successfully!");
        }
    }

}
