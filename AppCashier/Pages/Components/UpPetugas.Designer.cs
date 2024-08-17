namespace POST_System.Pages.Components
{
    partial class UpPetugas
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
            button1 = new Button();
            EdPass = new TextBox();
            EdUsername = new TextBox();
            EdNo = new TextBox();
            EdAlamat = new TextBox();
            EdName = new TextBox();
            ProductTitle = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(129, 441);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 18;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EdPass
            // 
            EdPass.Location = new Point(59, 373);
            EdPass.Name = "EdPass";
            EdPass.PlaceholderText = "password";
            EdPass.Size = new Size(268, 27);
            EdPass.TabIndex = 17;
            // 
            // EdUsername
            // 
            EdUsername.Location = new Point(59, 306);
            EdUsername.Name = "EdUsername";
            EdUsername.PlaceholderText = "username";
            EdUsername.Size = new Size(268, 27);
            EdUsername.TabIndex = 16;
            // 
            // EdNo
            // 
            EdNo.Location = new Point(59, 243);
            EdNo.Name = "EdNo";
            EdNo.PlaceholderText = "noTelp";
            EdNo.Size = new Size(268, 27);
            EdNo.TabIndex = 15;
            // 
            // EdAlamat
            // 
            EdAlamat.Location = new Point(59, 182);
            EdAlamat.Name = "EdAlamat";
            EdAlamat.PlaceholderText = "alamat";
            EdAlamat.Size = new Size(268, 27);
            EdAlamat.TabIndex = 14;
            // 
            // EdName
            // 
            EdName.Location = new Point(59, 115);
            EdName.Name = "EdName";
            EdName.PlaceholderText = "nama petugas";
            EdName.Size = new Size(268, 27);
            EdName.TabIndex = 13;
            // 
            // ProductTitle
            // 
            ProductTitle.AutoSize = true;
            ProductTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductTitle.Location = new Point(30, 20);
            ProductTitle.Name = "ProductTitle";
            ProductTitle.Size = new Size(281, 60);
            ProductTitle.TabIndex = 12;
            ProductTitle.Text = "Edit Petugas";
            // 
            // UpPetugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 509);
            Controls.Add(button1);
            Controls.Add(EdPass);
            Controls.Add(EdUsername);
            Controls.Add(EdNo);
            Controls.Add(EdAlamat);
            Controls.Add(EdName);
            Controls.Add(ProductTitle);
            Name = "UpPetugas";
            Text = "UpPetugas";
            Load += UpPetugas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox EdPass;
        private TextBox EdUsername;
        private TextBox EdNo;
        private TextBox EdAlamat;
        private TextBox EdName;
        private Label ProductTitle;
    }
}