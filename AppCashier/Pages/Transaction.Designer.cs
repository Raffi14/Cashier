namespace POST_System.Pages
{
    partial class Transaction
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
            comboBox1 = new ComboBox();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            NamaBarang = new DataGridViewTextBoxColumn();
            Kuantitas = new DataGridViewTextBoxColumn();
            HargaSatuan = new DataGridViewTextBoxColumn();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(-2, -2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(746, 482);
            splitContainer1.SplitterDistance = 545;
            splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaBarang, Kuantitas, HargaSatuan });
            dataGridView1.Location = new Point(2, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(538, 383);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // NamaBarang
            // 
            NamaBarang.DataPropertyName = "Nama";
            NamaBarang.HeaderText = "Nama Barang";
            NamaBarang.MinimumWidth = 6;
            NamaBarang.Name = "NamaBarang";
            NamaBarang.ReadOnly = true;
            // 
            // Kuantitas
            // 
            Kuantitas.HeaderText = "Kuantitas";
            Kuantitas.MinimumWidth = 6;
            Kuantitas.Name = "Kuantitas";
            // 
            // HargaSatuan
            // 
            HargaSatuan.HeaderText = "Harga";
            HargaSatuan.MinimumWidth = 6;
            HargaSatuan.Name = "HargaSatuan";
            HargaSatuan.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 113);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(40, 379);
            button1.Name = "button1";
            button1.Size = new Size(116, 54);
            button1.TabIndex = 0;
            button1.Text = "Beli";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 479);
            Controls.Add(splitContainer1);
            Name = "Transaction";
            Text = "Transaction";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Button button1;
        private DataGridViewTextBoxColumn NamaBarang;
        private DataGridViewTextBoxColumn Kuantitas;
        private DataGridViewTextBoxColumn HargaSatuan;
        private Label label1;
    }
}