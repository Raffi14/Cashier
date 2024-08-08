namespace POST_System.AdminPages
{
    partial class AddProductForm
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
            InpName = new TextBox();
            InpPrice = new TextBox();
            InpStock = new TextBox();
            ProductTitle = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // InpName
            // 
            InpName.Location = new Point(55, 122);
            InpName.Name = "InpName";
            InpName.PlaceholderText = "name";
            InpName.Size = new Size(309, 27);
            InpName.TabIndex = 0;
            // 
            // InpPrice
            // 
            InpPrice.Location = new Point(55, 189);
            InpPrice.Name = "InpPrice";
            InpPrice.PlaceholderText = "stock";
            InpPrice.Size = new Size(309, 27);
            InpPrice.TabIndex = 1;
            // 
            // InpStock
            // 
            InpStock.Location = new Point(55, 250);
            InpStock.Name = "InpStock";
            InpStock.PlaceholderText = "price";
            InpStock.Size = new Size(309, 27);
            InpStock.TabIndex = 2;
            // 
            // ProductTitle
            // 
            ProductTitle.AutoSize = true;
            ProductTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductTitle.Location = new Point(64, 23);
            ProductTitle.Name = "ProductTitle";
            ProductTitle.Size = new Size(286, 60);
            ProductTitle.TabIndex = 4;
            ProductTitle.Text = "Add Product";
            // 
            // button1
            // 
            button1.Location = new Point(147, 308);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 5;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 385);
            Controls.Add(button1);
            Controls.Add(ProductTitle);
            Controls.Add(InpStock);
            Controls.Add(InpPrice);
            Controls.Add(InpName);
            MinimumSize = new Size(398, 362);
            Name = "AddProductForm";
            Text = "Adding Product";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InpName;
        private TextBox InpPrice;
        private TextBox InpStock;
        private Label ProductTitle;
        private Button button1;
    }
}