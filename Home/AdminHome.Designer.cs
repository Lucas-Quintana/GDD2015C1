﻿namespace PagoElectronico.Home
{
    partial class AdminHome
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
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ABM_ClienteButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 394);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(124, 30);
            this.button8.TabIndex = 29;
            this.button8.Text = "Listado estadistico";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 322);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 30);
            this.button7.TabIndex = 28;
            this.button7.Text = "Consultar Saldo";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 30);
            this.button6.TabIndex = 27;
            this.button6.Text = "Facturar costos";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 286);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 30);
            this.button5.TabIndex = 26;
            this.button5.Text = "ABM Cuenta";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 30);
            this.button4.TabIndex = 25;
            this.button4.Text = "ABM Rol";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ABM_ClienteButton
            // 
            this.ABM_ClienteButton.Location = new System.Drawing.Point(12, 183);
            this.ABM_ClienteButton.Name = "ABM_ClienteButton";
            this.ABM_ClienteButton.Size = new System.Drawing.Size(124, 26);
            this.ABM_ClienteButton.TabIndex = 24;
            this.ABM_ClienteButton.Text = "ABM Clientes";
            this.ABM_ClienteButton.UseVisualStyleBackColor = true;
            this.ABM_ClienteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 26);
            this.button2.TabIndex = 23;
            this.button2.Text = "ABM Tipo de Cuenta";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "ABM Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 30;
            this.label1.Text = "¡Bienvenido!";
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ABM_ClienteButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminHome";
            this.Text = "Pago Elecrónico - TIMEWARP";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ABM_ClienteButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}