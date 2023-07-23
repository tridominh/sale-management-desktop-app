namespace SalesWinApp
{
    partial class frmProductView
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
            lblHead = new Label();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            btnClearSearch = new Button();
            btnSearchUnitInStock = new Button();
            btnSearchPrice = new Button();
            btnSearchName = new Button();
            txtSearch = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHead.Location = new Point(341, 29);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(108, 31);
            lblHead.TabIndex = 0;
            lblHead.Text = "Products";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(48, 223);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(223, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(452, 223);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(656, 223);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(793, 204);
            dataGridView1.TabIndex = 5;
            dataGridView1.SizeChanged += dataGridView1_SizeChanged;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(668, 96);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(94, 29);
            btnClearSearch.TabIndex = 17;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // btnSearchUnitInStock
            // 
            btnSearchUnitInStock.Location = new Point(586, 152);
            btnSearchUnitInStock.Name = "btnSearchUnitInStock";
            btnSearchUnitInStock.Size = new Size(162, 29);
            btnSearchUnitInStock.TabIndex = 16;
            btnSearchUnitInStock.Text = "Search by UnitInStock";
            btnSearchUnitInStock.UseVisualStyleBackColor = true;
            btnSearchUnitInStock.Click += btnSearchUnitInStock_Click;
            // 
            // btnSearchPrice
            // 
            btnSearchPrice.Location = new Point(319, 152);
            btnSearchPrice.Name = "btnSearchPrice";
            btnSearchPrice.Size = new Size(156, 29);
            btnSearchPrice.TabIndex = 15;
            btnSearchPrice.Text = "Search by UnitPrice";
            btnSearchPrice.UseVisualStyleBackColor = true;
            btnSearchPrice.Click += btnSearchPrice_Click;
            // 
            // btnSearchName
            // 
            btnSearchName.Location = new Point(63, 152);
            btnSearchName.Name = "btnSearchName";
            btnSearchName.Size = new Size(147, 29);
            btnSearchName.TabIndex = 14;
            btnSearchName.Text = "Search by Name";
            btnSearchName.UseVisualStyleBackColor = true;
            btnSearchName.Click += btnSearchName_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(168, 96);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(462, 27);
            txtSearch.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 96);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 12;
            label2.Text = "Search";
            // 
            // frmProductView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 474);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearchUnitInStock);
            Controls.Add(btnSearchPrice);
            Controls.Add(btnSearchName);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblHead);
            Name = "frmProductView";
            Text = "Product";
            Load += frmView_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHead;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dataGridView1;
        private Button btnClearSearch;
        private Button btnSearchUnitInStock;
        private Button btnSearchPrice;
        private Button btnSearchName;
        private TextBox txtSearch;
        private Label label2;
    }
}