namespace WinFormsApp1.Forms
{
    partial class FormCustomers
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName, txtEmail, txtPhone;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblName, lblEmail, lblPhone;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();

            this.btnSave.Location = new System.Drawing.Point(50, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.lblName.Location = new System.Drawing.Point(50, 30);
            this.lblName.Size = new System.Drawing.Size(100, 20);
            this.lblName.Text = "Name:";
            this.lblName.Name = "lblName";

            this.txtName.Location = new System.Drawing.Point(50, 50);
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.Name = "txtName";

            this.lblEmail.Location = new System.Drawing.Point(50, 70);
            this.lblEmail.Size = new System.Drawing.Size(100, 20);
            this.lblEmail.Text = "Email:";
            this.lblEmail.Name = "lblEmail";

            this.txtEmail.Location = new System.Drawing.Point(50, 90);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.Name = "txtEmail";

            this.lblPhone.Location = new System.Drawing.Point(50, 110);
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.lblPhone.Text = "Phone:";
            this.lblPhone.Name = "lblPhone";

            this.txtPhone.Location = new System.Drawing.Point(50, 130);
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.Name = "txtPhone";

            this.dgvCustomers.Location = new System.Drawing.Point(300, 50);
            this.dgvCustomers.Size = new System.Drawing.Size(400, 200);
            this.dgvCustomers.Name = "dgvCustomers";

            this.ClientSize = new System.Drawing.Size(750, 300);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Name = "FormCustomers";
            this.Text = "Manage Customers";
        }
    }
}
