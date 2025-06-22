namespace resto
{
    partial class UC_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            lbWelcome = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWelcome.Location = new Point(36, 26);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(641, 48);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "Selamat Datang Di Restoran Maem Yuk";
            lbWelcome.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(1150, 33);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Jalan Jawa 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(948, 33);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 2;
            label3.Text = "ig : @maemYuk";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkRed;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1263, 95);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DarkRed;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1108, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(904, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbWelcome);
            Controls.Add(panel1);
            Name = "UC_Home";
            Size = new Size(1266, 428);
            Load += UC_Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbWelcome;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
