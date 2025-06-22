using System;
using Npgsql;
using System.Windows.Forms;

namespace resto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Console.WriteLine("Tes koneksi ke PostgreSQL dan tampilkan isi tabel:");
            TestConnection();

            Application.Run(new Form1());
        }

        public static void TestConnection()
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Tools.Connections.ConnParamPostgreSQL()))
                {
                    conn.Open();
                    Console.WriteLine("Koneksi Sukses\n");


                    PrintTable(conn, "Users");
                    PrintTable(conn, "MenuItems");
                    PrintTable(conn, "Orders");
                    PrintTable(conn, "OrderItems");
                    PrintTable(conn, "Reservasi");
                    PrintTable(conn, "Transaksi");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Koneksi gagal: " + ex.Message);
            }
        }

        public static void PrintTable(NpgsqlConnection conn, string tableName)
        {
            try
            {
                string query = $"SELECT * FROM \"{tableName}\"";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine($"\n== Isi Tabel {tableName} ==");

                    if (!reader.HasRows)
                    {
                        Console.WriteLine("Tabel kosong.");
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write($"{reader.GetName(i)}: {reader[i]}\t");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Gagal baca tabel {tableName}: {ex.Message}");
            }
        }
    }
}
