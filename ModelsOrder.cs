using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto.Models
{
    public class ModelsOrder
    {
        public string NamaMenu { get; set; }
        public int Jumlah { get; set; }
        public int HargaSatuan { get; set; }
        public int Total => HargaSatuan * Jumlah;

        public ModelsOrder(string nama, int harga)
        {
            NamaMenu = nama;
            HargaSatuan = harga;
            Jumlah = 1;
        }
    }

}
