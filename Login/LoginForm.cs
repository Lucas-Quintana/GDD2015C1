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
            String usernameText = username.Text;
            String passwordText = password.Text;

            if ((usernameText == "") | (passwordText == ""))
            {
                MessageBox.Show("Los campos Username y Password son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                //Get user
                //Validate if  User exist
                if (true)
                {   
                    //Validate if enabled
                    // ((Usua_Estado > 1) | (Usua_Intentos >= 3))
                    if (true)
                    {
                        //Validate password
                        if (true)
                        {
                            //Intento =0
                            //Validate cant de roles
                            this.Visible = false;
                            if (true) 
                            {
                                Home.MultiRolHome frm = new Home.MultiRolHome();
                                frm.ShowDialog();
                            }
                            //Rol unico Admin
                            else if (false)
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
