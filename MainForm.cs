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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace resto
{
    public partial class MainForm : Form
    {
        //encapsulation: hanya MainForm yang tahu dan mengatur UC ini
        private UC_Home ucHome;
        private UC_Menu ucMenu;
        private UC_Order ucOrder;
        private UC_MenuItem ucMenuItem;
        private UC_Reservasi ucReservasi;

        private string currentRole;

        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private void LoadHomePage()
        {
            panelContent.Controls.Clear();
            UC_Home home = new UC_Home();
            home.Dock = DockStyle.Fill;
            panelContent.Controls.Add(home);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            ShowUserControl(home);
            panelContent.Controls.Clear();
            panelContent.Controls.Add(home);
        }
        private void ShowUserControl(UserControl uc)
        {
            if (uc == null) return; //cegah error
            panelContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContent.Controls.Add(uc);
            if (uc is BaseUC baseUC)
            {
                baseUC.LoadData();
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideBar_Paint(object sender, PaintEventArgs e)
        {
            panelSideBar.Dock = DockStyle.Left;
            panelMain.Dock = DockStyle.Fill;
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            UC_Home home = new UC_Home();
            ShowUserControl(home);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            var uc = new UC_Menu(currentRole);
            ShowUserControl(uc);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            UC_Order order = new UC_Order();
            ShowUserControl(order);
        }

        private void btnReservasi_Click(object sender, EventArgs e)
        {
            UC_Reservasi reservasi = new UC_Reservasi();
            ShowUserControl(reservasi);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void btnHomepage_Click_1(object sender, EventArgs e)
        {

        }
    }
}
