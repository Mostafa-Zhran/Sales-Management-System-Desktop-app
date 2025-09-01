namespace SalesManagementSystem.PL.Forms
{
    partial class MainFrom
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
            btnProduct = new Button();
            btnCategory = new Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.DarkSlateGray;
            btnProduct.FlatStyle = FlatStyle.Popup;
            btnProduct.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(211, 203);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(134, 52);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "الاصناف";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCategory
            // 
            btnCategory.BackColor = Color.DarkSlateGray;
            btnCategory.FlatStyle = FlatStyle.Popup;
            btnCategory.Font = new Font("Dubai", 10.2F, FontStyle.Bold);
            btnCategory.ForeColor = Color.White;
            btnCategory.Location = new Point(411, 203);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(134, 52);
            btnCategory.TabIndex = 1;
            btnCategory.Text = "المجموعات";
            btnCategory.UseVisualStyleBackColor = false;
            btnCategory.Click += btnCategory_Click;
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCategory);
            Controls.Add(btnProduct);
            Name = "MainFrom";
            Text = "MainFrom";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduct;
        private Button btnCategory;
    }
}