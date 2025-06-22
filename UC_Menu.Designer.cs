namespace resto
{
    partial class UC_Menu
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
            dgvMenu = new DataGridView();
            btTambah = new Button();
            btEdit = new Button();
            btHapus = new Button();
            btReset = new Button();
            txtNamaMenu = new TextBox();
            txtHargaMenu = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // dgvMenu
            // 
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(39, 31);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.RowHeadersWidth = 62;
            dgvMenu.Size = new Size(905, 474);
            dgvMenu.TabIndex = 3;
            // 
            // btTambah
            // 
            btTambah.Location = new Point(211, 432);
            btTambah.Name = "btTambah";
            btTambah.Size = new Size(112, 34);
            btTambah.TabIndex = 6;
            btTambah.Text = "Tambah";
            btTambah.UseVisualStyleBackColor = true;
            btTambah.Click += btTambah_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(376, 432);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(112, 34);
            btEdit.TabIndex = 7;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btHapus
            // 
            btHapus.BackColor = Color.Red;
            btHapus.Location = new Point(533, 432);
            btHapus.Name = "btHapus";
            btHapus.Size = new Size(112, 34);
            btHapus.TabIndex = 8;
            btHapus.Text = "Hapus";
            btHapus.UseVisualStyleBackColor = false;
            btHapus.Click += btHapus_Click;
            // 
            // btReset
            // 
            btReset.Location = new Point(741, 432);
            btReset.Name = "btReset";
            btReset.Size = new Size(112, 34);
            btReset.TabIndex = 9;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // txtNamaMenu
            // 
            txtNamaMenu.Location = new Point(741, 277);
            txtNamaMenu.Name = "txtNamaMenu";
            txtNamaMenu.Size = new Size(150, 31);
            txtNamaMenu.TabIndex = 10;
            txtNamaMenu.Text = " ";
            // 
            // txtHargaMenu
            // 
            txtHargaMenu.Location = new Point(741, 358);
            txtHargaMenu.Name = "txtHargaMenu";
            txtHargaMenu.Size = new Size(150, 31);
            txtHargaMenu.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDark;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(735, 246);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 12;
            label1.Text = "Nama Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDark;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(735, 327);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 13;
            label2.Text = "Harga";
            // 
            // UC_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHargaMenu);
            Controls.Add(txtNamaMenu);
            Controls.Add(btReset);
            Controls.Add(btHapus);
            Controls.Add(btEdit);
            Controls.Add(btTambah);
            Controls.Add(dgvMenu);
            Name = "UC_Menu";
            Size = new Size(982, 540);
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMenu;
        private Button btTambah;
        private Button btEdit;
        private Button btHapus;
        private Button btReset;
        private TextBox txtNamaMenu;
        private TextBox txtHargaMenu;
        private Label label1;
        private Label label2;
    }
}
