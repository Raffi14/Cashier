namespace POST_System.AdminPages
{
    partial class ProductPage
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
            AddProduct = new Button();
            ProductList = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            button1 = new Button();
            label1 = new Label();
            Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProductList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.LightGray;
            AddProduct.Location = new Point(0, 9);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(137, 35);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Add Product";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // ProductList
            // 
            ProductList.AllowUserToAddRows = false;
            ProductList.AllowUserToDeleteRows = false;
            ProductList.AllowUserToResizeColumns = false;
            ProductList.AllowUserToResizeRows = false;
            ProductList.AutoGenerateColumns = false;
            ProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductList.BackgroundColor = Color.Silver;
            ProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductList.Columns.AddRange(new DataGridViewColumn[] { Id, nameDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            ProductList.DataSource = productBindingSource;
            ProductList.ImeMode = ImeMode.NoControl;
            ProductList.Location = new Point(0, 50);
            ProductList.Name = "ProductList";
            ProductList.ReadOnly = true;
            ProductList.RowHeadersVisible = false;
            ProductList.RowHeadersWidth = 51;
            ProductList.ScrollBars = ScrollBars.Vertical;
            ProductList.Size = new Size(744, 452);
            ProductList.TabIndex = 5;
            ProductList.CellClick += ProductList_Click;
            ProductList.CellDoubleClick += ProductList_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 23.5294113F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DB_Create.Product);
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(143, 9);
            button1.Name = "button1";
            button1.Size = new Size(137, 35);
            button1.TabIndex = 7;
            button1.Text = "Remove Product";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 34);
            label1.Name = "label1";
            label1.Size = new Size(210, 13);
            label1.TabIndex = 8;
            label1.Text = "*double click to edit product";
            // 
            // Search
            // 
            Search.Location = new Point(513, 17);
            Search.Name = "Search";
            Search.PlaceholderText = "Search";
            Search.Size = new Size(210, 27);
            Search.TabIndex = 9;
            Search.TextChanged += textBox1_TextChanged;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(744, 479);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(AddProduct);
            Controls.Add(ProductList);
            Name = "ProductPage";
            Text = "Product";
            ((System.ComponentModel.ISupportInitialize)ProductList).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddProduct;
        private DataGridView ProductList;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private Button button1;
        private Label label1;
        private TextBox Search;
    }
}