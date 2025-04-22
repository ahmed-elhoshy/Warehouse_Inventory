namespace WinFormsApp1
{
    partial class Main
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageWarehousesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSuppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplyOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDisbursementOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageWarehousesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplyOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDisbursementOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();

            // MenuStrip
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.manageCustomersToolStripMenuItem,
                this.manageItemsToolStripMenuItem,
                this.manageWarehousesToolStripMenuItem,
                this.manageSuppliersToolStripMenuItem,
                this.addSupplyOrderToolStripMenuItem,
                this.addDisbursementOrderToolStripMenuItem,
                this.transferItemsToolStripMenuItem,
                this.reportsToolStripMenuItem // Adding Reports menu item
            });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // Panel
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 24);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(800, 426);
            this.panelContainer.TabIndex = 1;

            // Menu Items
            this.manageCustomersToolStripMenuItem.Text = "Manage Customers";
            this.manageItemsToolStripMenuItem.Text = "Manage Items";
            this.manageWarehousesToolStripMenuItem.Text = "Manage Warehouses";
            this.manageSuppliersToolStripMenuItem.Text = "Manage Suppliers";
            this.addSupplyOrderToolStripMenuItem.Text = "Add Supply Order";
            this.addDisbursementOrderToolStripMenuItem.Text = "Add Disbursement Order";
            this.transferItemsToolStripMenuItem.Text = "Transfer Items";
            this.reportsToolStripMenuItem.Text = "Reports";

            // Events
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItem_Click);

            // Add Controls to Form
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Text = "Main Dashboard";
            this.ClientSize = new System.Drawing.Size(800, 450);
        }
    }
}
