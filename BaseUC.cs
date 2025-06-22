using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto
{
    public class BaseUC : UserControl
    {
       public virtual void LoadData()
       {
                // Method virtual, bisa di-override untuk load data di masing-masing UC
       }
        
    }
}
