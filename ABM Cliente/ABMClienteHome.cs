using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class ABMClienteHome : Form
    {
        public ABMClienteHome()
        {
            InitializeComponent();
        }

        private void ABMClienteHome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_Cliente.ABMClienteAlta frm = new ABM_Cliente.ABMClienteAlta();
            frm.ShowDialog();
        }

     
    }
}
