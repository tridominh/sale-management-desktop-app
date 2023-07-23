namespace SalesWinApp
{
    partial class frmProductAddUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCategoryId = new TextBox();
            txtProductName = new TextBox();
            txtId = new TextBox();
            txtUnitInStock = new NumericUpDown();
            txtUnitPrice = new NumericUpDown();
            label6 = new Label();
            txtWeight = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtUnitInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(458, 394);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 65);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 117);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Category Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 170);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 233);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 284);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 6;
            label5.Text = "Unit In Stock";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(200, 117);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(352, 27);
            txtCategoryId.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(200, 170);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(352, 27);
            txtProductName.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(200, 62);
            txtId.Name = "txtId";
            txtId.Size = new Size(352, 27);
            txtId.TabIndex = 11;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(200, 284);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(352, 27);
            txtUnitInStock.TabIndex = 13;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(200, 343);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(352, 27);
            txtUnitPrice.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 343);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 14;
            label6.Text = "Unit Price";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(200, 230);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(352, 27);
            txtWeight.TabIndex = 16;
            // 
            // frmProductAddUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtWeight);
            Controls.Add(txtUnitPrice);
            Controls.Add(label6);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtId);
            Controls.Add(txtProductName);
            Controls.Add(txtCategoryId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "frmProductAddUpdate";
            Text = "frmAddUpdate";
            Load += frmAddUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)txtUnitInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCategoryId;
        private TextBox txtProductName;
        private TextBox txtId;
        private NumericUpDown txtUnitInStock;
        private NumericUpDown txtUnitPrice;
        private Label label6;
        private TextBox txtWeight;
    }
}