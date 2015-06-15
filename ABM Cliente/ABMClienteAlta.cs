using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using PagoElectronico.FuncionesGenerales;
using PagoElectronico.Login;

namespace PagoElectronico.ABM_Cliente{

    public partial class ABMClienteAlta : Form
    {
        
        SqlConnection conexion = new SqlConnection();
        
                
        public ABMClienteAlta()
                                             
        {
            InitializeComponent();
            conexion.ConnectionString = Settings.Default.CadenaDeConexion;
        }



        private void ABMClienteHome_Alta_Load(object sender, EventArgs e)
        {

            LlenarComboTipoDoc();

            cmbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;

            //CARGO Nacionalidad
            string sql = "SELECT DISTINCT Pais_Descripcion FROM TIMEWARP.PAISES";
            Query qry2 = new Query(sql);
            foreach (DataRow dataRow in qry2.ObtenerDataTable().AsEnumerable())
            {
                comboNacionalidad.Items.Add(dataRow[0]);
            }

            //CARGO Nacionalidad
            sql = "SELECT DISTINCT Pais_Descripcion FROM TIMEWARP.PAISES";
            qry2 = new Query(sql);
            foreach (DataRow dataRow in qry2.ObtenerDataTable().AsEnumerable())
            {
                comboLocalidad.Items.Add(dataRow[0]);
            } 

        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {

            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtPregunta.Text.Trim() == "" || txtRespuesta.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar todos los campos de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
                


            //Chequea que los datos no sean nulos
            if ((txtNombre.Text.Trim() != "") &&
                (txtApellido.Text.Trim() != "") &&
                (cmbTipoDoc.Text != "") &&
                (txtDocumento.Text.Trim() != "") &&
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
                // preguntar por USERNAME

                string sqlUSERNAME = "SELECT COUNT(1) FROM TIMEWARP.USUARIOS where Usua_Username='" + txtUsername.Text + "'";
                Query qryUSERNAME = new Query(sqlUSERNAME);
                int existeUSERNAME = (int)qryUSERNAME.ObtenerUnicoCampo();

                if (existeUSERNAME == 1)
                {
                    txtUsername.Text = null;
                    MessageBox.Show("Username existente. Ingrese otro Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // preguntar por DNI y TIPO

                string sql4 = "SELECT TDoc_Codigo FROM TIMEWARP.TIPOS_DOCUMENTO WHERE TDoc_Descripcion = '" + cmbTipoDoc.Text + "'";
                Query tipoDoc = new Query(sql4);
                int idTipoDoc = (int)tipoDoc.ObtenerUnicoCampo();

                string DNI = "SELECT COUNT(1) FROM TIMEWARP.ClIENTES where Clie_Doc_Nro = " + txtDocumento.Text + " AND Clie_Doc_Tipo = " + idTipoDoc; 
                Query qry = new Query(DNI);
                int existeDNI = (int)qry.ObtenerUnicoCampo();

                if (existeDNI == 1)
                {
                    txtDocumento.Text = null;
                    MessageBox.Show("DNI existente. Ingrese otro DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //preguntar por mail
                    string EMAIL = "SELECT COUNT(1) FROM TIMEWARP.CLIENTES WHERE  Clie_Mail = '" + txtMail.Text + "' ";
                    Query qry3 = new Query(EMAIL);
                    int existeEMAIL = (int)qry.ObtenerUnicoCampo();

                    if (existeEMAIL == 1)
                    {
                        txtMail.Text = null;
                        MessageBox.Show("EMAIL existente. Ingrese otro Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string sqlAGREGARUSER = "INSERT INTO TIMEWARP.USUARIOS (Usua_Username,Usua_Password,Usua_Create_Date,Usua_Ult_Mod_Date,Usua_Pregunta, Usua_Respuesta,Usua_Estado,Usua_Intentos_Fallidos) " +
                        "values ('" + txtUsername.Text + "','" + txtPassword.Text + "','" + System.DateTime.Now.ToShortDateString() + "','" + System.DateTime.Now.ToShortDateString() + "','" + txtPregunta.Text + "','" + txtRespuesta.Text + "',1,0)";

                        qry.pComando = sqlAGREGARUSER;

                        qry.Ejecutar();

                        int idUsuario=(int) (new Query("SELECT Usua_Codigo FROM TIMEWARP.USUARIOS WHERE Usua_Username='"+txtUsername.Text+"'").ObtenerUnicoCampo());

                        int idNacionalidad = (int)(new Query("SELECT Pais_Codigo FROM TIMEWARP.PAISES WHERE Pais_Descripcion = '" + comboNacionalidad.Text + "'").ObtenerUnicoCampo());
                        int idLocalidad = (int)(new Query("SELECT Pais_Codigo FROM TIMEWARP.PAISES WHERE Pais_Descripcion = '" + comboLocalidad.Text + "'").ObtenerUnicoCampo());

                        if (txtNumPiso.Text == "" && txtDpto.Text == "")
                        {
                            string sql2 = "INSERT INTO TIMEWARP.CLIENTES (Clie_Nombre,Clie_Apellido, Clie_Doc_Tipo, Clie_Doc_Nro, Clie_Mail, Clie_Dom_Calle, Clie_Dom_Nro, Clie_Dom_Pais, Clie_Fecha_Nacimiento, Clie_Nacionalidad,Clie_Usuario_Codigo) " +
                                      "  values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + idTipoDoc + "','" + txtDocumento.Text + "','" + txtMail.Text + "','" + txtDireccion.Text + "','" + txtNro_Calle.Text + "','" + idLocalidad + "','" + txtFecha.Value.ToShortDateString() + "','" + idNacionalidad + "','"+idUsuario+"')";

                            qry.pComando = sql2;
                            qry.Ejecutar();

                        }
                        else
                        {
                            string sql2 = "INSERT INTO TIMEWARP.CLIENTES (Clie_Nombre, Clie_Apellido, Clie_Doc_Tipo, Clie_Doc_Nro, Clie_Mail, Clie_Dom_Calle, Clie_Dom_Nro, Clie_Dom_Piso, Clie_Dom_Depto, Clie_Dom_Pais, Clie_Fecha_Nacimiento, Clie_Nacionalidad,Clie_Usuario_Codigo) " +
                                          "  values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + idTipoDoc + "','" + txtDocumento.Text + "','" + txtMail.Text + "','" + txtDireccion.Text + "','" + txtNro_Calle.Text + "','" + txtNumPiso.Text + "','" + txtDpto.Text + "','" + idLocalidad + "','" + txtFecha.Value.ToShortDateString() + "','" + idNacionalidad + "','" + idUsuario + "')";

                            qry.pComando = sql2;
                            qry.Ejecutar();
                        }



                        string sqlAGREGARrol = "INSERT INTO TIMEWARP.ROL_USUARIOS values ( (SELECT Rol_Codigo FROM TIMEWARP.ROLES where Rol_Descripcion='CLIENTE'),'"+idUsuario+"')";
                        qry.pComando = sqlAGREGARrol;
                        qry.Ejecutar();

                        MessageBox.Show("Cliente dado de alta exitosamente!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                

                    }
                
                }
            }            
            // Insertar todos los campos
            else
            {
                MessageBox.Show("Nombre, apellido, tipo documento, número y nacionalidad no pueden estar vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LlenarComboTipoDoc()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select TDoc_Codigo, TDoc_Descripcion from TIMEWARP.Tipos_Documento", conexion);
            da.Fill(ds, "TIMEWARP.Tipos_Documento");

            cmbTipoDoc.DataSource = ds.Tables[0].DefaultView;
            cmbTipoDoc.DisplayMember = "TDoc_Descripcion";
            cmbTipoDoc.ValueMember = "TDoc_Codigo";
            cmbTipoDoc.SelectedItem = null;

        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbTipoDoc.Text = "";
            txtDocumento.Text = "";
            txtMail.Text = "";
            txtDireccion.Text = "";
            txtNro_Calle.Text = "";
            lblpiso.Text = "";
            lblDepto.Text = "";
            comboLocalidad.Text = "";
            txtFecha.Text = null;
            comboNacionalidad.Text = "";
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

        private void bnVolver_Click(object sender, EventArgs e)
        {
           

        
        }

  

    }
}
