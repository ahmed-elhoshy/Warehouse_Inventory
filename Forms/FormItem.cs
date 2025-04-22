using System;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.DataContext;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Xml.Linq;

namespace WinFormsApp1.Forms
{
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent(); // Ensure this is called first
            btnSave.Click += BtnSave_Click; // Attach event to save button
            LoadItems(); // Load existing items
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using (var db = new WarehouseDbContext())
            {
                var newItem = new Item
                {
                    Name = txtName.Text,
                    Code = txtCode.Text,
                    Category = txtCategory.Text,
                    Unit = txtUnit.Text // Ensure Unit is stored as string
                };

                db.Items.Add(newItem);
                db.SaveChanges();

                MessageBox.Show("Item saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadItems();
            }
        }

        private void LoadItems()
        {
            using (var db = new WarehouseDbContext())
            {
                dgvItems.DataSource = db.Items.Select(i => new
                {
                    i.Name,
                    i.Code,
                    i.Category,
                    i.Unit
                }).ToList();
            }
        }
    }
}
