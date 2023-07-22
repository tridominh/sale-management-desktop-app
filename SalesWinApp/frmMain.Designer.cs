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
            createToolStripMenuItem1 = new ToolStripMenuItem();
            viewAllToolStripMenuItem1 = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            productsToolStripMenuItem1 = new ToolStripMenuItem();
            createToolStripMenuItem2 = new ToolStripMenuItem();
            viewAllToolStripMenuItem2 = new ToolStripMenuItem();
            updateToolStripMenuItem2 = new ToolStripMenuItem();
            deleteToolStripMenuItem2 = new ToolStripMenuItem();
            membersToolStripMenuItem1 = new ToolStripMenuItem();
            createToolStripMenuItem3 = new ToolStripMenuItem();
            viewAllToolStripMenuItem3 = new ToolStripMenuItem();
            updateToolStripMenuItem3 = new ToolStripMenuItem();
            deleteToolStripMenuItem3 = new ToolStripMenuItem();
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
            ordersToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem1, viewAllToolStripMenuItem1, updateToolStripMenuItem, deleteToolStripMenuItem1 });
            ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            ordersToolStripMenuItem1.Size = new Size(67, 24);
            ordersToolStripMenuItem1.Text = "Orders";
            // 
            // createToolStripMenuItem1
            // 
            createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            createToolStripMenuItem1.Size = new Size(146, 26);
            createToolStripMenuItem1.Text = "Create";
            // 
            // viewAllToolStripMenuItem1
            // 
            viewAllToolStripMenuItem1.Name = "viewAllToolStripMenuItem1";
            viewAllToolStripMenuItem1.Size = new Size(146, 26);
            viewAllToolStripMenuItem1.Text = "View All";
            viewAllToolStripMenuItem1.Click += viewAllToolStripMenuItem1_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(146, 26);
            updateToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(146, 26);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // productsToolStripMenuItem1
            // 
            productsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem2, viewAllToolStripMenuItem2, updateToolStripMenuItem2, deleteToolStripMenuItem2 });
            productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            productsToolStripMenuItem1.Size = new Size(80, 24);
            productsToolStripMenuItem1.Text = "Products";
            // 
            // createToolStripMenuItem2
            // 
            createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            createToolStripMenuItem2.Size = new Size(144, 26);
            createToolStripMenuItem2.Text = "Create";
            // 
            // viewAllToolStripMenuItem2
            // 
            viewAllToolStripMenuItem2.Name = "viewAllToolStripMenuItem2";
            viewAllToolStripMenuItem2.Size = new Size(144, 26);
            viewAllToolStripMenuItem2.Text = "View all";
            viewAllToolStripMenuItem2.Click += viewAllToolStripMenuItem2_Click;
            // 
            // updateToolStripMenuItem2
            // 
            updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            updateToolStripMenuItem2.Size = new Size(144, 26);
            updateToolStripMenuItem2.Text = "Update";
            // 
            // deleteToolStripMenuItem2
            // 
            deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            deleteToolStripMenuItem2.Size = new Size(144, 26);
            deleteToolStripMenuItem2.Text = "Delete";
            // 
            // membersToolStripMenuItem1
            // 
            membersToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { createToolStripMenuItem3, viewAllToolStripMenuItem3, updateToolStripMenuItem3, deleteToolStripMenuItem3 });
            membersToolStripMenuItem1.Name = "membersToolStripMenuItem1";
            membersToolStripMenuItem1.Size = new Size(85, 24);
            membersToolStripMenuItem1.Text = "Members";
            // 
            // createToolStripMenuItem3
            // 
            createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            createToolStripMenuItem3.Size = new Size(144, 26);
            createToolStripMenuItem3.Text = "Create";
            // 
            // viewAllToolStripMenuItem3
            // 
            viewAllToolStripMenuItem3.Name = "viewAllToolStripMenuItem3";
            viewAllToolStripMenuItem3.Size = new Size(144, 26);
            viewAllToolStripMenuItem3.Text = "View all";
            viewAllToolStripMenuItem3.Click += viewAllToolStripMenuItem3_Click;
            // 
            // updateToolStripMenuItem3
            // 
            updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            updateToolStripMenuItem3.Size = new Size(144, 26);
            updateToolStripMenuItem3.Text = "Update";
            // 
            // deleteToolStripMenuItem3
            // 
            deleteToolStripMenuItem3.Name = "deleteToolStripMenuItem3";
            deleteToolStripMenuItem3.Size = new Size(144, 26);
            deleteToolStripMenuItem3.Text = "Delete";
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
            viewReportsToolStripMenuItem.Size = new Size(224, 26);
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
            updateProfileToolStripMenuItem.Size = new Size(224, 26);
            updateProfileToolStripMenuItem.Text = "Update Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
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
        private ToolStripMenuItem createToolStripMenuItem1;
        private ToolStripMenuItem viewAllToolStripMenuItem1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem productsToolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem2;
        private ToolStripMenuItem viewAllToolStripMenuItem2;
        private ToolStripMenuItem updateToolStripMenuItem2;
        private ToolStripMenuItem deleteToolStripMenuItem2;
        private ToolStripMenuItem membersToolStripMenuItem1;
        private ToolStripMenuItem createToolStripMenuItem3;
        private ToolStripMenuItem viewAllToolStripMenuItem3;
        private ToolStripMenuItem updateToolStripMenuItem3;
        private ToolStripMenuItem deleteToolStripMenuItem3;
        private ToolStripMenuItem salesToolStripMenuItem1;
        private ToolStripMenuItem viewReportsToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem updateProfileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}