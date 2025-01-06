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
            this.lblNumeros.Location = new System.Drawing.Point(101, 133);
            this.lblNumeros.Name = "lblNumeros";
            this.lblNumeros.Size = new System.Drawing.Size(62, 16);
            this.lblNumeros.TabIndex = 0;
            this.lblNumeros.Text = "Números";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(101, 210);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(101, 271);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción";
            // 
            // cbxNumeros
            // 
            this.cbxNumeros.FormattingEnabled = true;
            this.cbxNumeros.Location = new System.Drawing.Point(211, 125);
            this.cbxNumeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNumeros.Name = "cbxNumeros";
            this.cbxNumeros.Size = new System.Drawing.Size(121, 24);
            this.cbxNumeros.TabIndex = 3;
            this.cbxNumeros.SelectedIndexChanged += new System.EventHandler(this.cbxNumeros_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(199, 361);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(211, 207);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 22);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(211, 271);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(227, 22);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblContactos
            // 
            this.lblContactos.AutoSize = true;
            this.lblContactos.Location = new System.Drawing.Point(104, 70);
            this.lblContactos.Name = "lblContactos";
            this.lblContactos.Size = new System.Drawing.Size(67, 16);
            this.lblContactos.TabIndex = 7;
            this.lblContactos.Text = "Contactos";
            // 
            // cbxContactos
            // 
            this.cbxContactos.FormattingEnabled = true;
            this.cbxContactos.Location = new System.Drawing.Point(211, 61);
            this.cbxContactos.Name = "cbxContactos";
            this.cbxContactos.Size = new System.Drawing.Size(121, 24);
            this.cbxContactos.TabIndex = 8;
            this.cbxContactos.SelectedIndexChanged += new System.EventHandler(this.cbxContactos_SelectedIndexChanged);
            // 
            // FrmEditarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.cbxContactos);
            this.Controls.Add(this.lblContactos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbxNumeros);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNumeros);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEditarTelefono";
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