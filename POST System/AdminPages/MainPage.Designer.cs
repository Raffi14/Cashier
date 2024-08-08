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
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(28, 46);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // Staff
            // 
            Staff.BackColor = Color.Gray;
            Staff.Location = new Point(11, 234);
            Staff.Name = "Staff";
            Staff.Size = new Size(107, 58);
            Staff.TabIndex = 3;
            Staff.Text = "Staff";
            Staff.UseVisualStyleBackColor = false;
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
            TransactionNav.Click += TransactionNav_Click;
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
    }
}