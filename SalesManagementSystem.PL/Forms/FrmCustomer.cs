using SalesManagementSystem.BLL.Services;
using SalesManagementSystem.DAL.Entity;

namespace SalesManagementSystem.PL.Forms
{
    public partial class FrmCustomer : Form
    {
        public object CustomerServices { get; private set; }

        public FrmCustomer()
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
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(" من فضلك ادخل الاميل ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show(" من فضلك ادخل اسم التليفون", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void LoadCategories()
        {
            List<Customer> categories = Customerservices.GetAllCustomers();

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
            btnUpdate.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم الصنف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show(" من فضلك ادخل الاميل ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show(" من فضلك ادخل اسم التليفون", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            Customer Customer = new Customer();
            Customer.Name = txtName.Text;
            Customer.Email = txtEmail.Text;
            Customer.Phone = txtPhone.Text;

            bool IsAdded = Customerservices.AddCustomer(Customer);

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

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnUpdate.Enabled = true;
            txtID.Text = txtName.Text = Search.Text = txtPhone.Text = txtEmail.Text = string.Empty;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DisAble();

            bool Vaild = Validation();
            if (Vaild)
            {

                Customer Customer = new Customer();
                Customer.ID = int.Parse(txtID.Text);
                Customer.Name = txtName.Text;
                Customer.Email = txtEmail.Text;
                Customer.Phone = txtPhone.Text;

                bool IsUpdated = Customerservices.UpdateCustomer(Customer);

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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DisAble();

            if (MessageBox.Show("هل انت متاكد من حذف هذه الصنف", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtID.Text = dvgSerach.CurrentRow.Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("من فضلك ادخل رقم الصنف", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                int ID = int.Parse(txtID.Text);
                bool IsDeleted = Customerservices.DeleteCustomer(ID);

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

        private void btnDeleteAll_Click_1(object sender, EventArgs e)
        {
            DisAble();

            bool AllDeleted = Customerservices.DeleteAllCustomer();

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

        private void dvgSerach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DisAble();
            txtID.Text = dvgSerach.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dvgSerach.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dvgSerach.CurrentRow.Cells[2].Value.ToString();
            txtPhone.Text = dvgSerach.CurrentRow.Cells[3].Value.ToString();
        }

        private void FrmCustomer_Load_1(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSearch.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnUpdate.Enabled = true;

            LoadCategories();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DisAble();
            string pattern = Search.Text;
            List<Customer> categories = Customerservices.GetCustomerByPattern(pattern);
            dvgSerach.AutoGenerateColumns = false;
            dvgSerach.DataSource = null;
            dvgSerach.DataSource = categories;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
