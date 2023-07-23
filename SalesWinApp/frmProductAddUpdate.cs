using BusinessObject.Entity;
using DataAccess.Repository;
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
    public partial class frmProductAddUpdate : Form
    {
        private ProductRepository productRepo;
        public string Title { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product Product { get; set; }
        public frmProductAddUpdate()
        {
            productRepo = new ProductRepository();
            InitializeComponent();
        }

        private void frmAddUpdate_Load(object sender, EventArgs e)
        {
            Text = Title;
            txtId.Enabled = false;
            if (!InsertOrUpdate)
            {
                txtId.Text = Product.Id + "";
                txtCategoryId.Text = Product.CategoryId + "";
                txtProductName.Text = Product.ProductName;
                txtWeight.Text = Product.Weight;
                txtUnitInStock.Value = Product.UnitInStock;
                txtUnitPrice.Value = Product.UnitPrice;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new()
                {
                    CategoryId = Convert.ToInt32(txtCategoryId.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitInStock = Convert.ToInt32(txtUnitInStock.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                };
                if (InsertOrUpdate)
                {
                    productRepo.Insert(product);
                }
                else
                {
                    product.Id = Product.Id;
                    productRepo.Update(product);
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
