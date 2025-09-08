namespace SalesManagementSystem.PL.Forms
{
    partial class FrmCategory
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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
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
            label1.Location = new Point(417, 14);
            label1.Name = "label1";
            label1.Size = new Size(172, 45);
            label1.TabIndex = 0;
            label1.Text = "شاشه المجموعات";
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
            label4.Location = new Point(366, 52);
            label4.Name = "label4";
            label4.Size = new Size(251, 25);
            label4.TabIndex = 15;
            label4.Text = "All rights reserved @ Mostafa Zahran";
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.Location = new Point(100, 131);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(247, 36);
            txtID.TabIndex = 2;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top;
            txtName.Location = new Point(544, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 36);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(100, 90);
            label2.Name = "label2";
            label2.Size = new Size(106, 29);
            label2.TabIndex = 4;
            label2.Text = "رقم المجموعه:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(547, 90);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 5;
            label3.Text = "اسم المجموعه:";
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Top;
            btnNew.BackColor = Color.MediumAquamarine;
            btnNew.Location = new Point(53, 204);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(132, 43);
            btnNew.TabIndex = 6;
            btnNew.Text = "جديد";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.MediumAquamarine;
            btnAdd.Location = new Point(243, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 43);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "اضافه";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top;
            btnUpdate.BackColor = Color.MediumAquamarine;
            btnUpdate.Location = new Point(422, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 43);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "تعديل";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += brnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(600, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 43);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Anchor = AnchorStyles.Top;
            btnDeleteAll.BackColor = Color.Red;
            btnDeleteAll.Location = new Point(776, 204);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(132, 43);
            btnDeleteAll.TabIndex = 10;
            btnDeleteAll.Text = "حذف الكل";
            btnDeleteAll.UseVisualStyleBackColor = false;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.BackColor = Color.SpringGreen;
            btnSearch.Location = new Point(575, 269);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 40);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // Search
            // 
            Search.Anchor = AnchorStyles.Top;
            Search.Location = new Point(256, 269);
            Search.Name = "Search";
            Search.Size = new Size(298, 36);
            Search.TabIndex = 12;
            // 
            // dvgSerach
            // 
            dvgSerach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgSerach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgSerach.BackgroundColor = Color.LightGray;
            dvgSerach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgSerach.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dvgSerach.Location = new Point(12, 327);
            dvgSerach.Name = "dvgSerach";
            dvgSerach.RowHeadersWidth = 51;
            dvgSerach.Size = new Size(980, 276);
            dvgSerach.TabIndex = 13;
            dvgSerach.CellMouseClick += dvgSerach_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم المجموعه";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "اسم المجموعه";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(9F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1004, 695);
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
            Name = "FrmCategory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "شاشه المجموعات";
            Load += frmCategory_Load_1;
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button1;
        private Label label4;
    }
}