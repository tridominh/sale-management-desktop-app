using BusinessObject.Entity;
using BusinessObject.Model;
using System.Diagnostics.Metrics;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public frmLogin login { get; set; }
        public int? Role { get; set; } = null;
        public Member? Member { get; set; } = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Role == 1)
            {
                updateProfileToolStripMenuItem.Enabled = false;
            }
            if (Role == 2)
            {
                productsToolStripMenuItem1.Enabled = false;
                membersToolStripMenuItem1.Enabled = false;
                salesToolStripMenuItem1.Enabled = false;
            }
            toolStripDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }



        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmOrderView order = new()
            {
                Member = Member,
            };
            order.MdiParent = this;
            order.StartPosition = FormStartPosition.CenterParent;
            order.Show();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProductView product = new()
            {
                Title = "Products",
                Member = Member,
            };
            product.MdiParent = this;
            product.StartPosition = FormStartPosition.CenterParent;
            product.Show();
        }

        private void membersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMemberView member = new()
            {
                Title = "Members",
                Member = Member,
            };
            member.MdiParent = this;
            member.StartPosition = FormStartPosition.CenterParent;
            member.Show();
        }

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberAddUpdate update = new()
            {
                Title = "Update",
                InsertOrUpdate = false,
                Member = Member,
            };
            if (update.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Update profile succeeded!");
                update.Close();
                Member = update.Member;
            }
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewSaleReport viewSale = new();
            viewSale.ShowDialog();
        }
    }
}