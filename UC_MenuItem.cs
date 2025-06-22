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
    public partial class UC_MenuItem : BaseUC
    {
        private List<ModelsMenu> menu;
        public event Action<string, int> TambahkanPesanan;

        public UC_MenuItem(List<ModelsMenu> menu)
        {
            InitializeComponent();
            if (menu == null || menu.Count != 3)
                throw new ArgumentException("Menus harus berisi tepat 3 item.");

            this.menu = menu;

            //isi tiap menu ke UI
            lbPaket1.Text = menu[0].Nama;
            lbHarga1.Text = "Rp " + menu[0].Harga.ToString("N0");
            //pbPaket1.Image = menu[0].Gambar;

            lbPaket2.Text = menu[1].Nama;
            lbHarga2.Text = "Rp " + menu[1].Harga.ToString("N0");
            //pbPaket2.Image = menu[1].Gambar;

            lbPaket3.Text = menu[2].Nama;
            lbHarga3.Text = "Rp " + menu[2].Harga.ToString("N0");
            //pbPaket3.Image = menu[2].Gambar;

            //event klik tiap paket
            pbPaket1.Click += (s, e) => TambahkanPesanan?.Invoke(menu[0].Nama, menu[0].Harga);//, menu[0].Gambar);
            pbPaket2.Click += (s, e) => TambahkanPesanan?.Invoke(menu[1].Nama, menu[1].Harga);//, menu[1].Gambar);
            pbPaket3.Click += (s, e) => TambahkanPesanan?.Invoke(menu[2].Nama, menu[2].Harga);//, menu[2].Gambar);

        }

    }
}
