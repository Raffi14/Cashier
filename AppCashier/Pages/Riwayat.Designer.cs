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
            Id = new DataGridViewTextBoxColumn();
            tanggalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalHargaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saleBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.DarkGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, tanggalDataGridViewTextBoxColumn, totalHargaDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn });
            dataGridView1.DataSource = saleBindingSource;
            dataGridView1.Location = new Point(2, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(738, 389);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            // tanggalDataGridViewTextBoxColumn
            // 
            tanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal";
            tanggalDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            tanggalDataGridViewTextBoxColumn.MinimumWidth = 6;
            tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            totalHargaDataGridViewTextBoxColumn.DataPropertyName = "TotalHarga";
            totalHargaDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            totalHargaDataGridViewTextBoxColumn.HeaderText = "TotalHarga";
            totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            totalHargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.FillWeight = 125.4902F;
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.MinimumWidth = 6;
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saleBindingSource
            // 
            saleBindingSource.DataSource = typeof(DB_Create.Sale);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Terbaru", "Terlama" });
            comboBox1.Location = new Point(3, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Urutkan";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(459, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Cari nama user";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" });
            comboBox2.Location = new Point(191, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(165, 28);
            comboBox2.TabIndex = 3;
            comboBox2.Text = "Pilih bulan";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 69);
            label1.Name = "label1";
            label1.Size = new Size(313, 15);
            label1.TabIndex = 9;
            label1.Text = "*click untuk melihat detail produk";
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 479);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "Riwayat";
            Text = "Riwayat";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)saleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private BindingSource saleBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private Label label1;
    }
}