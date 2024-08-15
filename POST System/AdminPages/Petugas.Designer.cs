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
            Id = new DataGridViewTextBoxColumn();
            tipeUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            namaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alamatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            noTelpDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            PetugasList.Columns.AddRange(new DataGridViewColumn[] { Id, tipeUserDataGridViewTextBoxColumn, namaDataGridViewTextBoxColumn, alamatDataGridViewTextBoxColumn, noTelpDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
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
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 41.17647F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // tipeUserDataGridViewTextBoxColumn
            // 
            tipeUserDataGridViewTextBoxColumn.DataPropertyName = "Tipe_User";
            tipeUserDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            tipeUserDataGridViewTextBoxColumn.HeaderText = "Tipe_User";
            tipeUserDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipeUserDataGridViewTextBoxColumn.Name = "tipeUserDataGridViewTextBoxColumn";
            tipeUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            namaDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            alamatDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            alamatDataGridViewTextBoxColumn.MinimumWidth = 6;
            alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noTelpDataGridViewTextBoxColumn
            // 
            noTelpDataGridViewTextBoxColumn.DataPropertyName = "NoTelp";
            noTelpDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            noTelpDataGridViewTextBoxColumn.HeaderText = "NoTelp";
            noTelpDataGridViewTextBoxColumn.MinimumWidth = 6;
            noTelpDataGridViewTextBoxColumn.Name = "noTelpDataGridViewTextBoxColumn";
            noTelpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.FillWeight = 109.803917F;
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.ReadOnly = true;
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
        private BindingSource useraccountBindingSource;
    }
}