using BusinessObject.DTO;
using BusinessObject.Entity;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderView : Form
    {
        OrderFullRepository orderFullRepo;

        private BindingSource source;
        public Member? Member { get; set; }

        public frmOrderView()
        {

            orderFullRepo = new OrderFullRepository();
            InitializeComponent();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void frmView_Load(object sender, EventArgs e)
        {
            if (Member == null)
            {
                LoadOrders();
            }
            else
            {
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                LoadOrders();
            }

        }

        private void LoadOrders(string searchString = null)
        {
            OrderFullRepository orderRep = new();
            source = new BindingSource();
            IEnumerable<OrderDTO> orders;
            if (Member == null)
            {
                orders = orderRep.GetAll();
            }
            else
            {
                orders = orderRep.GetAll().Where(o => o.MemberId == Member.Id);
            }
            if (searchString != null)
            {
                orders = orders.Where(m => m.UnitPrice.ToString().Contains(searchString));
            }
            source.DataSource = orders;

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
                addNew.Close();
                LoadOrders();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderAddUpdate update = new()
            {
                Title = "Update",
                InsertOrUpdate = false,
                OrderDTO = (OrderDTO)dataGridView1.SelectedRows[0].DataBoundItem,
            };
            if (update.ShowDialog() == DialogResult.OK)
            {
                update.Close();
                LoadOrders();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var orders = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(row => (OrderDTO)row.DataBoundItem);
            if (MessageBox.Show("Are you sure to delete", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var order in orders)
                {
                    orderFullRepo.Delete(Convert.ToInt32(order.Id), order.ProductId);
                }
                LoadOrders();
            }
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            LoadOrders(txtSearch.Text);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
    }
}
