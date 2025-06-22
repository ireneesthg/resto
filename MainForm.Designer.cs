namespace resto
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReservasi = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnHomepage = new System.Windows.Forms.Button();

            this.panelMain.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(839, 437);
            this.panelMain.TabIndex = 0;

            // Tambahkan panels ke dalam panelMain
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelSideBar);

            // 
            // panelSideBar
            // 
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(197, 437);
            this.panelSideBar.TabIndex = 0;

            // Tambahkan tombol ke panelSideBar
            this.panelSideBar.Controls.Add(this.btnLogout);
            this.panelSideBar.Controls.Add(this.btnReservasi);
            this.panelSideBar.Controls.Add(this.btnOrder);
            this.panelSideBar.Controls.Add(this.btnMenu);
            this.panelSideBar.Controls.Add(this.btnHomepage);

            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(197, 0);  // dimulai setelah sidebar
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(642, 437);
            this.panelContent.TabIndex = 1;
            this.panelContent.BackColor = System.Drawing.Color.White;

            // 
            // btnHomepage
            // 
            this.btnHomepage.Location = new System.Drawing.Point(37, 25);
            this.btnHomepage.Name = "btnHomepage";
            this.btnHomepage.Size = new System.Drawing.Size(112, 34);
            this.btnHomepage.TabIndex = 0;
            this.btnHomepage.Text = "Homepage";
            this.btnHomepage.UseVisualStyleBackColor = true;
            this.btnHomepage.Click += new System.EventHandler(this.btnHomepage_Click);

            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(37, 79);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 34);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);

            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(37, 133);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(112, 34);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);

            // 
            // btnReservasi
            // 
            this.btnReservasi.Location = new System.Drawing.Point(37, 189);
            this.btnReservasi.Name = "btnReservasi";
            this.btnReservasi.Size = new System.Drawing.Size(112, 34);
            this.btnReservasi.TabIndex = 3;
            this.btnReservasi.Text = "Reservasi";
            this.btnReservasi.UseVisualStyleBackColor = true;
            this.btnReservasi.Click += new System.EventHandler(this.btnReservasi_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(37, 381);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 437);
            this.Controls.Add(this.panelMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.panelMain.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnHomepage;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReservasi;
        private System.Windows.Forms.Button btnLogout;
    }
}
