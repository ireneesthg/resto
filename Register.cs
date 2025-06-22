using Microsoft.VisualBasic.ApplicationServices;
using resto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace resto
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                //cek apakah username sudah digunakan
                string checkQuery = "SELECT COUNT(*) FROM \"Users\" WHERE \"Username\" = @u";
                using var checkCmd = new NpgsqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@u", username);
                long count = (long)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username sudah digunakan.");
                    return;
                }

                //insert user baru ke database
                string insertQuery = "INSERT INTO \"Users\" (\"Username\", \"Password\") VALUES (@u, @p)";
                using var insertCmd = new NpgsqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@u", username);
                insertCmd.Parameters.AddWithValue("@p", password);

                int rowsAffected = insertCmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Registrasi berhasil. Silakan login.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal registrasi. Coba lagi.");
                }
            }
        }

        private void btKembali_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            formLogin.Show();
            //tutup form saat ini
            this.Hide();
        }
    }
}
