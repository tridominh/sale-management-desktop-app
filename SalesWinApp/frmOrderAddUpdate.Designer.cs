namespace SalesWinApp
{
    partial class frmOrderAddUpdate
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
            label5 = new Label();
            txtId = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dtOrderDate = new DateTimePicker();
            dtRequiredDate = new DateTimePicker();
            dtShippedDate = new DateTimePicker();
            label2 = new Label();
            txtFreight = new TextBox();
            label3 = new Label();
            cboMemberId = new ComboBox();
            cboProductId = new ComboBox();
            label4 = new Label();
            txtUnitPrice = new TextBox();
            label8 = new Label();
            txtQuantity = new TextBox();
            label9 = new Label();
            txtDiscount = new TextBox();
            label10 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(458, 409);
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
            label1.Location = new Point(19, 93);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 2;
            label1.Text = "Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 178);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 6;
            label5.Text = "Shipped Date";
            // 
            // txtId
            // 
            txtId.Location = new Point(152, 90);
            txtId.Name = "txtId";
            txtId.Size = new Size(241, 27);
            txtId.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 93);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 14;
            label6.Text = "Order Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(435, 133);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 15;
            label7.Text = "RequiredDate";
            // 
            // dtOrderDate
            // 
            dtOrderDate.Location = new Point(547, 93);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(241, 27);
            dtOrderDate.TabIndex = 16;
            // 
            // dtRequiredDate
            // 
            dtRequiredDate.Location = new Point(547, 133);
            dtRequiredDate.Name = "dtRequiredDate";
            dtRequiredDate.Size = new Size(241, 27);
            dtRequiredDate.TabIndex = 17;
            // 
            // dtShippedDate
            // 
            dtShippedDate.Location = new Point(547, 178);
            dtShippedDate.Name = "dtShippedDate";
            dtShippedDate.Size = new Size(241, 27);
            dtShippedDate.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 230);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 20;
            label2.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(547, 230);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(241, 27);
            txtFreight.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 180);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 22;
            label3.Text = "Member";
            // 
            // cboMemberId
            // 
            cboMemberId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMemberId.FormattingEnabled = true;
            cboMemberId.Location = new Point(152, 180);
            cboMemberId.Name = "cboMemberId";
            cboMemberId.Size = new Size(241, 28);
            cboMemberId.TabIndex = 23;
            // 
            // cboProductId
            // 
            cboProductId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductId.FormattingEnabled = true;
            cboProductId.Location = new Point(152, 135);
            cboProductId.Name = "cboProductId";
            cboProductId.Size = new Size(241, 28);
            cboProductId.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 135);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 24;
            label4.Text = "Product";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(152, 230);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(241, 27);
            txtUnitPrice.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 230);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 26;
            label8.Text = "Unit Price";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(152, 276);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(241, 27);
            txtQuantity.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 276);
            label9.Name = "label9";
            label9.Size = new Size(65, 20);
            label9.TabIndex = 28;
            label9.Text = "Quantity";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(152, 323);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(241, 27);
            txtDiscount.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 323);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 30;
            label10.Text = "Discount";
            // 
            // frmOrderAddUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDiscount);
            Controls.Add(label10);
            Controls.Add(txtQuantity);
            Controls.Add(label9);
            Controls.Add(txtUnitPrice);
            Controls.Add(label8);
            Controls.Add(cboProductId);
            Controls.Add(label4);
            Controls.Add(cboMemberId);
            Controls.Add(label3);
            Controls.Add(txtFreight);
            Controls.Add(label2);
            Controls.Add(dtShippedDate);
            Controls.Add(dtRequiredDate);
            Controls.Add(dtOrderDate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "frmOrderAddUpdate";
            Text = "frmAddUpdate";
            Load += frmAddUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private Label label5;
        private TextBox txtId;
        private Label label6;
        private Label label7;
        private DateTimePicker dtOrderDate;
        private DateTimePicker dtRequiredDate;
        private DateTimePicker dtShippedDate;
        private Label label2;
        private TextBox txtFreight;
        private Label label3;
        private ComboBox cboMemberId;
        private ComboBox cboProductId;
        private Label label4;
        private TextBox txtUnitPrice;
        private Label label8;
        private TextBox txtQuantity;
        private Label label9;
        private TextBox txtDiscount;
        private Label label10;
    }
}