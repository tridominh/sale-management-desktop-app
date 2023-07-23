using BusinessObject.Entity;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProductView : Form
    {
        private ProductRepository productRepo;
        private BindingSource source;
        public string Title { get; set; }
        public Member? Member { get; set; }

        public frmProductView()
        {
            productRepo = new ProductRepository();
            InitializeComponent();
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void frmView_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts(string searchString = null, string by = null)
        {
            ProductRepository productRep = new();
            source = new BindingSource();
            var products = productRep.GetAll();
            if (searchString != null)
            {
                if (by == "Name")
                {
                    products = products.Where(m => m.ProductName.Contains(searchString));
                }
                else if (by == "Price")
                {
                    products = products.Where(m => m.UnitPrice.ToString().Equals(searchString));
                }
                else if (by == "UnitInStock")
                {
                    products = products.Where(m => m.UnitInStock.ToString().Equals(searchString));
                }
            }
            source.DataSource = products;

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
                addNew.Close();
                LoadProducts();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductAddUpdate update = new()
            {
                Title = "Update",
                InsertOrUpdate = false,
                Product = (Product)dataGridView1.SelectedRows[0].DataBoundItem,
            };
            if (update.ShowDialog() == DialogResult.OK)
            {
                update.Close();
                LoadProducts();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var products = dataGridView1.SelectedRows.Cast<DataGridViewRow>().Select(row => (Product)row.DataBoundItem);
            if (MessageBox.Show("Are you sure to delete", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var product in products)
                {
                    productRepo.Delete(product.Id);
                }
                LoadProducts();
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text, "Name");
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text, "Price");
        }

        private void btnSearchUnitInStock_Click(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text, "UnitInStock");
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
