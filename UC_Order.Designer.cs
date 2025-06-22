namespace resto
{
    partial class UC_Order
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
            dgvOrder = new DataGridView();
            btOrder = new Button();
            flMenuOrder = new FlowLayoutPanel();
            btHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(758, 15);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.Size = new Size(359, 382);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick_1;
            // 
            // btOrder
            // 
            btOrder.BackColor = Color.FromArgb(0, 0, 192);
            btOrder.ForeColor = SystemColors.ControlLightLight;
            btOrder.Location = new Point(758, 403);
            btOrder.Name = "btOrder";
            btOrder.Size = new Size(359, 34);
            btOrder.TabIndex = 1;
            btOrder.Text = "Tambah Order";
            btOrder.UseVisualStyleBackColor = false;
            btOrder.Click += btOrder_Click;
            // 
            // flMenuOrder
            // 
            flMenuOrder.BackColor = Color.White;
            flMenuOrder.Location = new Point(17, 15);
            flMenuOrder.Name = "flMenuOrder";
            flMenuOrder.Size = new Size(725, 303);
            flMenuOrder.TabIndex = 2;
            flMenuOrder.Paint += flMenuOrder_Paint;
            // 
            // btHapus
            // 
            btHapus.BackColor = Color.Red;
            btHapus.ForeColor = SystemColors.ControlLightLight;
            btHapus.Location = new Point(758, 438);
            btHapus.Name = "btHapus";
            btHapus.Size = new Size(359, 34);
            btHapus.TabIndex = 3;
            btHapus.Text = "Hapus";
            btHapus.UseVisualStyleBackColor = false;
            btHapus.Click += btHapus_Click;
            // 
            // UC_Order
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(btHapus);
            Controls.Add(flMenuOrder);
            Controls.Add(btOrder);
            Controls.Add(dgvOrder);
            Name = "UC_Order";
            Size = new Size(1133, 489);
            Load += UC_Order_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrder;
        private Button btOrder;
        private FlowLayoutPanel flMenuOrder;
        private Button btHapus;
    }
}
