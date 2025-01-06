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
            this.btnEliminarContaco = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(297, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(151, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Información de Contacto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(280, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(280, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(280, 162);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(99, 16);
            this.lblNombreGrupo.TabIndex = 3;
            this.lblNombreGrupo.Text = "Nombre Grupo:";
            // 
            // btnEliminarContaco
            // 
            this.btnEliminarContaco.Location = new System.Drawing.Point(261, 561);
            this.btnEliminarContaco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarContaco.Name = "btnEliminarContaco";
            this.btnEliminarContaco.Size = new System.Drawing.Size(139, 39);
            this.btnEliminarContaco.TabIndex = 11;
            this.btnEliminarContaco.Text = "Eliminar Contacto";
            this.btnEliminarContaco.UseVisualStyleBackColor = true;
            this.btnEliminarContaco.Click += new System.EventHandler(this.btnEliminarContaco_Click);
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(444, 561);
            this.btnModificarContacto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(139, 39);
            this.btnModificarContacto.TabIndex = 12;
            this.btnModificarContacto.Text = "Modificar Contacto";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.BackColor = System.Drawing.Color.Orange;
            this.txtNombreGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreGrupo.Location = new System.Drawing.Point(421, 159);
            this.txtNombreGrupo.Multiline = true;
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.ReadOnly = true;
            this.txtNombreGrupo.Size = new System.Drawing.Size(104, 22);
            this.txtNombreGrupo.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Orange;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(421, 118);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(257, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Orange;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Location = new System.Drawing.Point(421, 82);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(220, 22);
            this.txtNombre.TabIndex = 16;
            // 
            // FrmDatosContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificarContacto);
            this.Controls.Add(this.btnEliminarContaco);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnEliminarContaco;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
    }
}