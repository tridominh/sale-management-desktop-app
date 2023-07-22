using BusinessObject.Entity;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProductView : Form
    {
        private BindingSource source;
        public string Title { get; set; }
        public Member? Member { get; set; }

        public frmProductView()
        {
            InitializeComponent();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void frmView_Load(object sender, EventArgs e)
        {

            ProductRepository product = new();
            source = new BindingSource();
            source.DataSource = product.GetAll();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = source;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmProductAddUpdate addNew = new()
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
            frmProductAddUpdate update = new()
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
