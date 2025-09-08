using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Entity;

namespace SalesManagementSystem.PL.Forms
{
    public partial class FrmProduct : Form
    {
        public object ProductServices { get; private set; }

        public FrmProduct()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم الصنف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show(" تاكد ان سعر الشراء اكبر من صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show(" تاكد ان سعر البيع اكبر من صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show(" تاكد ان سعر الكميه اكبر من صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudBuyPrice.Value <= 0)
            {
                MessageBox.Show(" تاكد ان سعر الشراء اكبر من صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudSalePrice.Value <= 0)
            {
                MessageBox.Show(" تاكد ان سعر البيع اكبر من صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show(" تاكد ان سعر الكميه اكبر من صفر", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Product Product = new Product();
            Product.Name = txtName.Text;
            Product.BuyPrice = nudBuyPrice.Value;
            Product.SalePrice = nudSalePrice.Value;
            Product.CategoryId = (int)cbCategory.SelectedValue;
            Product.Quantity = (decimal)nudQuantity.Value;

            bool IsAdded = Productservices.AddProduct(Product);

            if (IsAdded)
            {
                MessageBox.Show("تم الاضافه بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فشلت الاضافه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            LoadCategories();

        }
        private void LoadCategories()
        {
            List<Product> categories = Productservices.GetAllProducts();

            dvgSerach.AutoGenerateColumns = false;
            dvgSerach.DataSource = null;
            dvgSerach.DataSource = categories;
        }
        private void DisAble()
        {
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnUpdate.Enabled = true;

        }


        private void dvgSerach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisAble();
            txtID.Text = dvgSerach.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dvgSerach.CurrentRow.Cells[1].Value.ToString();
            nudBuyPrice.Value = Convert.ToDecimal(dvgSerach.CurrentRow.Cells[2].Value);
            nudSalePrice.Value = Convert.ToDecimal(dvgSerach.CurrentRow.Cells[3].Value);
            nudQuantity.Value = Convert.ToDecimal(dvgSerach.CurrentRow.Cells[4].Value);
            cbCategory.SelectedValue = dvgSerach.CurrentRow.Cells[5].Value;

        }

        private void brnUpdate_Click(object sender, EventArgs e)
        {
            DisAble();

            bool Vaild = Validation();
            if (Vaild)
            {

                Product Product = new Product();
                Product.ID = int.Parse(txtID.Text);
                Product.Name = txtName.Text;
                Product.BuyPrice = nudBuyPrice.Value;
                Product.SalePrice = nudSalePrice.Value;
                Product.CategoryId = Convert.ToInt32(cbCategory.SelectedValue);
                Product.Quantity = nudQuantity.Value;

                bool IsUpdated = Productservices.UpdateProduct(Product);

                if (IsUpdated)
                {
                    MessageBox.Show("تم التعديل بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("فشل التعديل", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadCategories();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DisAble();

            if (MessageBox.Show("هل انت متاكد من حذف هذه الصنف", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("من فضلك ادخل رقم الصنف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                int ID = int.Parse(txtID.Text);
                bool IsDeleted = Productservices.DeleteProduct(ID);

                if (IsDeleted)
                {
                    MessageBox.Show("تم الحذف بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("لم يتم الحذف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadCategories();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DisAble();

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

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            DisAble();
            string pattern = Search.Text;
            List<Product> categories = Productservices.GetProductByPattern(pattern);
            dvgSerach.AutoGenerateColumns = false;
            dvgSerach.DataSource = null;
            dvgSerach.DataSource = categories;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            DisAble();
            txtID.Text = txtName.Text = Search.Text = string.Empty;

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnUpdate.Enabled = true;

            LoadCategories();

            List<Category> categories = Categoryservices.GetAllCategorys();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "ID";
        }

        private void dvgSerach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisAble();
            txtID.Text = dvgSerach.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dvgSerach.CurrentRow.Cells[1].Value.ToString();
            nudBuyPrice.Value = Convert.ToDecimal(dvgSerach.CurrentRow.Cells[2].Value);
            nudSalePrice.Value = Convert.ToDecimal(dvgSerach.CurrentRow.Cells[3].Value);
            nudQuantity.Value = Convert.ToDecimal(dvgSerach.CurrentRow.Cells[4].Value);
            cbCategory.SelectedValue = dvgSerach.CurrentRow.Cells[5].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
