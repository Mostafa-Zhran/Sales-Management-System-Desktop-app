namespace SalesManagementSystem.PL.Forms
{
    partial class FrmStocks
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
            button2 = new Button();
            panel2 = new Panel();
            label4 = new Label();
            dvgData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            butAddStock = new Button();
            btnDeleteStock = new Button();
            txtID = new TextBox();
            txtMoney = new TextBox();
            txtlocation = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 78);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(503, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 57);
            label1.TabIndex = 15;
            label1.Text = "المخزن";
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 21);
            button2.Name = "button2";
            button2.Size = new Size(81, 38);
            button2.TabIndex = 14;
            button2.Text = "رجوع";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 572);
            panel2.Name = "panel2";
            panel2.Size = new Size(1048, 86);
            panel2.TabIndex = 22;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(405, 52);
            label4.Name = "label4";
            label4.Size = new Size(251, 25);
            label4.TabIndex = 15;
            label4.Text = "All rights reserved @ Mostafa Zahran";
            // 
            // dvgData
            // 
            dvgData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dvgData.Location = new Point(12, 299);
            dvgData.Name = "dvgData";
            dvgData.RowHeadersWidth = 51;
            dvgData.Size = new Size(1024, 267);
            dvgData.TabIndex = 23;
            dvgData.CellClick += dvgData_CellContentClick;
            dvgData.CellContentClick += dvgData_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم المخزن";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Location";
            Column2.HeaderText = "العنوان";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Money";
            Column3.HeaderText = "اجمالي المبلغ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // butAddStock
            // 
            butAddStock.Anchor = AnchorStyles.Top;
            butAddStock.BackColor = Color.DarkSlateGray;
            butAddStock.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            butAddStock.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            butAddStock.FlatStyle = FlatStyle.Flat;
            butAddStock.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butAddStock.ForeColor = Color.White;
            butAddStock.Location = new Point(145, 223);
            butAddStock.Name = "butAddStock";
            butAddStock.Size = new Size(355, 47);
            butAddStock.TabIndex = 26;
            butAddStock.Text = "Add Stock";
            butAddStock.UseVisualStyleBackColor = false;
            butAddStock.Click += butAddStock_Click;
            // 
            // btnDeleteStock
            // 
            btnDeleteStock.Anchor = AnchorStyles.Top;
            btnDeleteStock.BackColor = Color.DarkRed;
            btnDeleteStock.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnDeleteStock.FlatAppearance.MouseOverBackColor = Color.Red;
            btnDeleteStock.FlatStyle = FlatStyle.Flat;
            btnDeleteStock.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStock.ForeColor = Color.White;
            btnDeleteStock.Location = new Point(506, 223);
            btnDeleteStock.Name = "btnDeleteStock";
            btnDeleteStock.Size = new Size(362, 47);
            btnDeleteStock.TabIndex = 27;
            btnDeleteStock.Text = "Delete Stock";
            btnDeleteStock.UseVisualStyleBackColor = false;
            btnDeleteStock.Click += btnDeleteStock_Click;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top;
            txtID.Location = new Point(145, 155);
            txtID.Name = "txtID";
            txtID.Size = new Size(237, 27);
            txtID.TabIndex = 28;
            // 
            // txtMoney
            // 
            txtMoney.Anchor = AnchorStyles.Top;
            txtMoney.Location = new Point(630, 155);
            txtMoney.Name = "txtMoney";
            txtMoney.Size = new Size(238, 27);
            txtMoney.TabIndex = 29;
            // 
            // txtlocation
            // 
            txtlocation.Anchor = AnchorStyles.Top;
            txtlocation.Location = new Point(388, 155);
            txtlocation.Name = "txtlocation";
            txtlocation.Size = new Size(236, 27);
            txtlocation.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            label2.Location = new Point(145, 117);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 31;
            label2.Text = "رقم المخزن :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            label3.Location = new Point(630, 117);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 32;
            label3.Text = "اجمالي المبلغ:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            label5.Location = new Point(388, 117);
            label5.Name = "label5";
            label5.Size = new Size(68, 29);
            label5.TabIndex = 33;
            label5.Text = "العنوان :";
            // 
            // FrmStocks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 658);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtlocation);
            Controls.Add(txtMoney);
            Controls.Add(txtID);
            Controls.Add(btnDeleteStock);
            Controls.Add(butAddStock);
            Controls.Add(dvgData);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmStocks";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "المخزن";
            Load += FrmStocks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private Label label4;
        private DataGridView dvgData;
        private Label label1;
        private Button butAddStock;
        private Button btnDeleteStock;
        private TextBox txtID;
        private TextBox txtMoney;
        private TextBox txtlocation;
        private Label label2;
        private Label label3;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}