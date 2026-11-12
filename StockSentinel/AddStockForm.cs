using StockSentinel.Data;
using StockSentinel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StockSentinel
{
    public partial class AddStockForm : Form
    {
        private readonly StockRepository _repository;
        public AddStockForm()
        {
            InitializeComponent();
            _repository = new StockRepository();
        }

        private async void AddStockForm_Load(object sender, EventArgs e)
        {
            try
            {
                var categories = await _repository.GetAllCategoriesAsync();

                // If the database is brand new, add a default category so it's not empty
                if (categories.Count == 0)
                {
                    // We will handle seeding later, for now just a fallback
                    cmbCategory.Items.Add("General");
                    cmbCategory.SelectedIndex = 0;
                }
                else
                {
                    cmbCategory.DataSource = categories;
                    cmbCategory.DisplayMember = "Name";
                    cmbCategory.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Validate Input
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid positive number for Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtCostPrice.Text, out decimal costPrice) || costPrice < 0)
            {
                MessageBox.Show("Please enter a valid positive number for Cost Price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Create the new item
                var newItem = new StockItem
                {
                    Name = txtName.Text.Trim(),
                    Quantity = quantity,
                    CostPrice = costPrice,
                    ExpiryDate = dtpExpiryDate.Value,
                    CategoryId = (int)(cmbCategory.SelectedValue ?? 0)
                };

                // 3. Save to database
                await _repository.SaveStockItemAsync(newItem);

                // 4. Close form and return success
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving item: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
