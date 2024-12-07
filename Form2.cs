using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_project_pos
{
    public partial class Form2 : Form
    {
        public Form1 mainForm;
        DataTable ProductDetails;
        public Form2(Form1 form1)
        {

            InitializeComponent();
            mainForm = form1; // Store reference to Form1
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) &&
     decimal.TryParse(txtPrice.Text, out decimal price) &&
     int.TryParse(txtQuantity.Text, out int quantity))
            {
                mainForm.ProductDetails.Rows.Add(txtProductName.Text, price, quantity);
                mainForm.RefreshGridView(); // Update DataGridView in Form1
                ClearInputs();
                MessageBox.Show("Product added successfully!");
            }
            else
            {
                MessageBox.Show("Please enter valid product details.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            {
                if (mainForm.
                    dataGridView2.SelectedRows.Count > 0)
                {
                    int rowIndex = mainForm.dataGridView2.SelectedRows[0].Index;

                    if (!string.IsNullOrEmpty(txtProductName.Text) &&
                        decimal.TryParse(txtPrice.Text, out decimal price) &&
                        int.TryParse(txtQuantity.Text, out int quantity))
                    {
                        DataRow row = mainForm.ProductDetails.Rows[rowIndex];
                        row["ProductName"] = txtProductName.Text;
                        row["Price"] = price;
                        row["Quantity"] = quantity;

                        mainForm.RefreshGridView(); // Update DataGridView in Form1
                        ClearInputs();
                        MessageBox.Show("Product updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid product details.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a product to update.");
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (mainForm.dataGridView2.SelectedRows.Count > 0)
            {
                int rowIndex = mainForm.dataGridView2.SelectedRows[0].Index;
                mainForm.ProductDetails.Rows[rowIndex].Delete();
                mainForm.RefreshGridView(); // Update DataGridView in Form1
                ClearInputs();
                MessageBox.Show("Product deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void ClearInputs()
        {
            txtProductName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form1 form1 = new Form1();

            // Show Form2
            form1.Show();

            // Optionally, hide the current form
            this.Hide();
        }
    }
}
