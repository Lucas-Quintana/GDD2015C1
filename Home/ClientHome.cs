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
    public partial class ClientHome : Form
    {
        public ClientHome()
        {
            InitializeComponent();
        }

        private void misCuentasButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Home.MisCuentasHome frm = new Home.MisCuentasHome();
            frm.ShowDialog();
        }
    }
}
