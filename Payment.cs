using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using resto.Models;
using Npgsql;

namespace resto
{
    public partial class UC_Payment : BaseUC
    {
        private List<ModelsMenu> pesanan;

        public UC_Payment(List<ModelsMenu> pesananDariOrder)
        {
            InitializeComponent();
            this.pesanan = pesananDariOrder;
            TampilkanPesananDanTotal();
        }
        private void TampilkanPesananDanTotal()
        {
            dgvPayment.DataSource = pesanan.Select(p => new
            {
                p.Nama,
                Harga = $"Rp {p.Harga:N0}"
            }).ToList();

            int total = pesanan.Sum(p => p.Harga);
            lbTotal.Text = $"Total: Rp {total:N0}";
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void btBayar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pembayaran Berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pesanan.Clear(); //reset pesanan
            dgvPayment.DataSource = null;
            lbTotal.Text = "Total: Rp 0";
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            var ucOrder = new UC_Order();

            Control parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                parent.Controls.Add(ucOrder);
            }
            else
            {
                MessageBox.Show("Gagal kembali ke UC_Order. Parent control tidak ditemukan.");
            }
        }
    }
}
