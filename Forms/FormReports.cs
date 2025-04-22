using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.DataContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormsApp1.Forms
{
    public partial class FormReports : Form
    {
        private readonly WarehouseDbContext _context;

        public FormReports()
        {
            InitializeComponent();
            _context = new WarehouseDbContext();

            LoadWarehouses();
            LoadItems();
            LoadReportTypes();
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

        private void LoadReportTypes()
        {
            cmbReportType.Items.Add("Warehouse Report");
            cmbReportType.Items.Add("Item Report");
            cmbReportType.Items.Add("Item Movement");
            cmbReportType.Items.Add("Warehouse Stock Report");
            cmbReportType.Items.Add("Expiring Items Report");
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cmbReportType.SelectedItem.ToString();

            switch (reportType)
            {
                case "Warehouse Report":
                    GenerateWarehouseReport();
                    break;
                case "Item Report":
                    GenerateItemReport();
                    break;
                case "Item Movement":
                    GenerateItemMovementReport();
                    break;
                case "Warehouse Stock Report":
                    GenerateWarehouseStockReport();
                    break;
                case "Expiring Items Report":
                    GenerateExpiringItemsReport();
                    break;
            }
        }

        private void GenerateWarehouseReport()
        {
            int warehouseId = (int)cmbWarehouse.SelectedValue;
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            var report = _context.WarehouseTransfers
                .Where(wt => (wt.FromWarehouseId == warehouseId || wt.ToWarehouseId == warehouseId)
                             && wt.TransferDate >= startDate && wt.TransferDate <= endDate)
                .ToList();

            dataGridViewReport.DataSource = report;
        }

        private void GenerateItemReport()
        {
            int itemId = (int)cmbItem.SelectedValue;
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            var report = _context.WarehouseTransfers
                .Where(wt => wt.ItemId == itemId && wt.TransferDate >= startDate && wt.TransferDate <= endDate)
                .ToList();

            dataGridViewReport.DataSource = report;
        }

        private void GenerateItemMovementReport()
        {
            DateTime startDate = dateTimePickerStart.Value;
            DateTime endDate = dateTimePickerEnd.Value;

            var report = _context.WarehouseTransfers
                .Where(wt => wt.TransferDate >= startDate && wt.TransferDate <= endDate)
                .OrderBy(wt => wt.TransferDate)
                .ToList();

            dataGridViewReport.DataSource = report;
        }

        private void GenerateWarehouseStockReport()
        {
            int warehouseId = (int)cmbWarehouse.SelectedValue;
            DateTime endDate = dateTimePickerEnd.Value;

            var received = _context.SupplyOrders
                .Where(s => s.WarehouseId == warehouseId && s.OrderDate <= endDate)
                .GroupBy(s => s.ItemId)
                .Select(g => new { ItemId = g.Key, QuantityReceived = g.Sum(s => s.Quantity) })
                .ToList();

            var disbursed = _context.DisbursementOrders
                .Where(d => d.WarehouseId == warehouseId && d.OrderDate <= endDate)
                .GroupBy(d => d.ItemId)
                .Select(g => new { ItemId = g.Key, QuantityDisbursed = g.Sum(d => d.Quantity) })
                .ToList();

            var report = received.Join(disbursed, r => r.ItemId, d => d.ItemId,
                (r, d) => new { ItemId = r.ItemId, Stock = r.QuantityReceived - d.QuantityDisbursed })
                .ToList();

            dataGridViewReport.DataSource = report;
        }

        private void GenerateExpiringItemsReport()
        {
            int thresholdDays = int.Parse(txtThresholdDays.Text);
            DateTime targetDate = DateTime.Now.AddDays(thresholdDays);

            var report = _context.SupplyOrders
                .Where(s => s.ExpiryDate <= targetDate)
                .Select(s => new { s.Item.Name, s.ExpiryDate })
                .ToList();

            dataGridViewReport.DataSource = report;
        }
    }
}
