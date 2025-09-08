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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("من فضلك ادخل رقم المجموعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("من فضلك ادخل اسم المجموعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Category category = new Category();
            category.Name = txtName.Text;
            bool IsAdded = Categoryservices.AddCategory(category);

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
            List<Category> categories = Categoryservices.GetAllCategorys();

            dvgSerach.AutoGenerateColumns = true;
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

        private void frmCategory_Load_1(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnNew.Enabled = true;
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnUpdate.Enabled = true;

            LoadCategories();
        }

        private void dvgSerach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisAble();
            txtID.Text = dvgSerach.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dvgSerach.CurrentRow.Cells[1].Value.ToString();

        }

        private void brnUpdate_Click(object sender, EventArgs e)
        {
            DisAble();

            bool Vaild = Validation();
            if (Vaild)
            {

                Category category = new Category();
                category.ID = int.Parse(txtID.Text);
                category.Name = txtName.Text;
                bool IsUpdated = Categoryservices.UpdateCategory(category);

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

            if (MessageBox.Show("هل انت متاكد من حذف هذه المجموعه", "تاكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("من فضلك ادخل رقم المجموعه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                int ID = int.Parse(txtID.Text);
                bool IsDeleted = Categoryservices.DeleteCategory(ID);

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

            bool AllDeleted = Categoryservices.DeleteAllCategory();

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
            List<Category> categories = Categoryservices.GetCategoryByPattern(pattern);
            dvgSerach.AutoGenerateColumns = true;
            dvgSerach.DataSource = null;
            dvgSerach.DataSource = categories;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            DisAble();
            txtID.Text = txtName.Text = Search.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


