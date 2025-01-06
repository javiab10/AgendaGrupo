namespace CapaPresentación
{
    partial class FrmEditarTelefono
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
            this.lblNumeros = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cbxNumeros = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblContactos = new System.Windows.Forms.Label();
            this.cbxContactos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNumeros
            // 
            this.lblNumeros.AutoSize = true;
            this.lblNumeros.Location = new System.Drawing.Point(76, 108);
            this.lblNumeros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(49, 13);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Números";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(76, 171);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(76, 220);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // cbxNumeros
            // 
            this.cbxNumeros.FormattingEnabled = true;
            this.cbxNumeros.Location = new System.Drawing.Point(158, 102);
            this.cbxNumeros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxNumeros.Name = "cbxNumeros";
            this.cbxNumeros.Size = new System.Drawing.Size(92, 21);
            this.cbxNumeros.TabIndex = 3;
            this.cbxNumeros.SelectedIndexChanged += new System.EventHandler(this.cbxNumeros_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(149, 293);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(56, 19);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(158, 168);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(92, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(158, 220);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(171, 20);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Location = new System.Drawing.Point(78, 57);
            this.lblContactos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(55, 13);
            this.lblContactos.TabIndex = 7;
            this.lblContactos.Text = "Contactos";
            // 
            // cbxContactos
            // 
            this.cbxContactos.FormattingEnabled = true;
            this.cbxContactos.Location = new System.Drawing.Point(158, 50);
            this.cbxContactos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxContactos.Name = "cbxContactos";
            this.cbxContactos.Size = new System.Drawing.Size(92, 21);
            this.cbxContactos.TabIndex = 8;
            this.cbxContactos.SelectedIndexChanged += new System.EventHandler(this.cbxContactos_SelectedIndexChanged);
            // 
            // FrmEditarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.cbxContactos);
            this.Controls.Add(this.lblContactos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxNumeros);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNumeros);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmEditarTelefono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmEditarTelefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeros;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cbxNumeros;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblContactos;
        private System.Windows.Forms.ComboBox cbxContactos;
    }
}