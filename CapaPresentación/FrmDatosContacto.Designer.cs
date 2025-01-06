namespace CapaPresentación
{
    partial class FrmDatosContacto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.lblTextNombre = new System.Windows.Forms.Label();
            this.lblTextEmail = new System.Windows.Forms.Label();
            this.lblTextNombreGrupo = new System.Windows.Forms.Label();
            this.btnEliminarContaco = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(223, 26);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Información de Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(210, 69);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(210, 98);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(210, 132);
            this.lblNombreGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(79, 13);
            this.lblNombreGrupo.TabIndex = 3;
            this.lblNombreGrupo.Text = "Nombre Grupo:";
            // 
            // lblTextNombre
            // 
            this.lblTextNombre.BackColor = System.Drawing.Color.Orange;
            this.lblTextNombre.Location = new System.Drawing.Point(322, 69);
            this.lblTextNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextNombre.Name = "lblTextNombre";
            this.lblTextNombre.Size = new System.Drawing.Size(167, 20);
            this.lblTextNombre.TabIndex = 6;
            this.lblTextNombre.Text = "label6";
            this.lblTextNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextEmail
            // 
            this.lblTextEmail.BackColor = System.Drawing.Color.Orange;
            this.lblTextEmail.Location = new System.Drawing.Point(322, 98);
            this.lblTextEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextEmail.Name = "lblTextEmail";
            this.lblTextEmail.Size = new System.Drawing.Size(194, 19);
            this.lblTextEmail.TabIndex = 7;
            this.lblTextEmail.Text = "label7";
            this.lblTextEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTextNombreGrupo
            // 
            this.lblTextNombreGrupo.BackColor = System.Drawing.Color.Orange;
            this.lblTextNombreGrupo.Location = new System.Drawing.Point(322, 132);
            this.lblTextNombreGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTextNombreGrupo.Name = "lblTextNombreGrupo";
            this.lblTextNombreGrupo.Size = new System.Drawing.Size(70, 19);
            this.lblTextNombreGrupo.TabIndex = 8;
            this.lblTextNombreGrupo.Text = "label8";
            this.lblTextNombreGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminarContaco
            // 
            this.btnEliminarContaco.Location = new System.Drawing.Point(196, 456);
            this.btnEliminarContaco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarContaco.Name = "btnEliminarContaco";
            this.btnEliminarContaco.Size = new System.Drawing.Size(104, 32);
            this.btnEliminarContaco.TabIndex = 11;
            this.btnEliminarContaco.Text = "Eliminar Contacto";
            this.btnEliminarContaco.UseVisualStyleBackColor = true;
            this.btnEliminarContaco.Click += new System.EventHandler(this.btnEliminarContaco_Click);
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(333, 456);
            this.btnModificarContacto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(104, 32);
            this.btnModificarContacto.TabIndex = 12;
            this.btnModificarContacto.Text = "Modificar Contacto";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // FrmDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 505);
            this.Controls.Add(this.btnModificarContacto);
            this.Controls.Add(this.btnEliminarContaco);
            this.Controls.Add(this.lblTextNombreGrupo);
            this.Controls.Add(this.lblTextEmail);
            this.Controls.Add(this.lblTextNombre);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDatosContacto";
            this.Text = "FrmDatosContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.Label lblTextNombre;
        private System.Windows.Forms.Label lblTextEmail;
        private System.Windows.Forms.Label lblTextNombreGrupo;
        private System.Windows.Forms.Button btnEliminarContaco;
        private System.Windows.Forms.Button btnModificarContacto;
    }
}