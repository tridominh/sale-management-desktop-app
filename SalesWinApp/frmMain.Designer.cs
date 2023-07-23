namespace SalesWinApp
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem1 = new ToolStripMenuItem();
            productsToolStripMenuItem1 = new ToolStripMenuItem();
            membersToolStripMenuItem1 = new ToolStripMenuItem();
            salesToolStripMenuItem1 = new ToolStripMenuItem();
            viewReportsToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            updateProfileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripDate = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, ordersToolStripMenuItem1, productsToolStripMenuItem1, membersToolStripMenuItem1, salesToolStripMenuItem1, profileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(128, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem1
            // 
            ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            ordersToolStripMenuItem1.Size = new Size(67, 24);
            ordersToolStripMenuItem1.Text = "Orders";
            ordersToolStripMenuItem1.Click += ordersToolStripMenuItem1_Click;
            // 
            // productsToolStripMenuItem1
            // 
            productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            productsToolStripMenuItem1.Size = new Size(80, 24);
            productsToolStripMenuItem1.Text = "Products";
            productsToolStripMenuItem1.Click += productsToolStripMenuItem1_Click;
            // 
            // membersToolStripMenuItem1
            // 
            membersToolStripMenuItem1.Name = "membersToolStripMenuItem1";
            membersToolStripMenuItem1.Size = new Size(85, 24);
            membersToolStripMenuItem1.Text = "Members";
            membersToolStripMenuItem1.Click += membersToolStripMenuItem1_Click;
            // 
            // salesToolStripMenuItem1
            // 
            salesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { viewReportsToolStripMenuItem });
            salesToolStripMenuItem1.Name = "salesToolStripMenuItem1";
            salesToolStripMenuItem1.Size = new Size(57, 24);
            salesToolStripMenuItem1.Text = "Sales";
            // 
            // viewReportsToolStripMenuItem
            // 
            viewReportsToolStripMenuItem.Name = "viewReportsToolStripMenuItem";
            viewReportsToolStripMenuItem.Size = new Size(175, 26);
            viewReportsToolStripMenuItem.Text = "View reports";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateProfileToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(66, 24);
            profileToolStripMenuItem.Text = "Profile";
            // 
            // updateProfileToolStripMenuItem
            // 
            updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            updateProfileToolStripMenuItem.Size = new Size(188, 26);
            updateProfileToolStripMenuItem.Text = "Update Profile";
            updateProfileToolStripMenuItem.Click += updateProfileToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(188, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripDate });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripDate
            // 
            toolStripDate.Name = "toolStripDate";
            toolStripDate.Size = new Size(0, 16);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Sales Management";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripDate;
        private ToolStripMenuItem ordersToolStripMenuItem1;
        private ToolStripMenuItem productsToolStripMenuItem1;
        private ToolStripMenuItem membersToolStripMenuItem1;
        private ToolStripMenuItem salesToolStripMenuItem1;
        private ToolStripMenuItem viewReportsToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem updateProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}