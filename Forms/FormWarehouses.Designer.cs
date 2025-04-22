using System;
using System.Windows.Forms;

namespace WinFormsApp1.Forms
{
    partial class FormWarehouses
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName, txtLocation;
        private System.Windows.Forms.DataGridView dgvWarehouses;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblName, lblLocation;

        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dgvWarehouses = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();

            this.btnSave.Location = new System.Drawing.Point(50, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            this.lblName.Location = new System.Drawing.Point(50, 30);
            this.lblName.Size = new System.Drawing.Size(100, 20);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Name:";

            this.txtName.Location = new System.Drawing.Point(50, 50);
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.Name = "txtName";

            this.lblLocation.Location = new System.Drawing.Point(50, 70);
            this.lblLocation.Size = new System.Drawing.Size(100, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Text = "Location:";

            this.txtLocation.Location = new System.Drawing.Point(50, 90);
            this.txtLocation.Size = new System.Drawing.Size(200, 22);
            this.txtLocation.Name = "txtLocation";

            this.dgvWarehouses.Location = new System.Drawing.Point(300, 50);
            this.dgvWarehouses.Size = new System.Drawing.Size(400, 200);
            this.dgvWarehouses.Name = "dgvWarehouses";

            this.ClientSize = new System.Drawing.Size(750, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.dgvWarehouses);
            this.Name = "FormWarehouses";
            this.Text = "Manage Warehouses";
        }
    }
}

