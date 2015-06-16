namespace PagoElectronico.ABM_Cliente
{
    partial class ABMClienteBajaMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.labellll = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dataResultado = new System.Windows.Forms.DataGridView();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.txtNumeroDoc = new System.Windows.Forms.TextBox();
            this.bnDarDeBaja = new System.Windows.Forms.Button();
            this.bnHabilitar = new System.Windows.Forms.Button();
            this.bnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº de Doc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Doc";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(86, 34);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(306, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(86, 61);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(50, 21);
            this.comboBoxTipoDoc.TabIndex = 13;
            this.comboBoxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDoc_SelectedIndexChanged);
            // 
            // labellll
            // 
            this.labellll.AutoSize = true;
            this.labellll.Location = new System.Drawing.Point(12, 90);
            this.labellll.Name = "labellll";
            this.labellll.Size = new System.Drawing.Size(32, 13);
            this.labellll.TabIndex = 16;
            this.labellll.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(86, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(306, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // dataResultado
            // 
            this.dataResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResultado.Location = new System.Drawing.Point(12, 133);
            this.dataResultado.Name = "dataResultado";
            this.dataResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataResultado.Size = new System.Drawing.Size(543, 150);
            this.dataResultado.TabIndex = 18;
            this.dataResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResultado_CellContentClick);
            // 
            // bnBuscar
            // 
            this.bnBuscar.Location = new System.Drawing.Point(411, 348);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(75, 23);
            this.bnBuscar.TabIndex = 19;
            this.bnBuscar.Text = "Buscar";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.Location = new System.Drawing.Point(203, 60);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.Size = new System.Drawing.Size(189, 20);
            this.txtNumeroDoc.TabIndex = 14;
            this.txtNumeroDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroDoc_KeyPress);
            // 
            // bnDarDeBaja
            // 
            this.bnDarDeBaja.Location = new System.Drawing.Point(203, 348);
            this.bnDarDeBaja.Name = "bnDarDeBaja";
            this.bnDarDeBaja.Size = new System.Drawing.Size(75, 23);
            this.bnDarDeBaja.TabIndex = 21;
            this.bnDarDeBaja.Text = "Dar de baja";
            this.bnDarDeBaja.UseVisualStyleBackColor = true;
            this.bnDarDeBaja.Click += new System.EventHandler(this.bnDarDeBaja_Click);
            // 
            // bnHabilitar
            // 
            this.bnHabilitar.Location = new System.Drawing.Point(113, 348);
            this.bnHabilitar.Name = "bnHabilitar";
            this.bnHabilitar.Size = new System.Drawing.Size(75, 23);
            this.bnHabilitar.TabIndex = 22;
            this.bnHabilitar.Text = "Habilitar";
            this.bnHabilitar.UseVisualStyleBackColor = true;
            this.bnHabilitar.Click += new System.EventHandler(this.bnHabilitar_Click);
            // 
            // bnModificar
            // 
            this.bnModificar.Location = new System.Drawing.Point(303, 348);
            this.bnModificar.Name = "bnModificar";
            this.bnModificar.Size = new System.Drawing.Size(89, 23);
            this.bnModificar.TabIndex = 23;
            this.bnModificar.Text = "Modificar Datos";
            this.bnModificar.UseVisualStyleBackColor = true;
            this.bnModificar.Click += new System.EventHandler(this.bnModificar_Click_1);
            // 
            // ABMClienteBajaMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 423);
            this.Controls.Add(this.bnModificar);
            this.Controls.Add(this.bnHabilitar);
            this.Controls.Add(this.bnDarDeBaja);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.dataResultado);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labellll);
            this.Controls.Add(this.txtNumeroDoc);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ABMClienteBajaMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baja de Cliente";
            this.Load += new System.EventHandler(this.FrmbnCliente_Baja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.Label labellll;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dataResultado;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.TextBox txtNumeroDoc;
        private System.Windows.Forms.Button bnDarDeBaja;
        private System.Windows.Forms.Button bnHabilitar;
        private System.Windows.Forms.Button bnModificar;
    }
}