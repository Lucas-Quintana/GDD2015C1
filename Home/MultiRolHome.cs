using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Home
{
    public partial class MultiRolHome : Form
    {
        public MultiRolHome()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home.ClientHome frm = new Home.ClientHome();
            frm.ShowDialog();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home.AdminHome frm = new Home.AdminHome();
            frm.ShowDialog();
        }

    }
}
