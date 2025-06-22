using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto
{
    public class dashboard
    {
        public string WelcomeMessage { get; set; }
        public dashboard(string username)
        {
            WelcomeMessage = $"Halo {username}, ini halaman Dashboard!";
        }
    }
}
