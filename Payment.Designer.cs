namespace resto
{
    partial class UC_Payment
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
            dgvPayment = new DataGridView();
            lbTotal = new Label();
            btBayar = new Button();
            btKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.DarkRed;
            lbTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = SystemColors.ControlLightLight;
            lbTitle.Location = new Point(16, 10);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(150, 45);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Payment";
            // 
            // dgvPayment
            // 
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(26, 72);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowHeadersWidth = 62;
            dgvPayment.Size = new Size(653, 299);
            dgvPayment.TabIndex = 1;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.White;
            lbTotal.Location = new Point(264, 337);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(49, 25);
            lbTotal.TabIndex = 2;
            lbTotal.Text = "Total";
            // 
            // btBayar
            // 
            btBayar.BackColor = SystemColors.Highlight;
            btBayar.Location = new Point(705, 337);
            btBayar.Name = "btBayar";
            btBayar.Size = new Size(112, 34);
            btBayar.TabIndex = 3;
            btBayar.Text = "Bayar";
            btBayar.UseVisualStyleBackColor = false;
            btBayar.Click += btBayar_Click;
            // 
            // btKembali
            // 
            btKembali.Location = new Point(839, 337);
            btKembali.Name = "btKembali";
            btKembali.Size = new Size(112, 34);
            btKembali.TabIndex = 4;
            btKembali.Text = "Kembali";
            btKembali.UseVisualStyleBackColor = true;
            btKembali.Click += btKembali_Click;
            // 
            // UC_Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            Controls.Add(btKembali);
            Controls.Add(btBayar);
            Controls.Add(lbTotal);
            Controls.Add(dgvPayment);
            Controls.Add(lbTitle);
            Name = "UC_Payment";
            Size = new Size(980, 390);
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private DataGridView dgvPayment;
        private Label lbTotal;
        private Button btBayar;
        private Button btKembali;
    }
}
