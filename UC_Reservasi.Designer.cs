namespace resto
{
    partial class UC_Reservasi
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
            lbTitle = new Label();
            tbPelanggan = new TextBox();
            tbNoTelp = new TextBox();
            tbJumlahOrang = new TextBox();
            dtReservasi = new DateTimePicker();
            btTambahR = new Button();
            btClearR = new Button();
            dgvReservasi = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btPilihMenu = new Button();
            label4 = new Label();
            tbNoMeja = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReservasi).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = SystemColors.ControlLightLight;
            lbTitle.Location = new Point(34, 10);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(336, 45);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Reservasi MaemYuk";
            // 
            // tbPelanggan
            // 
            tbPelanggan.Location = new Point(43, 96);
            tbPelanggan.Name = "tbPelanggan";
            tbPelanggan.Size = new Size(150, 31);
            tbPelanggan.TabIndex = 1;
            // 
            // tbNoTelp
            // 
            tbNoTelp.Location = new Point(43, 158);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(150, 31);
            tbNoTelp.TabIndex = 2;
            // 
            // tbJumlahOrang
            // 
            tbJumlahOrang.Location = new Point(43, 223);
            tbJumlahOrang.Name = "tbJumlahOrang";
            tbJumlahOrang.Size = new Size(150, 31);
            tbJumlahOrang.TabIndex = 3;
            // 
            // dtReservasi
            // 
            dtReservasi.Location = new Point(43, 367);
            dtReservasi.Name = "dtReservasi";
            dtReservasi.Size = new Size(300, 31);
            dtReservasi.TabIndex = 4;
            // 
            // btTambahR
            // 
            btTambahR.Location = new Point(635, 367);
            btTambahR.Name = "btTambahR";
            btTambahR.Size = new Size(112, 34);
            btTambahR.TabIndex = 5;
            btTambahR.Text = "Tambah";
            btTambahR.UseVisualStyleBackColor = true;
            btTambahR.Click += btTambahR_Click;
            // 
            // btClearR
            // 
            btClearR.BackColor = Color.Red;
            btClearR.Location = new Point(982, 367);
            btClearR.Name = "btClearR";
            btClearR.Size = new Size(112, 34);
            btClearR.TabIndex = 6;
            btClearR.Text = "Clear";
            btClearR.UseVisualStyleBackColor = false;
            btClearR.Click += btClearR_Click;
            // 
            // dgvReservasi
            // 
            dgvReservasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservasi.Location = new Point(235, 80);
            dgvReservasi.Name = "dgvReservasi";
            dgvReservasi.RowHeadersWidth = 62;
            dgvReservasi.Size = new Size(859, 242);
            dgvReservasi.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(44, 65);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 8;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(44, 132);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 9;
            label2.Text = "No.Telp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(43, 195);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 10;
            label3.Text = "Jumlah Orang";
            // 
            // btPilihMenu
            // 
            btPilihMenu.Location = new Point(817, 367);
            btPilihMenu.Name = "btPilihMenu";
            btPilihMenu.Size = new Size(112, 34);
            btPilihMenu.TabIndex = 11;
            btPilihMenu.Text = "Pilih Menu";
            btPilihMenu.UseVisualStyleBackColor = true;
            btPilihMenu.Click += btPilihMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(43, 260);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 12;
            label4.Text = "No. Meja";
            // 
            // tbNoMeja
            // 
            tbNoMeja.Location = new Point(43, 291);
            tbNoMeja.Name = "tbNoMeja";
            tbNoMeja.Size = new Size(150, 31);
            tbNoMeja.TabIndex = 13;
            // 
            // UC_Reservasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(tbNoMeja);
            Controls.Add(label4);
            Controls.Add(btPilihMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvReservasi);
            Controls.Add(btClearR);
            Controls.Add(btTambahR);
            Controls.Add(dtReservasi);
            Controls.Add(tbJumlahOrang);
            Controls.Add(tbNoTelp);
            Controls.Add(tbPelanggan);
            Controls.Add(lbTitle);
            Name = "UC_Reservasi";
            Size = new Size(1130, 441);
            Load += UC_Reservasi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private TextBox tbPelanggan;
        private TextBox tbNoTelp;
        private TextBox tbJumlahOrang;
        private DateTimePicker dtReservasi;
        private Button btTambahR;
        private Button btClearR;
        private DataGridView dgvReservasi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btPilihMenu;
        private Label label4;
        private TextBox tbNoMeja;
    }
}
