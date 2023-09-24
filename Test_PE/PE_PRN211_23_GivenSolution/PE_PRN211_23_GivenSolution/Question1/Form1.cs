namespace Question1
{
    public partial class Form1 : Form
    {
        List<Customer> customers;
        string selectedFile;
        public Form1()
        {
            InitializeComponent();
            customers = new List<Customer>();
            selectedFile = null;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "D:\\";  // Set the initial directory
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = openFileDialog.FileName;



                    using (StreamReader reader = new StreamReader(selectedFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Do something with each line
                            string[] parts = line.Split(',');
                            Customer customer = new Customer()
                            {
                                Id = parts[0],
                                Name = parts[1],
                                Male = bool.Parse(parts[2]),
                                Dob = DateOnly.Parse(parts[3])
                            };

                            customers.Add(customer);

                        }
                    }

                    dgvCustomer.DataSource = customers;
                }


            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var currentRow = dgvCustomer.CurrentRow.Index;

            dgvCustomer.DataSource = null;

            customers.RemoveAt(currentRow);

            dgvCustomer.DataSource = customers;
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(selectedFile))
            {
                foreach (Customer customer in customers)
                {
                    writer.WriteLine($"{customer.Id},{customer.Name},{customer.Male},{customer.Dob}");
                }
            }

            MessageBox.Show("Save successfully");
        }
    }
}