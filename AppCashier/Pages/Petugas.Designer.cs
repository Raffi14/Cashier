namespace POST_System.AdminPages
{
    partial class Petugas
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
            Search = new TextBox();
            label1 = new Label();
            button1 = new Button();
            AddProduct = new Button();
            PetugasList = new DataGridView();
            IdPetugas = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            useraccountBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)PetugasList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useraccountBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Location = new Point(513, 17);
            Search.Name = "Search";
            Search.PlaceholderText = "Search";
            Search.Size = new Size(210, 27);
            Search.TabIndex = 14;
            Search.TextChanged += Search_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 56);
            label1.Name = "label1";
            label1.Size = new Size(610, 15);
            label1.TabIndex = 13;
            label1.Text = "*click untuk memilih petugas dan double click untuk update petugas ";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Location = new Point(143, 12);
            button1.Name = "button1";
            button1.Size = new Size(137, 35);
            button1.TabIndex = 12;
            button1.Text = "Hapus Petugas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.LightGray;
            AddProduct.Location = new Point(0, 12);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(137, 35);
            AddProduct.TabIndex = 11;
            AddProduct.Text = "Tambah Petugas";
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // PetugasList
            // 
            PetugasList.AllowUserToAddRows = false;
            PetugasList.AllowUserToDeleteRows = false;
            PetugasList.AllowUserToResizeColumns = false;
            PetugasList.AllowUserToResizeRows = false;
            PetugasList.AutoGenerateColumns = false;
            PetugasList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PetugasList.BackgroundColor = Color.Silver;
            PetugasList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PetugasList.Columns.AddRange(new DataGridViewColumn[] { IdPetugas, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            PetugasList.DataSource = useraccountBindingSource;
            PetugasList.ImeMode = ImeMode.NoControl;
            PetugasList.Location = new Point(0, 72);
            PetugasList.Name = "PetugasList";
            PetugasList.ReadOnly = true;
            PetugasList.RowHeadersVisible = false;
            PetugasList.RowHeadersWidth = 51;
            PetugasList.ScrollBars = ScrollBars.Vertical;
            PetugasList.Size = new Size(744, 430);
            PetugasList.TabIndex = 10;
            PetugasList.CellClick += PetugasList_Click;
            PetugasList.CellDoubleClick += PetugasList_CellDoubleClick;
            // 
            // IdPetugas
            // 
            IdPetugas.DataPropertyName = "Id";
            IdPetugas.FillWeight = 41.17647F;
            IdPetugas.HeaderText = "Id";
            IdPetugas.MinimumWidth = 6;
            IdPetugas.Name = "IdPetugas";
            IdPetugas.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Tipe_User";
            dataGridViewTextBoxColumn1.FillWeight = 109.803917F;
            dataGridViewTextBoxColumn1.HeaderText = "Tipe_User";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nama";
            dataGridViewTextBoxColumn2.FillWeight = 109.803917F;
            dataGridViewTextBoxColumn2.HeaderText = "Nama";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Alamat";
            dataGridViewTextBoxColumn3.FillWeight = 109.803917F;
            dataGridViewTextBoxColumn3.HeaderText = "Alamat";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "NoTelp";
            dataGridViewTextBoxColumn4.FillWeight = 109.803917F;
            dataGridViewTextBoxColumn4.HeaderText = "NoTelp";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Username";
            dataGridViewTextBoxColumn5.FillWeight = 109.803917F;
            dataGridViewTextBoxColumn5.HeaderText = "Username";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Password";
            dataGridViewTextBoxColumn6.FillWeight = 109.803917F;
            dataGridViewTextBoxColumn6.HeaderText = "Password";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // useraccountBindingSource
            // 
            useraccountBindingSource.DataSource = typeof(DB_Create.User_account);
            // 
            // Petugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(744, 479);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(AddProduct);
            Controls.Add(PetugasList);
            Name = "Petugas";
            Text = "Petugas";
            ((System.ComponentModel.ISupportInitialize)PetugasList).EndInit();
            ((System.ComponentModel.ISupportInitialize)useraccountBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search;
        private Label label1;
        private Button button1;
        private Button AddProduct;
        private DataGridView PetugasList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn tipeUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noTelpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id_Petugas;
        private BindingSource useraccountBindingSource;
        private DataGridViewTextBoxColumn IdPetugas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}