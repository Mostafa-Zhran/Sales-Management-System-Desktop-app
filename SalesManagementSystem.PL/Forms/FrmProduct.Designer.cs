namespace SalesManagementSystem.PL.Forms
{
    partial class  FrmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtID = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnNew = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteAll = new Button();
            btnSearch = new Button();
            Search = new TextBox();
            dvgSerach = new DataGridView();
            nudSalePrice = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            nudBuyPrice = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbCategory = new ComboBox();
            label7 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSerach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 78);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 45);
            label1.TabIndex = 0;
            label1.Text = "شاشه الاصناف";
            label1.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 664);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 86);
            panel2.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(52, 129);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(231, 36);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(351, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(223, 36);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 88);
            label2.Name = "label2";
            label2.Size = new Size(90, 29);
            label2.TabIndex = 4;
            label2.Text = "رقم الصنف:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 88);
            label3.Name = "label3";
            label3.Size = new Size(95, 29);
            label3.TabIndex = 5;
            label3.Text = "اسم الصنف:";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.MediumAquamarine;
            btnNew.Location = new Point(11, 302);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(132, 43);
            btnNew.TabIndex = 6;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumAquamarine;
            btnAdd.Location = new Point(210, 302);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 43);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "اضافه";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumAquamarine;
            btnUpdate.Location = new Point(426, 302);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += brnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(626, 302);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.BackColor = Color.Red;
            btnDeleteAll.Location = new Point(834, 302);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(132, 43);
            btnDeleteAll.TabIndex = 10;
            btnDeleteAll.Text = "حذف الكل";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SpringGreen;
            btnSearch.Location = new Point(543, 367);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 40);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // Search
            // 
            Search.Location = new Point(224, 367);
            Search.Name = "Search";
            Search.Size = new Size(298, 36);
            Search.TabIndex = 12;
            // 
            // dvgSerach
            // 
            dvgSerach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgSerach.BackgroundColor = Color.LightGray;
            dvgSerach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSerach.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dvgSerach.Location = new Point(12, 423);
            dvgSerach.Name = "dvgSerach";
            dvgSerach.RowHeadersWidth = 51;
            dvgSerach.Size = new Size(986, 235);
            dvgSerach.TabIndex = 13;
            dvgSerach.CellContentClick += dvgSerach_CellContentClick;
            dvgSerach.CellMouseClick += dvgSerach_CellMouseClick;
            // 
            // nudSalePrice
            // 
            nudSalePrice.Location = new Point(52, 214);
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(231, 36);
            nudSalePrice.TabIndex = 14;
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(703, 214);
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(207, 36);
            nudQuantity.TabIndex = 15;
            // 
            // nudBuyPrice
            // 
            nudBuyPrice.Location = new Point(351, 214);
            nudBuyPrice.Name = "nudBuyPrice";
            nudBuyPrice.Size = new Size(223, 36);
            nudBuyPrice.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 168);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 17;
            label4.Text = "سعر الشراء:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(700, 168);
            label5.Name = "label5";
            label5.Size = new Size(58, 29);
            label5.TabIndex = 18;
            label5.Text = "الكميه:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(351, 168);
            label6.Name = "label6";
            label6.Size = new Size(82, 29);
            label6.TabIndex = 19;
            label6.Text = "سعر البيع:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(703, 128);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(207, 37);
            cbCategory.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(703, 88);
            label7.Name = "label7";
            label7.Size = new Size(79, 29);
            label7.TabIndex = 21;
            label7.Text = "المجموعه:";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم الصنف";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BuyPrice";
            Column3.HeaderText = "سعر الشراء";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "SalePrice";
            Column4.HeaderText = "سعر البيع";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Quantity";
            Column5.HeaderText = "الكميه";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "CategoryID";
            Column6.HeaderText = "اسم المجموعه";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1010, 750);
            Controls.Add(label7);
            Controls.Add(cbCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nudBuyPrice);
            Controls.Add(nudQuantity);
            Controls.Add(nudSalePrice);
            Controls.Add(dvgSerach);
            Controls.Add(Search);
            Controls.Add(btnSearch);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnNew);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmProduct";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "شاشه الاصناف";
            Load += FrmProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSerach).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtID;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Button btnNew;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnSearch;
        private TextBox Search;
        private DataGridView dvgSerach;
        private NumericUpDown nudSalePrice;
        private NumericUpDown nudQuantity;
        private NumericUpDown nudBuyPrice;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbCategory;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}