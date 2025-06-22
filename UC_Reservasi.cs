using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using resto.Models;
using Npgsql;
using System.Transactions;

namespace resto
{
    public partial class UC_Reservasi : BaseUC
    {
        private List<ModelsReservasi> daftarReservasi = new List<ModelsReservasi>();

        public UC_Reservasi()
        {
            InitializeComponent();
            TampilkanReservasi();
        }

        private void btTambahR_Click(object sender, EventArgs e)
        {
            var reservasi = new ModelsReservasi
            {
                NamaPelanggan = tbPelanggan.Text,
                NoTelepon = tbNoTelp.Text,
                JumlahOrang = int.TryParse(tbJumlahOrang.Text, out var jumlah) ? jumlah : 0,
                Tanggal = dtReservasi.Value,
                NoMeja = int.TryParse(tbNoMeja.Text, out var meja) ? meja : 0
            };

            try
            {

                //simpan ke database
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO ""Reservasi"" 
                        (nama_pemesan, no_telepon, jumlah_orang, tanggal, jam, nomor_meja) 
                        VALUES (@nama, @telepon, @jumlah, @tanggal, @jam, @meja)";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("nama", reservasi.NamaPelanggan);
                        cmd.Parameters.AddWithValue("telepon", reservasi.NoTelepon);
                        cmd.Parameters.AddWithValue("jumlah", reservasi.JumlahOrang);
                        cmd.Parameters.AddWithValue("tanggal", reservasi.Tanggal.Date);
                        cmd.Parameters.AddWithValue("jam", reservasi.Tanggal.TimeOfDay);
                        cmd.Parameters.AddWithValue("meja", reservasi.NoMeja);

                        cmd.ExecuteNonQuery();
                    }
                }
                    MessageBox.Show("Reservasi berhasil ditambahkan!");
                    TampilkanReservasi(); //reload setelah input
                    ResetForm();
                }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menambahkan reservasi: " + ex.Message);
            }
        }

        private void TampilkanReservasi()
        {
            daftarReservasi.Clear();

            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM \"Reservasi\"";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var reservasi = new ModelsReservasi
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("reservasi_id")),
                                NamaPelanggan = reader.GetString(reader.GetOrdinal("nama_pemesan")),
                                NoTelepon = reader.GetString(reader.GetOrdinal("no_telepon")),
                                JumlahOrang = reader.GetInt32(reader.GetOrdinal("jumlah_orang")),
                                Tanggal = reader.GetDateTime(reader.GetOrdinal("tanggal")).Date
                                          .Add(reader.GetTimeSpan(reader.GetOrdinal("jam"))),
                                NoMeja = reader.GetInt32(reader.GetOrdinal("nomor_meja"))
                            };

                            daftarReservasi.Add(reservasi);
                        }
                    }
                }

                dgvReservasi.DataSource = null;
                dgvReservasi.DataSource = daftarReservasi.Select(r => new
                {
                    r.NamaPelanggan,
                    r.NoTelepon,
                    r.JumlahOrang,
                    Tanggal = r.Tanggal.ToString("dd-MM-yyyy HH:mm"),
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data reservasi: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            tbPelanggan.Clear();
            tbNoTelp.Clear();
            tbJumlahOrang.Clear();
            tbNoMeja.Clear();
            dtReservasi.Value = DateTime.Now;
        }

        private void btClearR_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btPilihMenu_Click(object sender, EventArgs e)
        {
            if (dgvReservasi.SelectedRows.Count > 0)
            {
                int index = dgvReservasi.SelectedRows[0].Index;
                if (index >= 0 && index < daftarReservasi.Count)
                {
                    var reservasi = daftarReservasi[index];

                    var ucOrder = new UC_Order();
                    ucOrder.SetPelanggan(reservasi.NamaPelanggan);

                    Control parent = this.Parent;
                    if (parent != null)
                    {
                        parent.Controls.Clear();
                        parent.Controls.Add(ucOrder);
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih satu data reservasi terlebih dahulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UC_Reservasi_Load(object sender, EventArgs e)
        {
            TampilkanReservasi();
        }
    }
}
