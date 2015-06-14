namespace PagoElectronico.Home
{
    partial class MultiRolHome
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
            this.adminButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(228, 265);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(98, 48);
            this.adminButton.TabIndex = 0;
            this.adminButton.Text = "Administrador";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.Location = new System.Drawing.Point(438, 265);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(98, 48);
            this.clientButton.TabIndex = 1;
            this.clientButton.Text = "Cliente";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija con que perfil ingresar";
            // 
            // MultiRolHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.adminButton);
            this.Name = "MultiRolHome";
            this.Text = "Pago Elecrónico - TIMEWARP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Label label1;
    }
}