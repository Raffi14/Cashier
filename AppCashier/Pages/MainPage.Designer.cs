namespace POST_System
{
    partial class MainPage
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
            Riwayat = new Button();
            Username = new Label();
            Staff = new Button();
            TransactionNav = new Button();
            ProductNav = new Button();
            LogOutButton = new Button();
            productBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(DB_Create.Product);
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(Riwayat);
            panel1.Controls.Add(Username);
            panel1.Controls.Add(Staff);
            panel1.Controls.Add(TransactionNav);
            panel1.Controls.Add(ProductNav);
            panel1.Controls.Add(LogOutButton);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 515);
            panel1.TabIndex = 0;
            // 
            // Riwayat
            // 
            Riwayat.BackColor = Color.Gray;
            Riwayat.Location = new Point(11, 279);
            Riwayat.Name = "Riwayat";
            Riwayat.Size = new Size(107, 58);
            Riwayat.TabIndex = 4;
            Riwayat.Text = "Riwayat Transaksi";
            Riwayat.UseVisualStyleBackColor = false;
            Riwayat.Click += Riwayat_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Snap ITC", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Username.Location = new Point(0, 24);
            Username.Name = "Username";
            Username.Size = new Size(121, 27);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Staff
            // 
            Staff.BackColor = Color.Gray;
            Staff.Location = new Point(11, 151);
            Staff.Name = "Staff";
            Staff.Size = new Size(107, 58);
            Staff.TabIndex = 3;
            Staff.Text = "Petugas";
            Staff.UseVisualStyleBackColor = false;
            Staff.Click += Staff_Click;
            // 
            // TransactionNav
            // 
            TransactionNav.BackColor = Color.Gray;
            TransactionNav.Location = new Point(11, 215);
            TransactionNav.Name = "TransactionNav";
            TransactionNav.Size = new Size(107, 58);
            TransactionNav.TabIndex = 2;
            TransactionNav.Text = "Transaksi";
            TransactionNav.UseVisualStyleBackColor = false;
            TransactionNav.Click += TransactionNav_Click;
            // 
            // ProductNav
            // 
            ProductNav.BackColor = Color.Gray;
            ProductNav.Location = new Point(11, 87);
            ProductNav.Name = "ProductNav";
            ProductNav.Size = new Size(107, 58);
            ProductNav.TabIndex = 1;
            ProductNav.Text = "Produk";
            ProductNav.UseVisualStyleBackColor = false;
            ProductNav.Click += button2_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.Gray;
            LogOutButton.Location = new Point(28, 457);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(72, 33);
            LogOutButton.TabIndex = 0;
            LogOutButton.Text = "Log out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += button1_Click;
            // 
            // productBox
            // 
            productBox.Location = new Point(125, 0);
            productBox.Name = "productBox";
            productBox.Size = new Size(731, 522);
            productBox.TabIndex = 2;
            productBox.TabStop = false;
            productBox.Text = "Product";
            productBox.UseCompatibleTextRendering = true;
            // 
            // MainPage
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
            Name = "MainPage";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            Load += AdminHome_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource productBindingSource;
        private Panel panel1;
        private Button LogOutButton;
        private Button Staff;
        private Button TransactionNav;
        private Button ProductNav;
        private Label Username;
        private GroupBox productBox;
        private Button Riwayat;
    }
}