namespace POST_System.Pages
{
    partial class Riwayat
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            produkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kuantitasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            saleDetailBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleDetailBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, Column1, produkDataGridViewTextBoxColumn, kuantitasDataGridViewTextBoxColumn, Column3, Column2 });
            dataGridView1.DataSource = saleDetailBindingSource;
            dataGridView1.Location = new Point(3, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(738, 389);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 29.4117641F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Tanggal";
            Column1.HeaderText = "Tanggal";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // produkDataGridViewTextBoxColumn
            // 
            produkDataGridViewTextBoxColumn.DataPropertyName = "Produk";
            produkDataGridViewTextBoxColumn.FillWeight = 117.647064F;
            produkDataGridViewTextBoxColumn.HeaderText = "Produk";
            produkDataGridViewTextBoxColumn.MinimumWidth = 6;
            produkDataGridViewTextBoxColumn.Name = "produkDataGridViewTextBoxColumn";
            produkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kuantitasDataGridViewTextBoxColumn
            // 
            kuantitasDataGridViewTextBoxColumn.DataPropertyName = "Kuantitas";
            kuantitasDataGridViewTextBoxColumn.FillWeight = 117.647064F;
            kuantitasDataGridViewTextBoxColumn.HeaderText = "Kuantitas";
            kuantitasDataGridViewTextBoxColumn.MinimumWidth = 6;
            kuantitasDataGridViewTextBoxColumn.Name = "kuantitasDataGridViewTextBoxColumn";
            kuantitasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Total";
            Column3.HeaderText = "Total";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "User";
            Column2.HeaderText = "User";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // saleDetailBindingSource
            // 
            saleDetailBindingSource.DataSource = typeof(DB_Create.SaleDetail);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ascending", "Descending" });
            comboBox1.Location = new Point(3, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Urutkan";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(459, 42);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cari nama barang";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" });
            comboBox2.Location = new Point(191, 42);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 28);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Pilih bulan";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 479);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Riwayat";
            Text = "Riwayat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleDetailBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource saleDetailBindingSource;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn produkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kuantitasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
    }
}