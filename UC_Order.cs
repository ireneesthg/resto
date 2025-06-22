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
    public partial class UC_Order : BaseUC
    {
        private List<ModelsMenu> daftarMenu;
        private List<ModelsMenu> pesanan = new List<ModelsMenu>();
        private string namaPelanggan;

        public UC_Order()
        {
            InitializeComponent();
            Load += UC_Order_Load;
        }


        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if (pesanan.Count == 0)
            {
                MessageBox.Show("Pesanan masih kosong.");
                return;
            }

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();

                    //simpan ke tabel Orders
                    string insertOrder = "INSERT INTO \"Orders\" (tanggal, user_id) VALUES (NOW(), @user_id) RETURNING order_id";
                    int orderId;

                    using (var cmd = new NpgsqlCommand(insertOrder, conn))
                    {
                        cmd.Parameters.AddWithValue("user_id", ListUser.LoggedInUser.Id); //new
                        orderId = (int)cmd.ExecuteScalar();
                    }

                    //simpan setiap item ke OrderItems
                    foreach (var item in pesanan)
                    {
                        //cari menu_id dari MenuItems
                        string getMenuId = "SELECT menu_id FROM \"MenuItems\" WHERE nama = @nama LIMIT 1";
                        int menuId;

                        using (var cmd = new NpgsqlCommand(getMenuId, conn))
                        {
                            cmd.Parameters.AddWithValue("nama", item.Nama);
                            menuId = (int)cmd.ExecuteScalar();
                        }

                        string insertItem = "INSERT INTO \"OrderItems\" (order_id, menu_id, jumlah) VALUES (@order_id, @menu_id, 1)";
                        using (var cmd = new NpgsqlCommand(insertItem, conn))
                        {
                            cmd.Parameters.AddWithValue("order_id", orderId);
                            cmd.Parameters.AddWithValue("menu_id", menuId);
                            cmd.Parameters.AddWithValue("jumlah", 1); //sementara 1, nanti bisa ditambah kuantitas
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Pesanan berhasil disimpan!");

                    //pindah ke UC_Payment
                    var ucPayment = new UC_Payment(pesanan);
                    Control parent = this.Parent;
                    if (parent != null)
                    {
                        parent.Controls.Clear();
                        parent.Controls.Add(ucPayment);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan pesanan: " + ex.Message);
            }
        }

        private void flMenuOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Order_Load(object sender, EventArgs e)
        {
            daftarMenu = new List<ModelsMenu>
            {
                new ModelsMenu(1, "Paket 1", 15000),
                new ModelsMenu(2, "Paket 2", 20000),
                new ModelsMenu(3, "Paket 3", 20000)
            };

            foreach (var menu in daftarMenu)
            {
                var menuItem = new UC_MenuItem(daftarMenu);
                menuItem.TambahkanPesanan += TambahkanPesanan;
                flMenuOrder.Controls.Add(menuItem);
            }
            TampilkanPesanan();
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.MultiSelect = false;

        }

        private void TambahkanPesanan(string nama, int harga)
        {
            pesanan.Add(new ModelsMenu(pesanan.Count + 1, nama, harga));
            TampilkanPesanan();
        }
        private void TampilkanPesanan()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = pesanan.Select(m => new
            {
                m.Nama,
                Harga = $"Rp {m.Harga:N0}"
            }).ToList();
        }

        private void dgvOrder_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            if (dgvOrder.SelectedRows.Count > 0)
            {
                int index = dgvOrder.SelectedRows[0].Index;

                if (index >= 0 && index < pesanan.Count)
                {
                    pesanan.RemoveAt(index);
                    TampilkanPesanan();
                }
            }
                else
                {
                    MessageBox.Show("Pilih salah satu pesanan yang ingin dihapus.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        public void SetPelanggan(string nama)
        {
            namaPelanggan = nama;
        }
    }
}
