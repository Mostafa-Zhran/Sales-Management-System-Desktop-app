namespace SalesManagementSystem.PL.Forms
{
    partial class FrmStockDetails
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
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button1 = new Button();
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
            panel1.Size = new Size(881, 78);
            panel1.TabIndex = 22;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(319, 12);
            label1.Name = "label1";
            label1.Size = new Size(276, 51);
            label1.TabIndex = 15;
            label1.Text = "علمليات البيع و الشراء";
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
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 496);
            panel2.Name = "panel2";
            panel2.Size = new Size(881, 86);
            panel2.TabIndex = 23;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(319, 52);
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
            dvgData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dvgData.Location = new Point(12, 193);
            dvgData.Name = "dvgData";
            dvgData.RowHeadersWidth = 51;
            dvgData.Size = new Size(857, 297);
            dvgData.TabIndex = 26;
            dvgData.CellContentClick += dvgData_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ID";
            Column1.HeaderText = "رقم العمليه";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "StockID";
            Column2.HeaderText = "رقم المخزن";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SaleOedrId";
            Column3.HeaderText = "رقم الاوردر";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Money";
            Column4.HeaderText = "المبلغ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "StockType";
            Column5.HeaderText = "نوع العمليه";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DateTime";
            Column6.HeaderText = "الوقت";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Dubai", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(152, 99);
            button1.Name = "button1";
            button1.Size = new Size(570, 47);
            button1.TabIndex = 24;
            button1.Text = "Operations";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmStockDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 582);
            Controls.Add(dvgData);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmStockDetails";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "FrmStockDetails";
            Load += FrmStockDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Panel panel2;
        private Label label4;
        private DataGridView dvgData;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}