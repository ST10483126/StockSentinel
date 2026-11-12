namespace StockSentinel
{
    partial class AddStockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblQuantity = new Label();
            lblCostPrice = new Label();
            lblExpiryDate = new Label();
            lblCategory = new Label();
            txtName = new TextBox();
            txtQuantity = new TextBox();
            txtCostPrice = new TextBox();
            dtmExpiryDate = new DateTimePicker();
            cmbCategory = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(124, 116);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 41);
            lblName.TabIndex = 0;
            lblName.Text = "Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(124, 259);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(139, 41);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCostPrice
            // 
            lblCostPrice.AutoSize = true;
            lblCostPrice.Location = new Point(124, 387);
            lblCostPrice.Name = "lblCostPrice";
            lblCostPrice.Size = new Size(193, 41);
            lblCostPrice.TabIndex = 2;
            lblCostPrice.Text = "Cost Price(R):";
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Location = new Point(709, 116);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(166, 41);
            lblExpiryDate.TabIndex = 3;
            lblExpiryDate.Text = "ExpiryDate:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(709, 438);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(146, 41);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(345, 116);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 47);
            txtName.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(345, 253);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 47);
            txtQuantity.TabIndex = 6;
            // 
            // txtCostPrice
            // 
            txtCostPrice.Location = new Point(345, 387);
            txtCostPrice.Name = "txtCostPrice";
            txtCostPrice.Size = new Size(250, 47);
            txtCostPrice.TabIndex = 7;
            // 
            // dtmExpiryDate
            // 
            dtmExpiryDate.Location = new Point(921, 110);
            dtmExpiryDate.Name = "dtmExpiryDate";
            dtmExpiryDate.Size = new Size(500, 47);
            dtmExpiryDate.TabIndex = 8;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(921, 430);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(302, 49);
            cmbCategory.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(436, 545);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 58);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(801, 545);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 58);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddStockForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1433, 727);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbCategory);
            Controls.Add(dtmExpiryDate);
            Controls.Add(txtCostPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtName);
            Controls.Add(lblCategory);
            Controls.Add(lblExpiryDate);
            Controls.Add(lblCostPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblName);
            Name = "AddStockForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Stock Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblQuantity;
        private Label lblCostPrice;
        private Label lblExpiryDate;
        private Label lblCategory;
        private TextBox txtName;
        private TextBox txtQuantity;
        private TextBox txtCostPrice;
        private DateTimePicker dtmExpiryDate;
        private ComboBox cmbCategory;
        private Button btnSave;
        private Button btnCancel;
    }
}