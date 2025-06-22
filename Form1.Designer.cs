namespace resto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.Windows.Forms.ComboBox cbRole;
        private System.ComponentModel.IContainer components = null;

        /// <summary>cb
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LbPassword = new Label();
            lbUsername = new Label();
            LbDaftar = new LinkLabel();
            btnClear = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkRed;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(421, 263);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 25;
            label1.Text = "Belum punya akun?";
            // 
            // LbPassword
            // 
            LbPassword.AutoSize = true;
            LbPassword.BackColor = Color.DarkRed;
            LbPassword.ForeColor = Color.White;
            LbPassword.Location = new Point(419, 194);
            LbPassword.Name = "LbPassword";
            LbPassword.Size = new Size(87, 25);
            LbPassword.TabIndex = 24;
            LbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.BackColor = Color.DarkRed;
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(419, 122);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(91, 25);
            lbUsername.TabIndex = 23;
            lbUsername.Text = "Username";
            // 
            // LbDaftar
            // 
            LbDaftar.ActiveLinkColor = Color.RosyBrown;
            LbDaftar.AutoSize = true;
            LbDaftar.BackColor = Color.DarkRed;
            LbDaftar.LinkColor = Color.LightSkyBlue;
            LbDaftar.Location = new Point(609, 262);
            LbDaftar.Name = "LbDaftar";
            LbDaftar.Size = new Size(66, 25);
            LbDaftar.TabIndex = 22;
            LbDaftar.TabStop = true;
            LbDaftar.Text = "Daftar!";
            LbDaftar.LinkClicked += LbDaftar_LinkClicked;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(555, 314);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Highlight;
            btnLogin.Location = new Point(425, 314);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(425, 225);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(242, 31);
            txtPassword.TabIndex = 19;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(425, 154);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(242, 31);
            txtUsername.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(LbPassword);
            Controls.Add(lbUsername);
            Controls.Add(LbDaftar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Label LbPassword;
        private Label lbUsername;
        private LinkLabel LbDaftar;
        private Button btnClear;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Panel panelCenter;
    }
}
