using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Entity;
using System.Windows.Forms;

namespace SalesManagementSystem.PL.Forms
{
    public partial class FrmSalesOrder : Form
    {
        private List<SaleOrderProduct> SalesProduct = new List<SaleOrderProduct>();

        public object ProductServices { get; private set; }

        public FrmSalesOrder()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dvgSerach.Rows.Count > 0)
            {
                    if (string.IsNullOrEmpty(txtID.Text))
                    {
                        MessageBox.Show("من فضلك ادخل اسم العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (string.IsNullOrEmpty(cmbName.Text))
                    {
                        MessageBox.Show(" من فضلك ادخل اسم العميل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                SaleOrder order = new SaleOrder();
                order.OrderDate = DateTime.Now;
                order.CustomerId = (int)cmbName.SelectedValue;
                order.TotalOrder = nudTotalPrice.Value;
                bool IsAdded = SalesOrderservices.AddSaleOrder(order);
                if (IsAdded)
                {
                    bool AddSaleProduct = SalesOrderProductServices.AddSaleOrderProduct(SalesProduct);
                    if (AddSaleProduct)
                    {
                        List<Product> products = new List<Product>();
                        for ( int i = 0; i <= dvgSerach.Rows.Count -1; i++  )
                        {
                            Product P1 = new Product();
                            P1.ID = (int)dvgSerach.Rows[i].Cells[0].Value;
                            P1.Quantity = Convert.ToDecimal(dvgSerach.Rows[i].Cells[2].Value);
                            products.Add(P1);
                        }
                        bool isUpdateProduct = Productservices.UpdateProductAfterSale(products);
                        if (isUpdateProduct)
                        {
                            Stock stock = new Stock();
                            stock.ID = Convert.ToInt32(cmbStock.SelectedValue);
                            stock.Money = (decimal)nudTotalPrice.Value;
                            bool UpdateStock = StockServices.UpdateStock(stock);
                            if (UpdateStock)
                            {
                                StockDetails stockDetails = new StockDetails();
                                stockDetails.StockId = (int)cmbStock.SelectedValue;
                                stockDetails.SaleOedrId = (SalesOrderservices.GetlastOrderID());
                                stockDetails.StockType = type.Expensive;
                                stockDetails.DateTime = dtDate.Value;
                                stockDetails.Money = (decimal)nudSaleQuantity.Value;
                                bool AddStockDetails = StockDetailsServices.AddStockDetails(stockDetails);
                                if (AddStockDetails)
                                {
                                    MessageBox.Show("تم الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                dvgSerach.DataSource = null;
                                dvgSerach.Rows.Clear();
                                nudTotalPrice.Value = 0;

                            }

                        }
                    }
                }
            }

        }
        private void LoadCategories()
        {
            List<Product> categories = Productservices.GetAllProducts();

            dvgSerach.AutoGenerateColumns = false;
            dvgSerach.DataSource = null;
            dvgSerach.DataSource = categories;

        }

     
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من حذف هذا المنتج ", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dvgSerach.CurrentRow != null)
                {
                    int productId = (int)dvgSerach.CurrentRow.Cells[0].Value;

                    var itemToRemove = SalesProduct.FirstOrDefault(p => p.ProductID == productId);
                    if (itemToRemove != null)
                    {
                        SalesProduct.Remove(itemToRemove);
                    }

                    dvgSerach.DataSource = null;
                    dvgSerach.DataSource = SalesProduct;

                    decimal total = SalesProduct.Sum(p => p.ProductTotalPrice);
                    nudTotalPrice.Value = (int)total;
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            bool AllDeleted = Productservices.DeleteAllProduct();

            if (MessageBox.Show("هل انت متاكد من حذف كل المجموعات", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (AllDeleted)
                {
                    MessageBox.Show("تم حذف الجميع", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadCategories();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم المجموعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return ;

            }
            else
            {
                int ID = (int)cmbProduct.SelectedValue;
                Product product = Productservices.GetProductbyId(ID);
                if (nudSaleQuantity.Value > product.Quantity)
                {
                    MessageBox.Show("الكميه المباعه اكبر من المتوفره حاليا", "تحذير",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return ;
                }
                else
                {
                    decimal saleQty = nudSaleQuantity.Value;


                    var existingItem = SalesProduct.FirstOrDefault(p => p.ProductID == product.ID);

                    if (existingItem != null)
                    {
                        existingItem.ProductQuantity += saleQty;
                        existingItem.ProductTotalPrice = existingItem.ProductQuantity * existingItem.ProductPrice;
                    }
                    else
                    {
                        SaleOrderProduct saleItem = new SaleOrderProduct();
                        saleItem.ProductID = product.ID;
                        saleItem.ProductName = product.Name;
                        saleItem.ProductPrice = product.SalePrice;
                        saleItem.ProductQuantity = saleQty;
                        saleItem.ProductTotalPrice = product.SalePrice * saleQty;
                        saleItem.SaleOrderID = int.Parse(txtID.Text);  // رقم الفاتورة


                        SalesProduct.Add(saleItem);
                    }

                    dvgSerach.AutoGenerateColumns = false;
                    dvgSerach.DataSource = null;
                    dvgSerach.DataSource = SalesProduct;

                    decimal total = SalesProduct.Sum(p => p.ProductTotalPrice);
                    nudTotalPrice.Value = (int)total;
                }
            }
            

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

            List<Customer> customers = Customerservices.GetAllCustomers();
            cmbName.DataSource = customers;
            cmbName.DisplayMember = "Name";
            cmbName.ValueMember = "ID";
            cmbPhone.DataSource = customers;
            cmbPhone.DisplayMember = "Phone";
            List<Product> products = Productservices.GetAllProducts();
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "ID";
            List<Stock> Stock = StockServices.GetStockID();
            cmbStock.DataSource = Stock;
            cmbStock.DisplayMember = "ID";
            cmbStock.ValueMember = "ID";

            txtID.Text = (SalesOrderservices.GetlastOrderID() + 1).ToString();

        }

        private void dvgSerach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dvgSerach.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
      
    }
}
