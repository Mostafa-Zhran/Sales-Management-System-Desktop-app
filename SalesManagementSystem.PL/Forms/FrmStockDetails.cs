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

namespace SalesManagementSystem.PL.Forms
{
    public partial class FrmStockDetails : Form
    {
        public FrmStockDetails()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmStockDetails_Load(object sender, EventArgs e)
        {
            List<StockDetails> list = new List<StockDetails>();
            list = StockDetailsServices.GetAllStockDetailss();
            dvgData.AutoGenerateColumns = false;
            dvgData.DataSource = null;
            dvgData.DataSource = list;
        }

        private void dvgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
