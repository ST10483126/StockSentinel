using StockSentinel.Data;
using StockSentinel.Models;

namespace StockSentinel;

public partial class Form1 : Form
{
    private readonly StockRepository _repository;

    public Form1()
    {
        _repository = new StockRepository();
        InitializeComponent();
    }
        private async void Form1_Load(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }

    private async Task LoadDataAsync()
    {
        try
        {
            // 1. Tell the user we are working
            this.Cursor = Cursors.WaitCursor;           

            // 2. Fetch data
            var stockItems = await _repository.GetAllStockItemsAsync();

            // 3. Bind data
            dgvStock.DataSource = stockItems;

            // 4. Fix the columns
            ConfigureGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK);
        }
        finally
        {
            // 5. Resets the UI when finished (even if it failed)
            this.Cursor = Cursors.Default;
            this.Text = "StockSentinel Dashboard";
        }
    }

    private void ConfigureGrid()
    {
        if (dgvStock.Columns.Count > 0)
        {
            // Hide database-specific and navigation properties
            dgvStock.Columns["Id"].Visible = false;
            dgvStock.Columns["CategoryId"].Visible = false;
            dgvStock.Columns["Category"].Visible = false;
            dgvStock.Columns["Batches"].Visible = false;

            // Renaming headers for a professional look
            dgvStock.Columns["Name"].HeaderText = "Product Name";
            dgvStock.Columns["Quantity"].HeaderText = "Qty";
            dgvStock.Columns["CostPrice"].HeaderText = "Cost (R)";
            dgvStock.Columns["TotalValue"].HeaderText = "Total Value (R)";
            dgvStock.Columns["ExpiryDate"].HeaderText = "Expiry Date";

            // Format currency and dates
            dgvStock.Columns["CostPrice"].DefaultCellStyle.Format = "C2";
            dgvStock.Columns["TotalValue"].DefaultCellStyle.Format = "C2";
            dgvStock.Columns["ExpiryDate"].DefaultCellStyle.Format = "yyyy-MM-dd";

            // Make it read-only (we will edit via a form later)
            dgvStock.ReadOnly = true;
            dgvStock.AllowUserToAddRows = false;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }

    private async void btnAdditems_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Add Item form will open here next.", "Coming Soon");
    }

    // Delete Button Click
    private async void btnDelete_Click(object sender, EventArgs e)
    {
        if (dgvStock.SelectedRows.Count == 0)
        {
            MessageBox.Show("Please select an item to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var confirm = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (confirm == DialogResult.Yes)
        {
            // Get the ID of the selected row
            var selectedRow = (StockItem)dgvStock.SelectedRows[0].DataBoundItem;

            await _repository.DeleteStockItemAsync(selectedRow.Id);
            await LoadDataAsync(); // Refresh grid
        }
    }


    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        await LoadDataAsync();
    }
}
