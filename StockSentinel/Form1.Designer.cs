namespace StockSentinel;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dgvStock = new DataGridView();
        panel1 = new Panel();
        btnRefresh = new Button();
        btnAdditems = new Button();
        btnDelete = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // dgvStock
        // 
        dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvStock.Dock = DockStyle.Bottom;
        dgvStock.Location = new Point(0, 451);
        dgvStock.Name = "dgvStock";
        dgvStock.RowHeadersWidth = 102;
        dgvStock.Size = new Size(1624, 313);
        dgvStock.TabIndex = 0;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnDelete);
        panel1.Controls.Add(btnAdditems);
        panel1.Controls.Add(btnRefresh);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1624, 95);
        panel1.TabIndex = 1;
        // 
        // btnRefresh
        // 
        btnRefresh.Location = new Point(1424, 22);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(188, 58);
        btnRefresh.TabIndex = 0;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = true;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnAdditems
        // 
        btnAdditems.Location = new Point(22, 22);
        btnAdditems.Name = "btnAdditems";
        btnAdditems.Size = new Size(188, 58);
        btnAdditems.TabIndex = 1;
        btnAdditems.Text = "Add item";
        btnAdditems.UseVisualStyleBackColor = true;
        btnAdditems.Click += btnAdditems_Click;
        // 
        // btnDelete
        // 
        btnDelete.Location = new Point(282, 22);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(188, 58);
        btnDelete.TabIndex = 2;
        btnDelete.Text = "Delete Selected";
        btnDelete.UseVisualStyleBackColor = true;
        btnDelete.Click += btnDelete_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1624, 764);
        Controls.Add(panel1);
        Controls.Add(dgvStock);
        Name = "Form1";
        Text = "StockSentinel - Dashboard";
        ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dgvStock;
    private Panel panel1;
    private Button btnAdditems;
    private Button btnRefresh;
    private Button btnDelete;
}
