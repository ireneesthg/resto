using Npgsql;
using resto.Models;
using System;
using System.Data;
using System.Windows.Forms;


namespace resto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!");
                return;
            }

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT \"Id\", \"Username\", \"Password\" FROM \"Users\" WHERE \"Username\" = @u AND \"Password\" = @p"; //new
                using var cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    ListUser.LoggedInUser = new User
                    {
                        Id = Convert.ToInt32(reader["Id"]), //new
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString()

                    };

                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau password salah!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

        }

        private void LbDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register regForm = new Register();
            regForm.ShowDialog(); //buka form Register sebagai modal
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Program.TestConnection(); //jalankan saat Form1 pertama kali muncul
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

}
