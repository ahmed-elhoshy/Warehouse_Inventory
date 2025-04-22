namespace WinFormsApp1.Forms
{
    partial class FormSupplyOrder
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpProductionDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductionDate;
        private System.Windows.Forms.Label lblExpiryDate;

        private void InitializeComponent()
        {
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dtpProductionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductionDate = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Labels
            this.lblWarehouse.Location = new System.Drawing.Point(20, 0);
            this.lblWarehouse.Text = "Warehouse:";
            this.lblItem.Location = new System.Drawing.Point(20, 40);
            this.lblItem.Text = "Item:";
            this.lblSupplier.Location = new System.Drawing.Point(20, 80);
            this.lblSupplier.Text = "Supplier:";
            this.lblQuantity.Location = new System.Drawing.Point(20, 120);
            this.lblQuantity.Text = "Quantity:";
            this.lblProductionDate.Location = new System.Drawing.Point(20, 160);
            this.lblProductionDate.Text = "Production Date:";
            this.lblExpiryDate.Location = new System.Drawing.Point(20, 200);
            this.lblExpiryDate.Text = "Expiry Date:";

            // ComboBoxes
            this.cmbWarehouse.Location = new System.Drawing.Point(20, 20);
            this.cmbItem.Location = new System.Drawing.Point(20, 60);
            this.cmbSupplier.Location = new System.Drawing.Point(20, 100);

            // TextBox for Quantity
            this.txtQuantity.Location = new System.Drawing.Point(20, 140);

            // DatePickers
            this.dtpProductionDate.Location = new System.Drawing.Point(20, 180);
            this.dtpExpiryDate.Location = new System.Drawing.Point(20, 220);

            // Save Button
            this.btnSave.Location = new System.Drawing.Point(20, 260);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form properties
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.lblWarehouse);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductionDate);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.cmbWarehouse);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dtpProductionDate);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.btnSave);
            this.ResumeLayout(false);
        }
    }
}
