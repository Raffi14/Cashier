namespace POST_System
{
    partial class AdminHome
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
            components = new System.ComponentModel.Container();
            productBindingSource = new BindingSource(components);
            panel1 = new Panel();
            Username = new Label();
            RegistrationNav = new Button();
            TransactionNav = new Button();
            ProductNav = new Button();
            LogOutButton = new Button();
            ProductList = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AddProduct = new Button();
            productBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductList).BeginInit();
            productBox.SuspendLayout();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DB_Create.Product);
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(Username);
            panel1.Controls.Add(RegistrationNav);
            panel1.Controls.Add(TransactionNav);
            panel1.Controls.Add(ProductNav);
            panel1.Controls.Add(LogOutButton);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 515);
            panel1.TabIndex = 0;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(28, 46);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // RegistrationNav
            // 
            RegistrationNav.BackColor = Color.Gray;
            RegistrationNav.Location = new Point(11, 234);
            RegistrationNav.Name = "RegistrationNav";
            RegistrationNav.Size = new Size(107, 58);
            RegistrationNav.TabIndex = 3;
            RegistrationNav.Text = "Registration";
            RegistrationNav.UseVisualStyleBackColor = false;
            // 
            // TransactionNav
            // 
            TransactionNav.BackColor = Color.Gray;
            TransactionNav.Location = new Point(11, 161);
            TransactionNav.Name = "TransactionNav";
            TransactionNav.Size = new Size(107, 58);
            TransactionNav.TabIndex = 2;
            TransactionNav.Text = "Transaction";
            TransactionNav.UseVisualStyleBackColor = false;
            TransactionNav.Click += button3_Click;
            // 
            // ProductNav
            // 
            ProductNav.BackColor = Color.Gray;
            ProductNav.Location = new Point(11, 87);
            ProductNav.Name = "ProductNav";
            ProductNav.Size = new Size(107, 58);
            ProductNav.TabIndex = 1;
            ProductNav.Text = "Product";
            ProductNav.UseVisualStyleBackColor = false;
            ProductNav.Click += button2_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.Gray;
            LogOutButton.Location = new Point(28, 462);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(72, 28);
            LogOutButton.TabIndex = 0;
            LogOutButton.Text = "Log-Out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += button1_Click;
            // 
            // ProductList
            // 
            ProductList.AllowUserToAddRows = false;
            ProductList.AllowUserToDeleteRows = false;
            ProductList.AutoGenerateColumns = false;
            ProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductList.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            ProductList.DataSource = productBindingSource;
            ProductList.ImeMode = ImeMode.NoControl;
            ProductList.Location = new Point(9, 87);
            ProductList.Name = "ProductList";
            ProductList.ReadOnly = true;
            ProductList.RowHeadersVisible = false;
            ProductList.RowHeadersWidth = 51;
            ProductList.ScrollBars = ScrollBars.Vertical;
            ProductList.Size = new Size(709, 428);
            ProductList.TabIndex = 1;
            ProductList.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 9.490454F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 2;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 55.9936829F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 55.9936829F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.FillWeight = 55.9936829F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.LightGray;
            AddProduct.Location = new Point(9, 46);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(137, 35);
            AddProduct.TabIndex = 4;
            AddProduct.Text = "Add Product";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // productBox
            // 
            productBox.Controls.Add(AddProduct);
            productBox.Controls.Add(ProductList);
            productBox.Location = new Point(125, 0);
            productBox.Name = "productBox";
            productBox.Size = new Size(728, 522);
            productBox.TabIndex = 2;
            productBox.TabStop = false;
            productBox.Text = "Product";
            productBox.UseCompatibleTextRendering = true;
            productBox.Visible = false;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(855, 514);
            Controls.Add(productBox);
            Controls.Add(panel1);
            MaximumSize = new Size(873, 561);
            MinimizeBox = false;
            MinimumSize = new Size(873, 561);
            Name = "AdminHome";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += AdminHome_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductList).EndInit();
            productBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource productBindingSource;
        private Panel panel1;
        private Button LogOutButton;
        private Button RegistrationNav;
        private Button TransactionNav;
        private Button ProductNav;
        private DataGridView ProductList;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private Label Username;
        private Button AddProduct;
        private GroupBox productBox;
    }
}