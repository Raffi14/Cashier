namespace POST_System.AdminPages.Components
{
    partial class UpProduct
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
            button1 = new Button();
            ProductTitle = new Label();
            EdPrice = new TextBox();
            EdStock = new TextBox();
            EdName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(151, 322);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 10;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductTitle
            // 
            ProductTitle.AutoSize = true;
            ProductTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductTitle.Location = new Point(77, 38);
            ProductTitle.Name = "ProductTitle";
            ProductTitle.Size = new Size(268, 60);
            ProductTitle.TabIndex = 9;
            ProductTitle.Text = "Edit Produk";
            ProductTitle.Click += ProductTitle_Click;
            // 
            // EdPrice
            // 
            EdPrice.Location = new Point(59, 264);
            EdPrice.Name = "EdPrice";
            EdPrice.PlaceholderText = "price";
            EdPrice.Size = new Size(309, 27);
            EdPrice.TabIndex = 8;
            // 
            // EdStock
            // 
            EdStock.Location = new Point(59, 203);
            EdStock.Name = "EdStock";
            EdStock.PlaceholderText = "stock";
            EdStock.Size = new Size(309, 27);
            EdStock.TabIndex = 7;
            // 
            // EdName
            // 
            EdName.Location = new Point(59, 136);
            EdName.Name = "EdName";
            EdName.PlaceholderText = "name";
            EdName.Size = new Size(309, 27);
            EdName.TabIndex = 6;
            // 
            // UpProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 385);
            Controls.Add(button1);
            Controls.Add(ProductTitle);
            Controls.Add(EdPrice);
            Controls.Add(EdStock);
            Controls.Add(EdName);
            Name = "UpProduct";
            Text = "Form1";
            Load += UpProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label ProductTitle;
        private TextBox EdPrice;
        private TextBox EdStock;
        private TextBox EdName;
    }
}