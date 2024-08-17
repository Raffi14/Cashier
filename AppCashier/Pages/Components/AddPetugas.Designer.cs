namespace POST_System.Pages.Components
{
    partial class AddPetugas
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
            ProductTitle = new Label();
            InpNo = new TextBox();
            InpAlamat = new TextBox();
            InpName = new TextBox();
            InpPass = new TextBox();
            InpUsername = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // ProductTitle
            // 
            ProductTitle.AutoSize = true;
            ProductTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductTitle.Location = new Point(12, 20);
            ProductTitle.Name = "ProductTitle";
            ProductTitle.Size = new Size(364, 60);
            ProductTitle.TabIndex = 5;
            ProductTitle.Text = "Tambah Petugas";
            // 
            // InpNo
            // 
            InpNo.Location = new Point(54, 233);
            InpNo.Name = "InpNo";
            InpNo.PlaceholderText = "noTelp";
            InpNo.Size = new Size(268, 27);
            InpNo.TabIndex = 8;
            // 
            // InpAlamat
            // 
            InpAlamat.Location = new Point(54, 172);
            InpAlamat.Name = "InpAlamat";
            InpAlamat.PlaceholderText = "alamat";
            InpAlamat.Size = new Size(268, 27);
            InpAlamat.TabIndex = 7;
            // 
            // InpName
            // 
            InpName.Location = new Point(54, 105);
            InpName.Name = "InpName";
            InpName.PlaceholderText = "nama petugas";
            InpName.Size = new Size(268, 27);
            InpName.TabIndex = 6;
            // 
            // InpPass
            // 
            InpPass.Location = new Point(54, 363);
            InpPass.Name = "InpPass";
            InpPass.PlaceholderText = "password";
            InpPass.Size = new Size(268, 27);
            InpPass.TabIndex = 10;
            // 
            // InpUsername
            // 
            InpUsername.Location = new Point(54, 296);
            InpUsername.Name = "InpUsername";
            InpUsername.PlaceholderText = "username";
            InpUsername.Size = new Size(268, 27);
            InpUsername.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(124, 431);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 11;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddPetugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 509);
            Controls.Add(button1);
            Controls.Add(InpPass);
            Controls.Add(InpUsername);
            Controls.Add(InpNo);
            Controls.Add(InpAlamat);
            Controls.Add(InpName);
            Controls.Add(ProductTitle);
            Name = "AddPetugas";
            Text = "AddPetugas";
            Load += AddPetugas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductTitle;
        private TextBox InpNo;
        private TextBox InpAlamat;
        private TextBox InpName;
        private TextBox InpPass;
        private TextBox InpUsername;
        private Button button1;
    }
}