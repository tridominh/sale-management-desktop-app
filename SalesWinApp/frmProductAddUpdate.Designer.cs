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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            label3.Location = new Point(67, 181);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 258);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Weight";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 324);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 6;
            label5.Text = "Unit In Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(352, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(200, 62);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(352, 27);
            textBox5.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(200, 251);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(352, 27);
            numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(200, 324);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(352, 27);
            numericUpDown2.TabIndex = 13;
            // 
            // frmProductAddUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}