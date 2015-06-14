namespace PagoElectronico.Home
{
    partial class ClientHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.misCuentasButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "¡Bienvenido!";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 324);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "Facturar costos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "Retirar efectivo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 26);
            this.button3.TabIndex = 16;
            this.button3.Text = "Depositos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "Transferencias";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // misCuentasButton
            // 
            this.misCuentasButton.Location = new System.Drawing.Point(12, 184);
            this.misCuentasButton.Name = "misCuentasButton";
            this.misCuentasButton.Size = new System.Drawing.Size(105, 30);
            this.misCuentasButton.TabIndex = 14;
            this.misCuentasButton.Text = "Mis Cuentas";
            this.misCuentasButton.UseVisualStyleBackColor = true;
            this.misCuentasButton.Click += new System.EventHandler(this.misCuentasButton_Click);
            // 
            // ClientHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.misCuentasButton);
            this.Controls.Add(this.label1);
            this.Name = "ClientHome";
            this.Text = "Pago Elecrónico - TIMEWARP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button misCuentasButton;
    }
}