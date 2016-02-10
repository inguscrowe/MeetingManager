using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeetingManager;

namespace MeetingManagerUI
{
    public partial class MainMenu : Form
    {
        ClassManager manager = new ClassManager();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage(this);
            lp.MdiParent = this;
            lp.WindowState = FormWindowState.Maximized;
            lp.Show();
        }

    }
}
