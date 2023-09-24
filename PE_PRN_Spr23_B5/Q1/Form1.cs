using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Q1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;

        }



        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"";
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (openFile.FileName != null)
                {
                    txtFile.Text = openFile.FileName;
                }
            }
            LoadDataFromFile(openFile.FileName);
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string selectedFile = txtFile.Text;
            try
            {
                using (StreamWriter writer = new StreamWriter(selectedFile))
                {
                    foreach (DataGridViewRow row in dgvProduct.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells["ID"].Value.ToString();
                            string name = row.Cells["Name"].Value.ToString();
                            int price = Convert.ToInt32(row.Cells["Price"].Value);
                            bool isActive = Convert.ToBoolean(row.Cells["isActive"].Value);
                            string line = $"{id};{name};{price};{isActive}";
                            writer.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Product saved to file successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving Product to file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataFromFile(string filePath)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Price", typeof(int));
            dataTable.Columns.Add("isActive", typeof(bool));
            //dataTable.Columns.Add("Salary");

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] fields = line.Split(';');
                int price = int.Parse(fields[2]);
                bool ismale = bool.Parse(fields[3]);
                dataTable.Rows.Add(fields[0], fields[1], price, ismale);
                //dataTable.Rows.Add(fields);
            }

            dgvProduct.DataSource = dataTable;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedCells.Count > 0)
            {
                int selectedIndex = dgvProduct.SelectedCells[0].RowIndex;
                dgvProduct.Rows.RemoveAt(selectedIndex);

            };
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtId.Text = dgvProduct.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtName.Text = dgvProduct.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtPrice.Text = dgvProduct.Rows[e.RowIndex].Cells["Price"].Value.ToString();

                bool isActive = Convert.ToBoolean(dgvProduct.Rows[e.RowIndex].Cells["isActive"].Value);
                rdActive.Checked = isActive;
                rdisActive.Checked = !isActive;

                groupBox1.Visible = true; // Hiển thị GroupBox khi chọn hàng
            }
        }
    }
}