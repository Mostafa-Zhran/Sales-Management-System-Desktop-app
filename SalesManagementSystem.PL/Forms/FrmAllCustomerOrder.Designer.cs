namespace SalesManagementSystem.PL.Forms
{
    partial class FrmAllCustomerOrder
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
            label4 = new Label();
            btnSearch = new Button();
            btnSearchorder = new TextBox();
            dvgSerach = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSerach).BeginInit();
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
            panel1.Size = new Size(1004, 78);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 21);
            button1.Name = "button1";
            button1.Size = new Size(81, 38);
            button1.TabIndex = 14;
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
            label1.Location = new Point(420, 19);
            label1.Name = "label1";
            label1.Size = new Size(192, 45);
            label1.TabIndex = 0;
            label1.Text = "شاشه طلبات الزبائن";
            label1.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 609);
            panel2.Name = "panel2";
            panel2.Size = new Size(1004, 86);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(384, 52);
            label4.Name = "label4";
            label4.Size = new Size(251, 25);
            label4.TabIndex = 15;
            label4.Text = "All rights reserved @ Mostafa Zahran";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.SpringGreen;
            btnSearch.Location = new Point(663, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 40);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // btnSearchorder
            // 
            btnSearchorder.Anchor = AnchorStyles.Top;
            btnSearchorder.Location = new Point(154, 108);
            btnSearchorder.Name = "btnSearchorder";
            btnSearchorder.Size = new Size(488, 36);
            btnSearchorder.TabIndex = 12;
            // 
            // dvgSerach
            // 
            dvgSerach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgSerach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgSerach.BackgroundColor = Color.LightGray;
            dvgSerach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSerach.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column7, Column8, Column9, Column10, Column5, Column4 });
            dvgSerach.Location = new Point(12, 168);
            dvgSerach.Name = "dvgSerach";
            dvgSerach.RowHeadersWidth = 51;
            dvgSerach.Size = new Size(980, 435);
            dvgSerach.TabIndex = 13;
            dvgSerach.CellContentClick += dvgSerach_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "CustomerID";
            Column1.HeaderText = "رقم الزبون";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "CustomerName";
            Column2.HeaderText = "اسم الزبون";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SaleOrderID";
            Column3.HeaderText = "رقم الطلب";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "ProductID";
            Column6.HeaderText = "رقم المنتج";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ProductName";
            Column7.HeaderText = "اسم المنتج";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "ProductQuantity";
            Column8.HeaderText = "الكميه";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.DataPropertyName = "ProductPrice";
            Column9.HeaderText = "سعر القطعه";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.DataPropertyName = "ProductTotalPrice";
            Column10.HeaderText = "سعر المنتج ";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "OrderTotalPrice";
            Column5.HeaderText = "اجمالي السعر";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "OrderDate";
            Column4.HeaderText = "تاريخ الطلب";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // FrmAllCustomerOrder
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1004, 695);
            Controls.Add(dvgSerach);
            Controls.Add(btnSearchorder);
            Controls.Add(btnSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmAllCustomerOrder";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "شاشه الطلبات السابقه";
            Load += FrmAllCustomerOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgSerach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnSearch;
        private TextBox btnSearchorder;
        private DataGridView dvgSerach;
        private Button button1;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}