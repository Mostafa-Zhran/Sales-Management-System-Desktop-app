using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SalesManagementSystem.PL.Forms
{
    public partial class FrmAllCustomerOrder : Form
    {
        public FrmAllCustomerOrder()
        {
            InitializeComponent();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(btnSearchorder.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم البحث", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                string pattern = btnSearchorder.Text;
                List<CustomerOrder> CustomerOrders = CustomerOrdersServices.GetCustomerOrderByPattern(pattern);
                dvgSerach.AutoGenerateColumns = true;
                dvgSerach.DataSource = null;
                dvgSerach.DataSource = CustomerOrders;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dvgSerach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CustomerOrder> CustomerOrders = CustomerOrdersServices.GetAllCutomerOrder();
            dvgSerach.AutoGenerateColumns = true;
            dvgSerach.DataSource = null;
            dvgSerach.DataSource = CustomerOrders;
        }

        private void FrmAllCustomerOrder_Load(object sender, EventArgs e)
        {
            List<CustomerOrder> CustomerOrders = CustomerOrdersServices.GetAllCutomerOrder();
            dvgSerach.AutoGenerateColumns = true;
            dvgSerach.DataSource = null;
            dvgSerach.DataSource = CustomerOrders;
        }
    }
}


