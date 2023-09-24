namespace Question1
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
            groupBox1 = new GroupBox();
            btnAddToList = new Button();
            rdFalse = new RadioButton();
            rdTrue = new RadioButton();
            nmPrice = new NumericUpDown();
            txtName = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvProduct = new DataGridView();
            btnSaveToFile = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddToList);
            groupBox1.Controls.Add(rdFalse);
            groupBox1.Controls.Add(rdTrue);
            groupBox1.Controls.Add(nmPrice);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 407);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ProductInfo";
            // 
            // btnAddToList
            // 
            btnAddToList.Location = new Point(214, 367);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(103, 21);
            btnAddToList.TabIndex = 9;
            btnAddToList.Text = "AddToList";
            btnAddToList.UseVisualStyleBackColor = true;
            btnAddToList.Click += btnAddToList_Click;
            // 
            // rdFalse
            // 
            rdFalse.AutoSize = true;
            rdFalse.Location = new Point(108, 334);
            rdFalse.Name = "rdFalse";
            rdFalse.Size = new Size(51, 19);
            rdFalse.TabIndex = 8;
            rdFalse.TabStop = true;
            rdFalse.Text = "False";
            rdFalse.UseVisualStyleBackColor = true;
            // 
            // rdTrue
            // 
            rdTrue.AutoSize = true;
            rdTrue.Location = new Point(108, 291);
            rdTrue.Name = "rdTrue";
            rdTrue.Size = new Size(47, 19);
            rdTrue.TabIndex = 7;
            rdTrue.TabStop = true;
            rdTrue.Text = "True";
            rdTrue.UseVisualStyleBackColor = true;
            // 
            // nmPrice
            // 
            nmPrice.Location = new Point(108, 205);
            nmPrice.Name = "nmPrice";
            nmPrice.Size = new Size(168, 23);
            nmPrice.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(108, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 23);
            txtName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(108, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(168, 23);
            txtID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 295);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "IsActive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 207);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 131);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "ProductName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 55);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "ProductID";
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(356, 12);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowTemplate.Height = 25;
            dgvProduct.Size = new Size(642, 511);
            dgvProduct.TabIndex = 1;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(629, 529);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(120, 23);
            btnSaveToFile.TabIndex = 2;
            btnSaveToFile.Text = "SaveToFile";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 571);
            Controls.Add(btnSaveToFile);
            Controls.Add(dgvProduct);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "AddProductForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvProduct;
        private Button btnAddToList;
        private RadioButton rdFalse;
        private RadioButton rdTrue;
        private NumericUpDown nmPrice;
        private TextBox txtName;
        private Button btnSaveToFile;
    }
}