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
            btnChooseFile = new Button();
            btnRemove = new Button();
            btnSaveToFile = new Button();
            txtFile = new TextBox();
            dgvCustomer = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(51, 48);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(75, 23);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "ChooseFile";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(51, 383);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(182, 383);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(75, 23);
            btnSaveToFile.TabIndex = 2;
            btnSaveToFile.Text = "SaveToFile";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(144, 48);
            txtFile.Name = "txtFile";
            txtFile.ReadOnly = true;
            txtFile.Size = new Size(644, 23);
            txtFile.TabIndex = 3;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(51, 100);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowTemplate.Height = 25;
            dgvCustomer.Size = new Size(737, 277);
            dgvCustomer.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCustomer);
            Controls.Add(txtFile);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnRemove);
            Controls.Add(btnChooseFile);
            Name = "Form1";
            Text = "CustomerManager";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChooseFile;
        private Button btnRemove;
        private Button btnSaveToFile;
        private TextBox txtFile;
        private DataGridView dgvCustomer;
    }
}