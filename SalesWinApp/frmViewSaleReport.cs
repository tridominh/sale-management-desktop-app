using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmViewSaleReport : Form
    {
        OrderFullRepository orderFull;
        public frmViewSaleReport()
        {
            InitializeComponent();
            orderFull = new OrderFullRepository();
        }

        private void frmViewSaleReport_Load(object sender, EventArgs e)
        {
            lblTotalDiscount.Text = GetTotalDiscount().ToString();
            lblValueProds.Text = GetTotalValueOfProducts().ToString();
            lblTotalFreight.Text = GetTotalFreight().ToString();
            lblTotalIncome.Text = (GetTotalValueOfProducts() - GetTotalFreight() - GetTotalDiscount()).ToString();
        }

        private decimal GetTotalValueOfProducts() => orderFull.GetAll().Select(p => p.UnitPrice * p.Quantity).Sum();

        private decimal GetTotalFreight() => orderFull.GetAll().Select(p => p.Freight).Sum();

        private decimal GetTotalDiscount()
        {
            return orderFull.GetAll().Select(p => p.UnitPrice * p.Quantity * p.Discount).Sum();
        }
    }
}
