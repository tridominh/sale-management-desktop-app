namespace SalesWinApp
{
    partial class frmMemberAddUpdate
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
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtId = new TextBox();
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
            // 
            // btnClose
            // 
            btnClose.Location = new Point(458, 394);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 104);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 169);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 221);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 4;
            label3.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 277);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 334);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(200, 166);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(352, 27);
            txtCompanyName.TabIndex = 7;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(200, 214);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(352, 27);
            txtCity.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(200, 274);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(352, 27);
            txtCountry.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 327);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 27);
            txtPassword.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 101);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(352, 27);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 44);
            label6.Name = "label6";
            label6.Size = new Size(22, 20);
            label6.TabIndex = 12;
            label6.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(200, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(352, 27);
            txtId.TabIndex = 13;
            // 
            // frmMemberAddUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "frmMemberAddUpdate";
            Text = "frmAddUpdate";
            Load += frmAddUpdate_Load;
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
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtId;
    }
}