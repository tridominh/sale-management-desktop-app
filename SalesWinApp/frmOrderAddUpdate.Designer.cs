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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            textBox3 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(547, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(547, 133);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(241, 27);
            dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(547, 178);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(241, 27);
            dateTimePicker3.TabIndex = 19;
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
            // textBox1
            // 
            textBox1.Location = new Point(547, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 21;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 180);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 28);
            comboBox1.TabIndex = 23;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(152, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(241, 28);
            comboBox2.TabIndex = 25;
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
            // textBox2
            // 
            textBox2.Location = new Point(152, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 27);
            textBox2.TabIndex = 27;
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
            // textBox3
            // 
            textBox3.Location = new Point(152, 276);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 27);
            textBox3.TabIndex = 29;
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
            // textBox4
            // 
            textBox4.Location = new Point(152, 323);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 27);
            textBox4.TabIndex = 31;
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
            Controls.Add(textBox4);
            Controls.Add(label10);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
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
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox2;
        private Label label8;
        private TextBox textBox3;
        private Label label9;
        private TextBox textBox4;
        private Label label10;
    }
}