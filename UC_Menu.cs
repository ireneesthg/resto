using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using resto.Models;

namespace resto
{
    public partial class UC_Menu : BaseUC
    {
        private List<ModelsMenu> listMenu = new List<ModelsMenu>();
        private int selectedId = -1;
        public UC_Menu(string role)
        {
            InitializeComponent();
            this.Load += (s, e) => LoadData();
            btTambah.Click += btTambah_Click;
            btEdit.Click += btEdit_Click;
            btHapus.Click += btHapus_Click;
            dgvMenu.CellClick += dgvMenu_CellClick;
        }

        public override void LoadData()
        {
            listMenu.Clear();

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT menu_id, nama, harga FROM \"MenuItems\" ORDER BY menu_id";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int menu_id = Convert.ToInt32(reader["menu_id"]);
                        string nama = reader["nama"].ToString();
                        int harga = Convert.ToInt32(reader["harga"]);

                        listMenu.Add(new ModelsMenu(menu_id, nama, harga));
                    }
                }
            }

            TampilkanData();
        }

        private void TampilkanData()
        {
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listMenu.Select(m => new
            {
                m.Id,
                m.Nama,
                m.Harga
            }).ToList();

            dgvMenu.Columns["Id"].Visible = false; //sembunyikan kolom id
            dgvMenu.Columns["Harga"].DefaultCellStyle.Format = "C0";

            dgvMenu.ClearSelection();
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.MultiSelect = false;
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < listMenu.Count)
            {
                var menu = listMenu[e.RowIndex];
                selectedId = menu.Id;
                txtNamaMenu.Text = menu.Nama;
                txtHargaMenu.Text = menu.Harga.ToString();
            }
        }
        private void btTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaMenu.Text) || string.IsNullOrWhiteSpace(txtHargaMenu.Text))
                return;

            int harga;
            if (!int.TryParse(txtHargaMenu.Text, out harga))
            {
                MessageBox.Show("Harga harus berupa angka.");
                return;
            }

            int newId = listMenu.Count > 0 ? listMenu.Max(m => m.Id) + 1 : 1;

            //menggunakan constructor langsung
            var newMenu = new ModelsMenu(newId, txtNamaMenu.Text, harga);

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string insertQuery = "INSERT INTO \"MenuItems\" (nama, harga) VALUES (@n, @h)";
                using var cmd = new NpgsqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@n", txtNamaMenu.Text);
                cmd.Parameters.AddWithValue("@h", harga);
                cmd.ExecuteNonQuery();
            }
            LoadData(); //reload dari database

            ResetForm();
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"selectedId sekarang: {selectedId}", "Debug");

            if (selectedId == -1)
            {
                MessageBox.Show("Pilih menu yang ingin diedit dari tabel.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNamaMenu.Text) || string.IsNullOrWhiteSpace(txtHargaMenu.Text))
            {
                MessageBox.Show("Nama dan harga menu tidak boleh kosong.");
                return;
            }
            if (!int.TryParse(txtHargaMenu.Text, out int hargaBaru))
            {
                MessageBox.Show("Harga harus berupa angka.");
                return;
            }
            var menu = listMenu.FirstOrDefault(m => m.Id == selectedId);
            if (menu != null)
            {
                menu.Nama = txtNamaMenu.Text;
                menu.Harga = hargaBaru;
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string updateQuery = "UPDATE \"MenuItems\" SET nama = @n, harga = @h WHERE menu_id = @id";
                    using var cmd = new NpgsqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@n", txtNamaMenu.Text);
                    cmd.Parameters.AddWithValue("@h", hargaBaru);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                LoadData();


                TampilkanData();
                ResetForm();
            }
        }
        private void btHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Pilih menu yang ingin dihapus dari tabel.");
                return;
            }

            var menu = listMenu.FirstOrDefault(m => m.Id == selectedId);
            if (menu != null)
            {
                var konfirmasi = MessageBox.Show($"Yakin ingin menghapus menu '{menu.Nama}'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (konfirmasi == DialogResult.Yes)
                {
                    using (var conn = Database.GetConnection())
                    {
                        conn.Open();
                        string deleteQuery = "DELETE FROM \"MenuItems\" WHERE menu_id = @id";
                        using var cmd = new NpgsqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();

                    listMenu.Remove(menu);
                    TampilkanData();
                    ResetForm();
                }
            }
        }
        private void ResetForm()
        {
            txtNamaMenu.Clear();
            txtHargaMenu.Clear();
            selectedId = -1;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
