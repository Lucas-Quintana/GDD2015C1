using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using PagoElectronico.Abm_Cliente;

namespace PagoElectronico.ABM_Cliente
{
    public partial class ABMClienteBajaMod : Form
    {
       

        public ABMClienteBajaMod()
        {
            InitializeComponent();

            
        }

   

        private string qr;
        private int IdTipoDni;
     


        private void bnBuscar_Click(object sender, EventArgs e)
        { 
            //CHEQUEA QUE TODOS LOS CAMPOS NO SEAN VACIOS

            if (!CamposVacios())
            {

                string sql = "SELECT Clie_Doc_Tipo,Clie_Nombre as 'Nombre', Clie_Apellido as 'Apellido' , Clie_Mail as 'Mail', Clie_Doc_Nro as 'Documento',(SELECT TDoc_Descripcion from TIMEWARP.TIPOS_DOCUMENTO where Clie_Doc_Tipo=TDoc_Codigo) as 'Tipo de Documento'  FROM TIMEWARP.CLIENTES WHERE";

                if (txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text == "" ||
                    txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text == "" ||
                    txtNombre.Text == "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                    txtNombre.Text == "" && txtApellido.Text == "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "")
                {

                    //buscar por un campo
                    qr = buscarPorUnCampo(sql);

                }
                else
                {
                    //BUSCAR POR DOS CAMPOS

                    if (txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text == "" ||
                        txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                        txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "" ||
                        txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                        txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "" ||
                        txtNombre.Text == "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text != "" )
                    {

                        qr = buscarPorDosCampos(sql);
                    }
                    else
                    {
                        //BUSCAR POR TRES CAMPOS

                        if (txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" ||
                            txtNombre.Text != "" && txtApellido.Text == "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text != "" ||
                            txtNombre.Text != "" && txtApellido.Text != "" && comboBoxTipoDoc.Text == "" && txtNumeroDoc.Text == "" && txtEmail.Text != "" ||
                            txtNombre.Text == "" && txtApellido.Text != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text != "" && txtEmail.Text == "" )
                        {

                            qr = buscarPorTresCampos(sql);
                        }
                            else
                            {
                                qr = buscarPorTodosLosCampos(sql);
                                
                            }
                    }
                }

                mostrarResultadoDataGrid(qr);

            }
            else
            {
                //TIRA ERROR SI TODOS LOS CAMPOS SON VACIOS

                MessageBox.Show("Todos los datos no pueden ser nulos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private bool CamposVacios()
        {
            return (txtNombre.Text.Trim() == "" && txtApellido.Text.Trim() == "" && comboBoxTipoDoc.Text == ""
                    && txtNumeroDoc.Text.Trim() == "" && txtEmail.Text.Trim() == "");
        }

        private string buscarPorUnCampo(string sql)
        {
            if (txtNombre.Text.Trim() != "")
            {
                sql = sql + " Clie_Nombre LIKE '%" + txtNombre.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "")
            {
                sql = sql + " Clie_Apellido LIKE '%" + txtApellido.Text + "%' ";
            }

            if (txtEmail.Text.Trim() != "")
            {
                sql = sql + " Clie_Mail LIKE '%" + txtEmail.Text + "%'";
            }

            if (txtNumeroDoc.Text.Trim() != "" && comboBoxTipoDoc.Text != "")
            {
                sql = sql + " Clie_Doc_Nro LIKE '%" + txtNumeroDoc.Text + "%'";
            }

            return sql;
        }


        private string buscarPorDosCampos(string sql)
        {
            if (txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "")
            {
                //NOMBRE Y APELLIDO
                sql = sql + " Clie_Nombre LIKE '%" + txtNombre.Text + "%' AND Clie_Apellido LIKE '%" + txtApellido.Text + "%' ";
            }

            if (txtNombre.Text.Trim() != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "" )
            {
                //NOMBRE Y DOCUMENTO
                sql = sql + " Clie_Nombre LIKE '%" + txtNombre.Text + "%' AND Clie_Doc_Tipo = " + IdTipoDni + " AND Clie_Doc_Nro LIKE '%" + txtNumeroDoc.Text + "%' ";
            }

            if (txtNombre.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //NOMBRE Y MAIL
                sql = sql + " Clie_Mail LIKE '%" + txtEmail.Text + "%' AND Clie_Nombre LIKE '%" + txtNombre.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "" && comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "")
            {
                //APELLIDO Y DNI
                sql = sql + " Clie_Apellido LIKE '%" + txtApellido.Text + "%' AND Clie_Doc_Tipo = " + IdTipoDni + " AND Clie_Doc_Nro LIKE '%" + txtNumeroDoc.Text + "%' ";
            }

            if (txtApellido.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //APELLIDO Y MAIL
                sql = sql + " Clie_Apellido LIKE '%" + txtApellido.Text + "%' AND Clie_Mail LIKE '%" + txtEmail.Text + "%'";
            }

            if (comboBoxTipoDoc.Text != "" && txtNumeroDoc.Text.Trim() != "" && txtEmail.Text.Trim() != "")
            {
                //DNI Y MAIL
                sql = sql + "Clie_Doc_Tipo = " + IdTipoDni + " AND Clie_Doc_Nro LIKE '%" + txtNumeroDoc.Text + "%' AND Clie_Mail LIKE '%" + txtEmail.Text + "%'";
            }

            return sql;

        }


        private string buscarPorTresCampos(string sql)
        {
            if (txtEmail.Text.Trim() == "")
            {
                //BUSCA POR NOMBRE APELLIDO Y DNI
                sql = sql + " Clie_Nombre LIKE '%" + txtNombre.Text + "%' AND Clie_Apellido LIKE '%" + txtApellido.Text + "%' AND Clie_Doc_Tipo = "+ IdTipoDni +" AND Clie_Doc_Nro LIKE '%" + txtNumeroDoc.Text + "%'";

            }

            if (txtNumeroDoc.Text.Trim() == "")
            {
                //BUSCA POR NOMBRE APELLIDO Y EMAIL
                sql = sql + " Clie_Nombre LIKE '%" + txtNombre.Text + "%' AND Clie_Apellido LIKE '%" + txtApellido.Text + "%' AND Clie_Mail LIKE '%" + txtEmail.Text + "%'";

            }

            if (txtNombre.Text.Trim() == "")
            {
                //BUSCA POR APELLIDO DNI Y EMAIL
                sql = sql + " Clie_Mail LIKE '%" + txtEmail.Text + "%' AND Clie_Apellido LIKE '%" + txtApellido.Text + "%' AND Clie_Doc_Tipo = " + IdTipoDni + " AND Clie_Doc_Nro LIKE '%" + txtNumeroDoc.Text + "%'";
            }

            return sql;
        }

        
        private void mostrarResultadoDataGrid(string qr)
        {
            Query resultado = new Query(qr);
            dataResultado.DataSource = resultado.ObtenerDataTable();
             dataResultado.Columns["Clie_Doc_Tipo"].Visible = false;  //OCULTO LA COLUMNA
            dataResultado.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void FrmbnCliente_Baja_Load(object sender, EventArgs e)
        {
            comboBoxTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;

/*
            //OCULTO BOTONES
            this.bnHabilitar.Visible = false;
            this.bnModificar.Visible = false;
            this.bnDarDeBaja.Visible = false;
            this.bnSeleccionar.Visible = false;

            //BLOQUEO BOTONES
            this.bnDarDeBaja.Enabled = false;
            this.bnHabilitar.Enabled = false;
            this.bnModificar.Enabled = false;
            this.bnSeleccionar.Enabled = false;

            //SI ES 1 ES BAJA, SI ES 2 ES LISTADO, SI ES 3 ES MODIFICACION */
      
            
            
            
            //CARGAR COMBOBOX
            string sql = "SELECT TDoc_Descripcion FROM TIMEWARP.TIPOS_DOCUMENTO";


            Query qry = new Query(sql);


            foreach (DataRow dataRow in qry.ObtenerDataTable().AsEnumerable())
            {
                comboBoxTipoDoc.Items.Add(dataRow[0]);
            }
        }

        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query qr = new Query("SELECT TDoc_Codigo FROM TIMEWARP.TIPOS_DOCUMENTO WHERE TDoc_Descripcion = '" + comboBoxTipoDoc.Text + "'");
            IdTipoDni = Convert.ToInt32(qr.ObtenerUnicoCampo());
        }

        private string buscarPorTodosLosCampos(string sql)
        {
            sql = sql + " Clie_Mail LIKE '%" + txtEmail.Text + "%' AND Clie_Apellido LIKE '%" + txtApellido.Text + "%' AND Clie_Doc_Tipo = " + IdTipoDni + " AND Clie_Doc_Nro LIKE '%" + txtNumeroDoc.Text + "%' AND Clie_Nombre LIKE '%" + txtNombre.Text + "%' ";
            return sql;
        }

        private void bnDarDeBaja_Click(object sender, EventArgs e)
        {

            int nroDoc = this.docNroUsuarioSeleccionado();
            int tipoDoc = this.docTipoUsuarioSeleccionado();

 
            if (!clienteYaEstaInhabilitado(nroDoc,tipoDoc))
            {
                //DAR DE BAJA CLIENTE
                new Query("UPDATE TIMEWARP.USUARIOS  SET Usua_Estado = 0 WHERE Usua_Codigo=(SELECT Clie_Usuario_Codigo FROM TIMEWARP.CLIENTES WHERE Clie_Doc_Nro='" + nroDoc + "' AND Clie_Doc_Tipo = '" + tipoDoc + "')").Ejecutar();
                MessageBox.Show("El cliente se ha dado de baja." , "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion." + Environment.NewLine + "El cliente ya se encuentra inhabilitado", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
            
        }

        private void dataResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.bnDarDeBaja.Enabled = true;
            this.bnHabilitar.Enabled = true;
            this.bnModificar.Enabled = true;
            
        }


        private void bnHabilitar_Click(object sender, EventArgs e)
        {
            int nroDoc = this.docNroUsuarioSeleccionado();
            int tipoDoc = this.docTipoUsuarioSeleccionado();

            if (clienteYaEstaInhabilitado(nroDoc,tipoDoc))
            {
                new Query("UPDATE TIMEWARP.USUARIOS  SET Usua_Estado = 1 WHERE Usua_Codigo=(SELECT Clie_Usuario_Codigo FROM TIMEWARP.CLIENTES WHERE Clie_Doc_Nro='" + nroDoc + "' AND Clie_Doc_Tipo = '" + tipoDoc + "')").Ejecutar();
                MessageBox.Show("El cliente se ha dado de alta.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo realizar la operacion." + Environment.NewLine + "El cliente ya se encuentra habilitado", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private int docNroUsuarioSeleccionado()
        {
            DataGridViewRow fila = dataResultado.SelectedRows[0];

            
            return Convert.ToInt32(fila.Cells["Documento"].Value.ToString());
            
        }

        private int docTipoUsuarioSeleccionado()
        {
            DataGridViewRow fila = dataResultado.SelectedRows[0];


            return Convert.ToInt32(fila.Cells["Clie_Doc_Tipo"].Value.ToString());

        }

  

        private bool clienteYaEstaInhabilitado(int nroDoc,int tipoDoc)
        {
            return Convert.ToInt32(new Query("SELECT Usua_Estado FROM TIMEWARP.USUARIOS join TIMEWARP.CLIENTES on "+
            "Usua_Codigo=Clie_Usuario_Codigo where Clie_Doc_Nro='"+nroDoc +"' AND Clie_Doc_Tipo = '" + tipoDoc+"'" ).ObtenerUnicoCampo()) == 0;
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void bnModificar_Click_1(object sender, EventArgs e)
        {
            int nroDoc = this.docNroUsuarioSeleccionado();
            int tipoDoc = this.docTipoUsuarioSeleccionado();

            ABM_Cliente.ABMClienteMod modificar = new ABM_Cliente.ABMClienteMod(nroDoc, tipoDoc);
            modificar.ShowDialog();
            // modificar = (ABMClienteMod)this.ActiveMdiChild;
        }

 
    }
}
