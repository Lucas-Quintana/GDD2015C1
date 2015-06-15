using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PagoElectronico.Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            string usernameText = username.Text;
            string passwordText = password.Text;

            if ((usernameText == "") | (passwordText == ""))
            {
                MessageBox.Show("Los campos Username y Password son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                //Get user
                string consulta = "SELECT top 1 Usua_Codigo Usua_Password, Usua_Estado, Usua_Intentos FROM TIMEWARP.USUARIOS WHERE Usua_Username = " + usernameText;
                Query qr = new Query(consulta);
                DataTable table = (DataTable)qr.ObtenerDataTable();
                int cant = table.Rows.Count;
                //Validate if  User exist
                if (cant > 0)
                {   
                    //Validate if enabled
                    // ((Usua_Estado < 1) | (Usua_Intentos >= 3))
                    DataRow user = table.Rows[0];
                    int estado = (int) user["Usua_Estado"];
                    int intentos = (int) user["Usua_Intentos"];
                    if ((estado < 1) | (intentos >= 0))
                    {
                        //Validate password
                        string password_db = (string)user["Usua_Password"];
                        if (password_db == passwordText)
                        {
                            //Intento =0 UPDATE ???
                            //Validate cant de roles
                            string codigo = (string)user["Usua_Codigo"];
                            string consulta2 = "SELECT UxR_Rol, Rol_Descripcion FROM TIMEWARP.ROLES, TIMEWARP.ROL_USUARIOS WHERE UxR_Usuario = " + codigo + "UxR_Rol = Rol_Codigo";
                            Query qr2 = new Query(consulta);
                            DataTable tableRoles = (DataTable)qr2.ObtenerDataTable();
                            this.Visible = false;
                            if (table.Rows.Count > 1) 
                            {
                                Home.MultiRolHome frm = new Home.MultiRolHome();
                                frm.ShowDialog();
                            }
                            else
                            {
                                DataRow rolRow = tableRoles.Rows[0];
                                string rol = (string)rolRow["Rol_Descripcion"];
                                //Rol unico Admin
                                if (rol == "ADMINISTRADOR")
                                {
                                    Home.AdminHome frm = new Home.AdminHome();
                                    frm.ShowDialog();
                                }
                                //Rol unico Cliente
                                else
                                {
                                    Home.ClientHome frm = new Home.ClientHome();
                                    frm.ShowDialog();
                                }
                            }
                        }
                        else
                        {
                            //Intentos +1
                            MessageBox.Show("Password incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario ingresado se encuentra inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT top 1 Clie_Doc_Nro FROM TIMEWARP.CLIENTES";
            Query qr = new Query(consulta);
            qr.pComando = consulta;
            int? codigo = (int)qr.ObtenerUnicoCampo();
            if (codigo == null)
                label4.Text = " no anda ";
            else
                label4.Text = " si anda " + codigo;
        }

       

    }
}
