using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberAddUpdate : Form
    {
        public string Title { get; set; }
        public bool InsertOrUpdate { get; set; }
        public frmMemberAddUpdate()
        {
            InitializeComponent();
        }

        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            Text = Title;
        }
    }
}
