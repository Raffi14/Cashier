namespace POST_System
{
    partial class Login
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
            label1 = new Label();
            button1 = new Button();
            username = new TextBox();
            password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(142, 60);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // button1
            // 
            button1.Location = new Point(163, 256);
            button1.Name = "button1";
            button1.Size = new Size(125, 38);
            button1.TabIndex = 1;
            button1.Text = "Log-IN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // username
            // 
            username.Location = new Point(49, 121);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(330, 27);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.BackColor = SystemColors.Window;
            password.Location = new Point(49, 192);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(330, 27);
            password.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(434, 376);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximizeBox = false;
            MaximumSize = new Size(453, 423);
            MinimumSize = new Size(452, 423);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox username;
        private TextBox password;
    }
}