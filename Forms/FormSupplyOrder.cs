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
    public partial class FormSupplyOrder : Form
    {
        private readonly WarehouseDbContext _context;

        public FormSupplyOrder()
        {
            InitializeComponent();
            _context = new WarehouseDbContext();
            LoadWarehouses();
            LoadItems();
            LoadSuppliers();
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

        private void LoadSuppliers()
        {
            cmbSupplier.DataSource = _context.Suppliers.ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplyOrder = new SupplyOrder
            {
                WarehouseId = (int)cmbWarehouse.SelectedValue,
                ItemId = (int)cmbItem.SelectedValue,
                SupplierId = (int)cmbSupplier.SelectedValue,
                Quantity = int.Parse(txtQuantity.Text),
                ProductionDate = dtpProductionDate.Value,
                ExpiryDate = dtpExpiryDate.Value
            };

            _context.SupplyOrders.Add(supplyOrder);
            _context.SaveChanges();
            MessageBox.Show("Supply order added successfully!");
        }
    }

}
