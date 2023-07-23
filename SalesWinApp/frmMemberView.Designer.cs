namespace SalesWinApp
{
    partial class frmMemberView
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
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearchEmail = new Button();
            btnClearSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblHead
            // 
            lblHead.AutoSize = true;
            lblHead.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHead.Location = new Point(341, 29);
            lblHead.Name = "lblHead";
            lblHead.Size = new Size(112, 31);
            lblHead.TabIndex = 0;
            lblHead.Text = "Members";
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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SizeChanged += dataGridView1_SizeChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 92);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(170, 92);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(462, 27);
            txtSearch.TabIndex = 7;
            // 
            // btnSearchEmail
            // 
            btnSearchEmail.Location = new Point(325, 152);
            btnSearchEmail.Name = "btnSearchEmail";
            btnSearchEmail.Size = new Size(147, 29);
            btnSearchEmail.TabIndex = 8;
            btnSearchEmail.Text = "Search by Email";
            btnSearchEmail.UseVisualStyleBackColor = true;
            btnSearchEmail.Click += btnSearchEmail_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.Location = new Point(670, 92);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(94, 29);
            btnClearSearch.TabIndex = 11;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = true;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // frmMemberView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 474);
            Controls.Add(btnClearSearch);
            Controls.Add(btnSearchEmail);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(lblHead);
            Name = "frmMemberView";
            Text = "Members";
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
        private Label label1;
        private TextBox txtSearch;
        private Button btnSearchEmail;
        private Button btnClearSearch;
    }
}