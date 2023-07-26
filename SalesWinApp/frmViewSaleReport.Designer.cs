namespace SalesWinApp
{
    partial class frmViewSaleReport
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblTotalDiscount = new Label();
            lblTotalFreight = new Label();
            lblValueProds = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotalIncome = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 111);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Total Freight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 50);
            label2.Name = "label2";
            label2.Size = new Size(165, 40);
            label2.TabIndex = 1;
            label2.Text = "Total value of products \r\n(Unit Price x Quantity)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 172);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Total discount";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lblTotalDiscount);
            groupBox1.Controls.Add(lblTotalFreight);
            groupBox1.Controls.Add(lblValueProds);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(62, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(679, 218);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(228, 172);
            label8.Name = "label8";
            label8.Size = new Size(19, 25);
            label8.TabIndex = 9;
            label8.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(228, 106);
            label7.Name = "label7";
            label7.Size = new Size(19, 25);
            label7.TabIndex = 8;
            label7.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 192, 0);
            label6.Location = new Point(229, 50);
            label6.Name = "label6";
            label6.Size = new Size(24, 25);
            label6.TabIndex = 7;
            label6.Text = "+";
            // 
            // lblTotalDiscount
            // 
            lblTotalDiscount.AutoSize = true;
            lblTotalDiscount.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalDiscount.ForeColor = Color.Red;
            lblTotalDiscount.Location = new Point(293, 172);
            lblTotalDiscount.Name = "lblTotalDiscount";
            lblTotalDiscount.Size = new Size(59, 25);
            lblTotalDiscount.TabIndex = 6;
            lblTotalDiscount.Text = "label5";
            // 
            // lblTotalFreight
            // 
            lblTotalFreight.AutoSize = true;
            lblTotalFreight.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalFreight.ForeColor = Color.Red;
            lblTotalFreight.Location = new Point(293, 106);
            lblTotalFreight.Name = "lblTotalFreight";
            lblTotalFreight.Size = new Size(59, 25);
            lblTotalFreight.TabIndex = 5;
            lblTotalFreight.Text = "label5";
            // 
            // lblValueProds
            // 
            lblValueProds.AutoSize = true;
            lblValueProds.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblValueProds.ForeColor = Color.FromArgb(0, 192, 0);
            lblValueProds.Location = new Point(293, 50);
            lblValueProds.Name = "lblValueProds";
            lblValueProds.Size = new Size(59, 25);
            lblValueProds.TabIndex = 4;
            lblValueProds.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(279, 29);
            label4.Name = "label4";
            label4.Size = new Size(269, 38);
            label4.TabIndex = 3;
            label4.Text = "Sales Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(111, 340);
            label5.Name = "label5";
            label5.Size = new Size(140, 28);
            label5.TabIndex = 5;
            label5.Text = "Total Income:";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalIncome.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalIncome.Location = new Point(349, 340);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(65, 28);
            lblTotalIncome.TabIndex = 5;
            lblTotalIncome.Text = "label5";
            // 
            // frmViewSaleReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalIncome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "frmViewSaleReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sale Report";
            Load += frmViewSaleReport_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label lblValueProds;
        private Label label4;
        private Label label5;
        private Label lblTotalIncome;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label lblTotalDiscount;
        private Label lblTotalFreight;
    }
}