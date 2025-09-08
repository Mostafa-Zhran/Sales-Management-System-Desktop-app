namespace SalesManagementSystem.PL.Forms
{
    partial class FrmSalesOrder
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
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            nudTotalPrice = new NumericUpDown();
            label8 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dvgSerach = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            nudSaleQuantity = new NumericUpDown();
            cmbProduct = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            cmbName = new ComboBox();
            dtDate = new DateTimePicker();
            label4 = new Label();
            label9 = new Label();
            cmbPhone = new ComboBox();
            txtID = new TextBox();
            label5 = new Label();
            cmbStock = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgSerach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSaleQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1010, 78);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 20);
            button1.Name = "button1";
            button1.Size = new Size(81, 38);
            button1.TabIndex = 22;
            button1.Text = "رجوع";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(412, 20);
            label1.Name = "label1";
            label1.Size = new Size(152, 45);
            label1.TabIndex = 0;
            label1.Text = "شاشه المبيعات";
            label1.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(nudTotalPrice);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 647);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 103);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Dubai", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(193, 37);
            label6.Name = "label6";
            label6.Size = new Size(114, 30);
            label6.TabIndex = 27;
            label6.Text = "اجمالي الفاتوره:";
            // 
            // nudTotalPrice
            // 
            nudTotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            nudTotalPrice.Location = new Point(22, 31);
            nudTotalPrice.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            nudTotalPrice.Name = "nudTotalPrice";
            nudTotalPrice.Size = new Size(156, 36);
            nudTotalPrice.TabIndex = 25;
            nudTotalPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(393, 69);
            label8.Name = "label8";
            label8.Size = new Size(251, 25);
            label8.TabIndex = 1;
            label8.Text = "All rights reserved @ Mostafa Zahran";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(89, 29);
            label2.TabIndex = 4;
            label2.Text = "رقم الفاتوره:";
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.MediumAquamarine;
            btnSave.Location = new Point(866, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(132, 36);
            btnSave.TabIndex = 7;
            btnSave.Text = "حفظ الفاتوره:";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(729, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 41);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.SpringGreen;
            btnAdd.Location = new Point(634, 260);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 40);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "اضافه";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // dvgSerach
            // 
            dvgSerach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgSerach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgSerach.BackgroundColor = Color.LightGray;
            dvgSerach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSerach.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column4, Column3 });
            dvgSerach.Location = new Point(12, 327);
            dvgSerach.Name = "dvgSerach";
            dvgSerach.RowHeadersWidth = 51;
            dvgSerach.Size = new Size(986, 314);
            dvgSerach.TabIndex = 13;
            dvgSerach.CellContentClick += dvgSerach_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ProductID";
            Column1.HeaderText = "رقم الصنف";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ProductName";
            Column2.HeaderText = "اسم الصنف";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ProductQuantity";
            Column5.HeaderText = "الكميه";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ProductPrice";
            Column4.HeaderText = "سعر البيع";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ProductTotalPrice";
            Column3.HeaderText = "الاجمالي";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // nudSaleQuantity
            // 
            nudSaleQuantity.Anchor = AnchorStyles.Top;
            nudSaleQuantity.Location = new Point(512, 264);
            nudSaleQuantity.Name = "nudSaleQuantity";
            nudSaleQuantity.Size = new Size(105, 36);
            nudSaleQuantity.TabIndex = 15;
            nudSaleQuantity.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbProduct
            // 
            cmbProduct.Anchor = AnchorStyles.Top;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(234, 264);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(259, 37);
            cmbProduct.TabIndex = 20;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(662, 90);
            label7.Name = "label7";
            label7.Size = new Size(59, 29);
            label7.TabIndex = 21;
            label7.Text = "التاريخ:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(221, 88);
            label3.Name = "label3";
            label3.Size = new Size(95, 29);
            label3.TabIndex = 23;
            label3.Text = "اسم العميل:";
            // 
            // cmbName
            // 
            cmbName.Anchor = AnchorStyles.Top;
            cmbName.FormattingEnabled = true;
            cmbName.Location = new Point(221, 129);
            cmbName.Name = "cmbName";
            cmbName.Size = new Size(207, 37);
            cmbName.TabIndex = 22;
            // 
            // dtDate
            // 
            dtDate.Anchor = AnchorStyles.Top;
            dtDate.Format = DateTimePickerFormat.Short;
            dtDate.Location = new Point(662, 132);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(181, 36);
            dtDate.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(234, 222);
            label4.Name = "label4";
            label4.Size = new Size(95, 29);
            label4.TabIndex = 25;
            label4.Text = "اسم الصنف:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(447, 88);
            label9.Name = "label9";
            label9.Size = new Size(90, 29);
            label9.TabIndex = 28;
            label9.Text = "رقم العميل:";
            // 
            // cmbPhone
            // 
            cmbPhone.Anchor = AnchorStyles.Top;
            cmbPhone.FormattingEnabled = true;
            cmbPhone.Location = new Point(447, 129);
            cmbPhone.Name = "cmbPhone";
            cmbPhone.Size = new Size(185, 37);
            cmbPhone.TabIndex = 27;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.Location = new Point(12, 129);
            txtID.Name = "txtID";
            txtID.Size = new Size(188, 36);
            txtID.TabIndex = 2;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(12, 174);
            label5.Name = "label5";
            label5.Size = new Size(82, 29);
            label5.TabIndex = 30;
            label5.Text = "رقم الخزنه:";
            // 
            // cmbStock
            // 
            cmbStock.Anchor = AnchorStyles.Top;
            cmbStock.FormattingEnabled = true;
            cmbStock.Location = new Point(12, 214);
            cmbStock.Name = "cmbStock";
            cmbStock.Size = new Size(188, 37);
            cmbStock.TabIndex = 31;
            // 
            // FrmSalesOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1010, 750);
            Controls.Add(cmbStock);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(cmbPhone);
            Controls.Add(label4);
            Controls.Add(dtDate);
            Controls.Add(label3);
            Controls.Add(cmbName);
            Controls.Add(label7);
            Controls.Add(cmbProduct);
            Controls.Add(nudSaleQuantity);
            Controls.Add(dvgSerach);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmSalesOrder";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "شاشه المبيعات";
            Load += FrmProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgSerach).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSaleQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button btnSave;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dvgSerach;
        private NumericUpDown nudSaleQuantity;
        private ComboBox cmbProduct;
        private Label label7;
        private Button button1;
        private Label label8;
        private Label label3;
        private ComboBox cmbName;
        private DateTimePicker dtDate;
        private NumericUpDown nudTotalPrice;
        private Label label4;
        private Label label6;
        private Label label9;
        private ComboBox cmbPhone;
        private TextBox txtID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private Label label5;
        private ComboBox cmbStock;
    }
}