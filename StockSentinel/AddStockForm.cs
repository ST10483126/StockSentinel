using StockSentinel.Data;
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
    }
}
