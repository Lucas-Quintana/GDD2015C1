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
    public partial class MisCuentasHome : Form
    {
        public MisCuentasHome()
        {
            InitializeComponent();
        }

        private void MisCuentasHome_Load(object sender, EventArgs e)
        {
            //Variable global???
            int PKCLiente = 1;
            string consulta = "SELECT Cuen_Nro FROM TIMEWARP.CUENTAS WHERE Cuen_Cliente ='" + PKCLiente + "'";
            Query qr = new Query(consulta);
            DataTable table = (DataTable)qr.ObtenerDataTable();
            if (table.Rows.Count == 0) {
                cuentasComboBox.Enabled = false;
                MessageBox.Show("Usted no tiene cuentas en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                foreach (DataRow fila in table.Rows)
                {
                    cuentasComboBox.Items.Add(fila["Cuen_Nro"]);
                }
            }
        }
    }
}
