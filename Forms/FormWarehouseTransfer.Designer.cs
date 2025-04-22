namespace WinFormsApp1.Forms
{
    partial class FormWarehouseTransfer
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbFromWarehouse;
        private System.Windows.Forms.ComboBox cmbToWarehouse;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.cmbFromWarehouse = new System.Windows.Forms.ComboBox();
            this.cmbToWarehouse = new System.Windows.Forms.ComboBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ComboBoxes
            this.cmbFromWarehouse.Location = new System.Drawing.Point(20, 20);
            this.cmbToWarehouse.Location = new System.Drawing.Point(20, 60);
            this.cmbItem.Location = new System.Drawing.Point(20, 100);

            // TextBox for Quantity
            this.txtQuantity.Location = new System.Drawing.Point(20, 140);

            // Save Button
            this.btnSave.Location = new System.Drawing.Point(20, 180);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form properties
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.cmbFromWarehouse);
            this.Controls.Add(this.cmbToWarehouse);
            this.Controls.Add(this.cmbItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnSave);
            this.ResumeLayout(false);
        }
    }

}