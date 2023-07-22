using BusinessObject.Entity;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderView : Form
    {
        private BindingSource source;
        public Member? Member { get; set; }

        public frmOrderView()
        {
            InitializeComponent();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void frmView_Load(object sender, EventArgs e)
        {
            OrderFullRepository order = new();
            source = new BindingSource();
            source.DataSource = order.GetAll();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderAddUpdate addNew = new()
            {
                Title = "Add New",
                InsertOrUpdate = true,
            };
            if (addNew.ShowDialog() == DialogResult.OK)
            {

            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderAddUpdate update = new()
            {
                Title = "Update",
                InsertOrUpdate = false,
            };
            if (update.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
