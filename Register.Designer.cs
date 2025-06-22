namespace resto
{
    partial class Register
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lbUsername = new Label();
            lbPassword = new Label();
            btDaftar = new Button();
            btKembali = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(150, 80);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(261, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(150, 151);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 31);
            txtPassword.TabIndex = 1;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = Color.DarkRed;
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(144, 50);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(91, 25);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            lbUsername.Click += label1_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.DarkRed;
            lbPassword.ForeColor = Color.White;
            lbPassword.Location = new Point(144, 121);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(87, 25);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // btDaftar
            // 
            btDaftar.BackColor = SystemColors.Highlight;
            btDaftar.Location = new Point(150, 203);
            btDaftar.Name = "btDaftar";
            btDaftar.Size = new Size(112, 34);
            btDaftar.TabIndex = 7;
            btDaftar.Text = "Daftar";
            btDaftar.UseVisualStyleBackColor = false;
            btDaftar.Click += btDaftar_Click;
            // 
            // btKembali
            // 
            btKembali.Location = new Point(299, 203);
            btKembali.Name = "btKembali";
            btKembali.Size = new Size(112, 34);
            btKembali.TabIndex = 8;
            btKembali.Text = "Kembali";
            btKembali.UseVisualStyleBackColor = true;
            btKembali.Click += btKembali_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(800, 450);
            Controls.Add(btKembali);
            Controls.Add(btDaftar);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbUsername;
        private Label lbPassword;
        private Button btDaftar;
        private Button btKembali;
    }
}