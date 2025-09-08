using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagementSystem.PL.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Owner = this;
            frmCategory.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = new FrmCustomer();
            frmCustomer.Owner = this;
            frmCustomer.Show();
            this.Hide();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct();
            frmProduct.Owner = this;
            frmProduct.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmSalesOrder frmSalesOrder = new FrmSalesOrder();
            frmSalesOrder.Owner = this;
            this.Hide();
            frmSalesOrder.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAllCustomerOrder frmCustomerOrder = new FrmAllCustomerOrder();
            frmCustomerOrder.Owner = this;
            frmCustomerOrder.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmStocks stock = new FrmStocks();
            stock.Owner = this;
            stock.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmStockDetails stockDetails = new FrmStockDetails();
            stockDetails.Owner = this;
            stockDetails.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }
    }
}
