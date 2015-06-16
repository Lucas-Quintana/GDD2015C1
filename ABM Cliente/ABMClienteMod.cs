using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PagoElectronico.ABM_Cliente
{
    public partial class ABMClienteMod : Form
    {
        private int docNro;
        private int docTipo;
       
        SqlConnection conexion = new SqlConnection();
                
        public ABMClienteMod(int numDoc,int tipoDoc)
        {
            docNro = numDoc;
            docTipo = tipoDoc;
            InitializeComponent();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;
        }

        private void ABMClienteMod_Load(object sender, EventArgs e)
        {
            

          

            //CARGO Nacionalidad
            string sql = "SELECT Pais_Descripcion FROM TIMEWARP.PAISES";
            Query qry2 = new Query(sql);
            foreach (DataRow dataRow in qry2.ObtenerDataTable().AsEnumerable())
            {
                comboNacionalidad.Items.Add(dataRow[0]);
            }

            //CARGO Localidad
            sql = "SELECT Pais_Descripcion FROM TIMEWARP.PAISES";
            qry2 = new Query(sql);
            foreach (DataRow dataRow in qry2.ObtenerDataTable().AsEnumerable())
            {
                comboLocalidad.Items.Add(dataRow[0]);
            } 

            Query qry = new Query("select Clie_Nombre, Clie_Apellido, Clie_Mail, Clie_Dom_Calle, paisDom.Pais_Descripcion as LOCALIDAD, Clie_Dom_Nro,Clie_Dom_Piso, Clie_Dom_Depto, n.Pais_Descripcion as NACIONALIDAD "+
                                  "from TIMEWARP.CLIENTES C LEFT JOIN TIMEWARP.PAISES paisDom ON  C.Clie_Dom_Pais = paisDom.Pais_Codigo "+
                                  "INNER JOIN TIMEWARP.PAISES n ON C.Clie_Nacionalidad = n.Pais_Codigo "+
                                  "INNER JOIN TIMEWARP.TIPOS_DOCUMENTO td ON C.Clie_Doc_Tipo = td.TDoc_Codigo WHERE Clie_Doc_Nro = " + docNro);

            foreach (DataRow dataRow in qry.ObtenerDataTable().AsEnumerable())
            {

                txtNombre.Text = dataRow[0].ToString();
                txtApellido.Text = dataRow[1].ToString();
                txtMail.Text = dataRow[2].ToString();
                txtDireccion.Text = dataRow[3].ToString();
                comboLocalidad.Text = dataRow[4].ToString();
                txtNumCalle.Text = dataRow[5].ToString();
                txtNumPiso.Text = dataRow[6].ToString();
                txtDpto.Text = dataRow[7].ToString();
                comboNacionalidad.Text = dataRow[8].ToString();
            }
        }






        private void bnGuardar_Click(object sender, EventArgs e)
        {
            //Chequea que los datos no sean nulos
            if ((txtNombre.Text.Trim() != "") &&
                (txtApellido.Text.Trim() != "") &&
                (txtMail.Text.Trim() != "") &&
                (comboLocalidad.Text.Trim() != "") &&
                (txtDireccion.Text.Trim() != "") &&
                (comboNacionalidad.Text.Trim() != ""))
            {

                if (txtNumPiso.Text != "" || txtDpto.Text != "")
                {
                    if (txtNumPiso.Text == "" || txtDpto.Text == "")
                    {
                        MessageBox.Show("No puede llenar el piso sin dpto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                

                

           
                    //preguntar por mail
                    string EMAIL = "SELECT COUNT(1) FROM TIMEWARP.CLIENTES WHERE  Clie_Mail = '" + txtMail.Text + "' and Clie_Doc_Nro <>'" + docNro+"' and Clie_Doc_Tipo <>'"+docTipo+"'" ;
                    Query qry3 = new Query(EMAIL);
                    int existeEMAIL = (int)qry3.ObtenerUnicoCampo();

                    if (existeEMAIL == 1)
                    {
                        txtMail.Text = null;
                        MessageBox.Show("EMAIL existente. Ingrese otro Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Query qry = new Query();
                        int idNacionalidad = (int)(new Query("SELECT Pais_Codigo FROM TIMEWARP.Paises WHERE Pais_Descripcion = '"+ comboNacionalidad.Text +"'").ObtenerUnicoCampo());
                        int idLocalidad = (int)(new Query("SELECT Pais_Codigo FROM TIMEWARP.Paises WHERE Pais_Descripcion = '" + comboLocalidad.Text + "'").ObtenerUnicoCampo());

                        if (txtNumPiso.Text == "" && txtDpto.Text == "")
                        {
                            string sql2 = "UPDATE TIMEWARP.CLIENTES SET Clie_Nombre = '" + txtNombre.Text + "', Clie_Apellido = '" + txtApellido.Text +   "', Clie_Mail = '" + txtMail.Text + "', Clie_Dom_Calle = '" + txtDireccion.Text + "', Clie_Dom_Pais = '" + idLocalidad + "',Clie_Fecha_Nacimiento = '" + txtFecha.Value.ToShortDateString() +  "', Clie_Nacionalidad = '" + idNacionalidad + "' WHERE Clie_Doc_Nro = '" + docNro +"' and Clie_Doc_Tipo='"+ docTipo+"'";

                            qry.pComando = sql2;
                            qry.Ejecutar();

                        }
                        else
                        {
                            string sql2 = "UPDATE TIMEWARP.CLIENTES SET Clie_Nombre = '" + txtNombre.Text + "', Clie_Apellido = '" + txtApellido.Text + "', Clie_Mail = '" + txtMail.Text + "', Clie_Dom_Calle = '" + txtDireccion.Text +  "', Clie_Dom_Piso =' " + txtNumPiso.Text + " ', Clie_Dom_Depto = '" + txtDpto.Text + "', Clie_Dom_Pais = '" + idLocalidad + "',Clie_Fecha_Nacimiento = '" + txtFecha.Value.ToShortDateString() + "', Clie_Nacionalidad = '" + idNacionalidad + "' WHERE Clie_Doc_Nro = '" + docNro + "' and Clie_Doc_Tipo='" + docTipo + "'";

                            qry.pComando = sql2;
                            qry.Ejecutar();
                        }

                        MessageBox.Show("Cliente Modificado Correctamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      
                    }
                }
            
            else
            {
                MessageBox.Show("Completar datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
           
       

  

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtNumPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtNro_Calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

      
    }
}
