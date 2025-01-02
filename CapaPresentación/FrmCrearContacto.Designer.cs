namespace CapaPresentación
{
    partial class FrmCrearContacto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBoxTelefonos = new System.Windows.Forms.ListBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAñadirTelefono = new System.Windows.Forms.Button();
            this.btnBorrarTelefono = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnCrearContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefonos Añadidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // lstBoxTelefonos
            // 
            this.lstBoxTelefonos.FormattingEnabled = true;
            this.lstBoxTelefonos.Location = new System.Drawing.Point(520, 192);
            this.lstBoxTelefonos.Name = "lstBoxTelefonos";
            this.lstBoxTelefonos.Size = new System.Drawing.Size(169, 95);
            this.lstBoxTelefonos.TabIndex = 4;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(114, 121);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(238, 21);
            this.cmbGrupo.TabIndex = 5;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(114, 78);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(226, 20);
            this.txtEmail.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // btnAñadirTelefono
            // 
            this.btnAñadirTelefono.Location = new System.Drawing.Point(165, 243);
            this.btnAñadirTelefono.Name = "btnAñadirTelefono";
            this.btnAñadirTelefono.Size = new System.Drawing.Size(100, 23);
            this.btnAñadirTelefono.TabIndex = 8;
            this.btnAñadirTelefono.Text = "Añadir Telefono";
            this.btnAñadirTelefono.UseVisualStyleBackColor = true;
            this.btnAñadirTelefono.Click += new System.EventHandler(this.btnAñadirTelefono_Click);
            // 
            // btnBorrarTelefono
            // 
            this.btnBorrarTelefono.Location = new System.Drawing.Point(555, 305);
            this.btnBorrarTelefono.Name = "btnBorrarTelefono";
            this.btnBorrarTelefono.Size = new System.Drawing.Size(100, 23);
            this.btnBorrarTelefono.TabIndex = 9;
            this.btnBorrarTelefono.Text = "Borrar Telefono";
            this.btnBorrarTelefono.UseVisualStyleBackColor = true;
            this.btnBorrarTelefono.Click += new System.EventHandler(this.btnBorrarTelefono_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Descripción";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(114, 173);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(238, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 205);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(238, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // btnCrearContacto
            // 
            this.btnCrearContacto.Location = new System.Drawing.Point(295, 358);
            this.btnCrearContacto.Name = "btnCrearContacto";
            this.btnCrearContacto.Size = new System.Drawing.Size(199, 45);
            this.btnCrearContacto.TabIndex = 14;
            this.btnCrearContacto.Text = "Crear Contacto";
            this.btnCrearContacto.UseVisualStyleBackColor = true;
            this.btnCrearContacto.Click += new System.EventHandler(this.btnCrearContacto_Click);
            // 
            // FrmCrearContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearContacto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBorrarTelefono);
            this.Controls.Add(this.btnAñadirTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.lstBoxTelefonos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCrearContacto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCrearContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBoxTelefonos;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAñadirTelefono;
        private System.Windows.Forms.Button btnBorrarTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnCrearContacto;
    }
}