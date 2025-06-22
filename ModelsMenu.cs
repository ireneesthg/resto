using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto.Models
{
    public class ModelsMenu
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }

        //constructor dengan parameter
        public ModelsMenu(int id, string nama, int harga)
        {
            Id = id;
            Nama = nama;
            Harga = harga;
        }
    }
}
