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
    public partial class FormWarehouseTransfer : Form
    {
        private readonly WarehouseDbContext _context;

        public FormWarehouseTransfer()
        {
            InitializeComponent();
            _context = new WarehouseDbContext();
            LoadWarehouses();
            LoadItems();

            // Add event handlers after loading data to avoid triggering them during initialization
            cmbFromWarehouse.SelectedIndexChanged += CmbFromWarehouse_SelectedIndexChanged;

        }
        private void CmbFromWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure the destination warehouse combo box does not change when the source warehouse is selected
            var selectedWarehouseId = (int)cmbFromWarehouse.SelectedValue;
            var warehouses = _context.Warehouses.Where(w => w.Id != selectedWarehouseId).ToList();
            cmbToWarehouse.DataSource = warehouses;
            cmbToWarehouse.DisplayMember = "Name";
            cmbToWarehouse.ValueMember = "Id";
        }
        private void LoadWarehouses()
        {
            var warehouses = _context.Warehouses.ToList();
            cmbFromWarehouse.DataSource = warehouses;
            cmbFromWarehouse.DisplayMember = "Name";
            cmbFromWarehouse.ValueMember = "Id";

            cmbToWarehouse.DataSource = warehouses;
            cmbToWarehouse.DisplayMember = "Name";
            cmbToWarehouse.ValueMember = "Id";
        }

        private void LoadItems()
        {
            cmbItem.DataSource = _context.Items.ToList();
            cmbItem.DisplayMember = "Name";
            cmbItem.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int fromWarehouseId = (int)cmbFromWarehouse.SelectedValue;
            int toWarehouseId = (int)cmbToWarehouse.SelectedValue;
            int itemId = (int)cmbItem.SelectedValue;
            int quantity = int.Parse(txtQuantity.Text);

            var stock = _context.SupplyOrders
                                .Where(o => o.WarehouseId == fromWarehouseId && o.ItemId == itemId)
                                .Sum(o => o.Quantity);

            var disbursed = _context.DisbursementOrders
                                    .Where(o => o.WarehouseId == fromWarehouseId && o.ItemId == itemId)
                                    .Sum(o => o.Quantity);

            int availableStock = stock - disbursed;

            if (availableStock >= quantity)
            {
                var transfer = new WarehouseTransfer
                {
                    FromWarehouseId = fromWarehouseId,
                    ToWarehouseId = toWarehouseId,
                    ItemId = itemId,
                    Quantity = quantity,
                    TransferDate = DateTime.Now
                };

                _context.WarehouseTransfers.Add(transfer);
                _context.SaveChanges();
                MessageBox.Show("Items transferred successfully!");
            }
            else
            {
                MessageBox.Show("Not enough stock available!");
            }
        }
    }

}
