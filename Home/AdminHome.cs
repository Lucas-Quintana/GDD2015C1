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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }


        private void ABM_ClienteButton_Click(object sender, EventArgs e)
        {
            ABM_Cliente.ABMClienteHome frm = new ABM_Cliente.ABMClienteHome();
            frm.ShowDialog();
        }



        private void AdminHome_Load(object sender, EventArgs e)
        {

        }
    }
}
