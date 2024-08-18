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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            splitContainer1 = new SplitContainer();
            NamaBarang = new DataGridViewTextBoxColumn();
            Kuantitas = new DataGridViewTextBoxColumn();
            HargaSatuan = new DataGridViewTextBoxColumn();
            Totalharga = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(2, -11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(195, 498);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(12, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 147);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 2;
            label2.Text = "total harga";
            // 
            // button1
            // 
            button1.Location = new Point(28, 373);
            button1.Name = "button1";
            button1.Size = new Size(116, 54);
            button1.TabIndex = 0;
            button1.Text = "Beli";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NamaBarang, Kuantitas, HargaSatuan, Totalharga });
            dataGridView1.Location = new Point(2, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(543, 401);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.CadetBlue;
            splitContainer1.Location = new Point(-2, -1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.CadetBlue;
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(comboBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(746, 521);
            splitContainer1.SplitterDistance = 545;
            splitContainer1.TabIndex = 2;
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
            // Totalharga
            // 
            Totalharga.HeaderText = "Total";
            Totalharga.MinimumWidth = 6;
            Totalharga.Name = "Totalharga";
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 479);
            Controls.Add(splitContainer1);
            Name = "Transaction";
            Text = "Transaction";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Button button1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn NamaBarang;
        private DataGridViewTextBoxColumn Kuantitas;
        private DataGridViewTextBoxColumn HargaSatuan;
        private DataGridViewTextBoxColumn Totalharga;
    }
}