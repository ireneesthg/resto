using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto.Models
{
    class ModelsReservasi
    {
        public int Id { get; set; }
        public int NoMeja { get; set; }
        public string NamaPelanggan { get; set; }
        public string NoTelepon { get; set; }
        public int JumlahOrang { get; set; }
        public DateTime Tanggal { get; set; }
    }
}
