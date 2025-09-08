namespace SalesManagementSystem.PL.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            btnCategory = new Button();
            button2 = new Button();
            button3 = new Button();
            btnProduct = new Button();
            button4 = new Button();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 607);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 68);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Dubai", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(387, 43);
            label2.Name = "label2";
            label2.Size = new Size(251, 25);
            label2.TabIndex = 0;
            label2.Text = "All rights reserved @ Mostafa Zahran";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1046, 61);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Dubai", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(328, 45);
            label1.TabIndex = 6;
            label1.Text = "نظام اداره المنتجات و الاصناف";
            // 
            // btnCategory
            // 
            btnCategory.Anchor = AnchorStyles.Top;
            btnCategory.BackColor = Color.DarkSlateGray;
            btnCategory.FlatStyle = FlatStyle.Popup;
            btnCategory.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            btnCategory.ForeColor = Color.White;
            btnCategory.Location = new Point(94, 196);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(392, 67);
            btnCategory.TabIndex = 10;
            btnCategory.Text = "المجموعات";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.DarkSlateGray;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(566, 299);
            button2.Name = "button2";
            button2.Size = new Size(392, 67);
            button2.TabIndex = 11;
            button2.Text = "الزبائن";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.ForestGreen;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            button3.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(94, 78);
            button3.Name = "button3";
            button3.Size = new Size(864, 82);
            button3.TabIndex = 12;
            button3.Text = "المخزن";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnProduct
            // 
            btnProduct.Anchor = AnchorStyles.Top;
            btnProduct.BackColor = Color.DarkSlateGray;
            btnProduct.FlatStyle = FlatStyle.Popup;
            btnProduct.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(566, 196);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(392, 67);
            btnProduct.TabIndex = 13;
            btnProduct.Text = "الاصناف";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.BackColor = Color.DarkSlateGray;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(94, 299);
            button4.Name = "button4";
            button4.Size = new Size(392, 67);
            button4.TabIndex = 14;
            button4.Text = "المبيعات";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.DarkSlateGray;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(94, 402);
            button1.Name = "button1";
            button1.Size = new Size(392, 67);
            button1.TabIndex = 15;
            button1.Text = "الطلبات";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom;
            button5.BackColor = Color.DarkSlateGray;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(566, 402);
            button5.Name = "button5";
            button5.Size = new Size(392, 67);
            button5.TabIndex = 17;
            button5.Text = "تفاصيل البيع و الشراء";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom;
            button6.BackColor = Color.Maroon;
            button6.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            button6.FlatAppearance.MouseOverBackColor = Color.Red;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(94, 505);
            button6.Name = "button6";
            button6.Size = new Size(864, 82);
            button6.TabIndex = 19;
            button6.Text = "خروج";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 675);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnProduct);
            Controls.Add(btnCategory);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "الشاشه الرئسية";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnCategory;
        private Button button2;
        private Button button3;
        private Button btnProduct;
        private Button button4;
        private Button button1;
        private Button button5;
        private Button button6;
    }
}