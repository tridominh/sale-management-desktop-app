using BusinessObject.DTO;
using BusinessObject.Entity;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmOrderAddUpdate : Form
    {
        OrderFullRepository orderFullRepo;
        MemberRepository memberRepo;
        ProductRepository productRepo;
        public string Title { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderDTO OrderDTO { get; set; }
        public frmOrderAddUpdate()
        {
            memberRepo = new MemberRepository();
            productRepo = new ProductRepository();
            orderFullRepo = new OrderFullRepository();
            InitializeComponent();
        }

        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            Text = Title;
            cboMemberId.DataSource = memberRepo.GetAll().Select(m => m.Id).ToList();
            cboProductId.DataSource = productRepo.GetAll().Select(p => p.Id).ToList();
            txtId.Enabled = false;
            if (!InsertOrUpdate)
            {
                txtId.Text = OrderDTO.Id + "";
                cboProductId.Text = OrderDTO.ProductId + "";
                cboMemberId.Text = OrderDTO.MemberId + "";
                txtUnitPrice.Text = OrderDTO.UnitPrice + "";
                txtQuantity.Text = OrderDTO.Quantity + "";
                txtDiscount.Text = OrderDTO.Discount + "";
                dtOrderDate.Value = OrderDTO.OrderDate;
                dtRequiredDate.Value = OrderDTO.RequiredDate;
                dtShippedDate.Value = OrderDTO.ShippedDate;
                txtFreight.Text = OrderDTO.Freight + "";

                txtId.Enabled = false;
                cboProductId.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDTO orderDTO = new()
                {
                    ProductId = Convert.ToInt32(cboProductId.Text),
                    MemberId = Convert.ToInt32(cboMemberId.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                    Quantity = Convert.ToInt32(txtQuantity.Text),
                    Discount = Convert.ToDecimal(txtDiscount.Text),
                    OrderDate = dtOrderDate.Value,
                    RequiredDate = dtRequiredDate.Value,
                    ShippedDate = dtShippedDate.Value,
                    Freight = Convert.ToDecimal(txtFreight.Text),
                };
                if (InsertOrUpdate)
                {
                    orderFullRepo.Insert(orderDTO);
                }
                else
                {
                    orderFullRepo.Update(orderDTO);
                }
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
