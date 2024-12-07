using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace group_project_pos
{

    public partial class Form1 : Form
    {
       public DataTable ProductDetails;


        public Form1()
        {
            InitializeComponent();
            ProductDetails = new DataTable();
            ProductDetails.Columns.Add("ProductName", typeof(string));
            ProductDetails.Columns.Add("Price", typeof(decimal));
            ProductDetails.Columns.Add("Quantity", typeof(int));
            dataGridView2.DataSource = ProductDetails;
            AddSampleProducts();
        }
        private void OpenForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this); // Pass Form1 reference
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind DataTable to DataGridView
            dataGridView2.DataSource = ProductDetails;

            // Adjust columns to fit the grid
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Optional: Adjust rows to fit their content
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Center align headers
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Enable text wrapping
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void AddSampleProducts()
        {
            ProductDetails.Rows.Add("Product A", 10.50m, 20);
            ProductDetails.Rows.Add("Product B", 15.75m, 50);
            ProductDetails.Rows.Add("Product C", 8.99m, 100);
            ProductDetails.Rows.Add("Product D", 10.50m, 20);
            ProductDetails.Rows.Add("Product E", 15.75m, 50);
            ProductDetails.Rows.Add("Product F", 8.99m, 100);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void RefreshGridView()
        {
            // Refresh DataGridView
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = ProductDetails;
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form2
            Form2 form2 = new Form2(this);

            // Show Form2
            form2.Show();

            // Optionally, hide the current form
            this.Hide();
        }
    }
}
