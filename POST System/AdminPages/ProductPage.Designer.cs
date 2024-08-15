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
            namaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hargaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            AddProduct.Location = new Point(0, 12);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(137, 35);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Tambah Produk";
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
            ProductList.Columns.AddRange(new DataGridViewColumn[] { Id, namaDataGridViewTextBoxColumn, hargaDataGridViewTextBoxColumn, stokDataGridViewTextBoxColumn });
            ProductList.DataSource = productBindingSource;
            ProductList.ImeMode = ImeMode.NoControl;
            ProductList.Location = new Point(0, 72);
            ProductList.Name = "ProductList";
            ProductList.ReadOnly = true;
            ProductList.RowHeadersVisible = false;
            ProductList.RowHeadersWidth = 51;
            ProductList.ScrollBars = ScrollBars.Vertical;
            ProductList.Size = new Size(744, 430);
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
            // namaDataGridViewTextBoxColumn
            // 
            namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            namaDataGridViewTextBoxColumn.FillWeight = 125.490181F;
            namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            hargaDataGridViewTextBoxColumn.FillWeight = 125.490181F;
            hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            hargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            stokDataGridViewTextBoxColumn.FillWeight = 125.490181F;
            stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            stokDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DB_Create.Product);
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(143, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 35);
            button1.TabIndex = 7;
            button1.Text = "Hapus Produk";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 56);
            label1.Name = "label1";
            label1.Size = new Size(592, 15);
            label1.TabIndex = 8;
            label1.Text = "*click untuk memilih produk dan double click untuk update produk ";
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
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private Button button1;
        private Label label1;
        private TextBox Search;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
    }
}