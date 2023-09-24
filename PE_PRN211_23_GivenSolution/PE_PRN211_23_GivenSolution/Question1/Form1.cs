using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Question1
{
    public partial class Form1 : Form
    {

        private List<Product> products;
        private string selectedFile;

        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
            selectedFile = null;
            loadproduct();
        }

        private void loadproduct()
        {
            var data = products.Select(item => new
            {
                item.Id,
                item.Name,
                item.Price,
                item.IsActive
            }).ToList();

            dgvProduct.DataSource = data;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "D:\\"; // Set the initial directory
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = saveFileDialog.FileName;

                    using (StreamWriter writer = new StreamWriter(selectedFile))
                    {
                        foreach (Product product in products)
                        {
                            writer.WriteLine($"{product.Id},{product.Name},{product.Price},{product.IsActive}");
                        }
                    }

                    MessageBox.Show("Save successful.");
                }
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            // Get the input values from the text boxes and radio buttons
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Invalid ID. Please enter a valid numeric ID.");
                return;
            }

            string name = txtName.Text.Trim();
            decimal price = nmPrice.Value;
            bool isActive = rdTrue.Checked;

            // Validate the input values (e.g., check if the ID is unique)
            if (IsIdUnique(id))
            {
                // Create a new Product instance with the input values
                Product newProduct = new Product(id, name, price, isActive);

                // Add the new product to the list
                products.Add(newProduct);

                // Refresh the data grid view
                loadproduct();

                // Clear the input fields
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                nmPrice.Value = 0;
                rdTrue.Checked = false;
                rdFalse.Checked = false;

                MessageBox.Show("Product added successfully.");
            }
            else
            {
                MessageBox.Show("Product ID must be unique.");
            }
        }

        private bool IsIdUnique(int id)
        {
            // Check if the ID already exists in the list of products
            return !products.Any(product => product.Id == id);
        }
    }
}
