using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.DataContext;

namespace WinFormsApp1.Forms
{
    public partial class FormExpiringItems : Form
    {
        private DataGridView dataGridViewExpiringItems;

        public FormExpiringItems()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            dataGridViewExpiringItems = new DataGridView
            {
                Left = 20,
                Top = 50,
                Width = 600,
                Height = 300,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            this.Controls.Add(dataGridViewExpiringItems);
        }

        private void FormExpiringItems_Load(object sender, EventArgs e)
        {
            LoadExpiringItems();
        }

        private void LoadExpiringItems()
        {
            using (var db = new WarehouseDbContext())
            {
                DateTime warningDate = DateTime.Today.AddDays(30);

                var expiringItems = db.SupplyOrders
                    .Where(o => o.ExpiryDate <= warningDate)
                    .Select(o => new
                    {
                        ItemName = o.Item.Name,  // Unique names
                        Category = o.Item.Category,
                        Quantity = o.Quantity,
                        SupplierName = o.Supplier.Name,  // Unique names
                        ExpiryDate = o.ExpiryDate
                    })
                    .ToList();

                dataGridViewExpiringItems.DataSource = expiringItems;
            }
        }
    }
}
