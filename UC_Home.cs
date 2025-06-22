using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using resto.Models;
using Npgsql;


namespace resto
{
    public partial class UC_Home : BaseUC
    {
        public UC_Home()
        {
            InitializeComponent();
        }
       

        public override void LoadData()
        {
                
        }
 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Home_Load(object sender, EventArgs e)
        {
            if (ListUser.LoggedInUser != null)
            {
                lbWelcome.Text = $"Selamat datang, {ListUser.LoggedInUser.Username}!";
            }
            else
            {
                lbWelcome.Text = "Selamat datang!";
            }
        }

    }
}
