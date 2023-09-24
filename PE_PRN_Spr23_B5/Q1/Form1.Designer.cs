namespace Q1
{
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
            btnChooseFile = new Button();
            txtFile = new TextBox();
            panel1 = new Panel();
            dgvProduct = new DataGridView();
            btnRemove = new Button();
            btnSaveToFile = new Button();
            groupBox1 = new GroupBox();
            txtPrice = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            rdisActive = new RadioButton();
            rdActive = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(147, 29);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(75, 23);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "ChooseFile";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(267, 29);
            txtFile.Name = "txtFile";
            txtFile.ReadOnly = true;
            txtFile.Size = new Size(259, 23);
            txtFile.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvProduct);
            panel1.Location = new Point(54, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 288);
            panel1.TabIndex = 2;
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(469, 285);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dgvProduct_CellClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(145, 384);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(348, 384);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(75, 23);
            btnSaveToFile.TabIndex = 4;
            btnSaveToFile.Text = "SaveToFile";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(rdisActive);
            groupBox1.Controls.Add(rdActive);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(553, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(235, 288);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(70, 127);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(70, 79);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Location = new Point(70, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // rdisActive
            // 
            rdisActive.AutoSize = true;
            rdisActive.Location = new Point(112, 212);
            rdisActive.Name = "rdisActive";
            rdisActive.Size = new Size(66, 19);
            rdisActive.TabIndex = 5;
            rdisActive.TabStop = true;
            rdisActive.Text = "isActive";
            rdisActive.UseVisualStyleBackColor = true;
            // 
            // rdActive
            // 
            rdActive.AutoSize = true;
            rdActive.Location = new Point(112, 172);
            rdActive.Name = "rdActive";
            rdActive.Size = new Size(58, 19);
            rdActive.TabIndex = 4;
            rdActive.TabStop = true;
            rdActive.Text = "Active";
            rdActive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 171);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "isActive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 130);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnRemove);
            Controls.Add(panel1);
            Controls.Add(txtFile);
            Controls.Add(btnChooseFile);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseFile;
        private TextBox txtFile;
        private Panel panel1;
        private DataGridView dgvProduct;
        private Button btnRemove;
        private Button btnSaveToFile;
        private GroupBox groupBox1;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtId;
        private RadioButton rdisActive;
        private RadioButton rdActive;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}