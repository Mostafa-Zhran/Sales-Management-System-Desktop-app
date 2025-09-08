using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL;
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

namespace SalesManagementSystem.PL.Forms
{
    public partial class FrmStocks : Form
    {
        public FrmStocks()
        {
            InitializeComponent();
        }

        private void butAddStock_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ID = Convert.ToInt32(txtID.Text);
            stock.Location = txtlocation.Text;
            stock.Money = Convert.ToDecimal(txtMoney.Text);

            bool IsAdded = StockServices.AddStock(stock);
            if (IsAdded)
            {
                MessageBox.Show("تم بناء المخزن بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            List<Stock> stocks = new List<Stock>();
            stocks = StockServices.GetAllStocks();
            dvgData.AutoGenerateColumns = true;
            dvgData.DataSource = null;
            dvgData.DataSource = stocks;

        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من حذف هذا المخزن", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("من فضلك ادخل رقم الصنف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                int ID = int.Parse(txtID.Text);
                bool IsDeleted = StockServices.DeleteStock(ID);

                if (IsDeleted)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            List<Stock> stocks = new List<Stock>();
            stocks = StockServices.GetAllStocks();
            dvgData.AutoGenerateColumns = true;
            dvgData.DataSource = null;
            dvgData.DataSource = stocks;


        }

        private void FrmStocks_Load(object sender, EventArgs e)
        {
            int value = 0;
            txtMoney.Text = value.ToString();
            txtMoney.Enabled = false;

            List<Stock> stocks = new List<Stock>();
            stocks = StockServices.GetAllStocks();
            dvgData.AutoGenerateColumns = false;
            dvgData.DataSource = null;
            dvgData.DataSource = stocks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dvgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dvgData.CurrentRow.Cells[0].Value.ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
