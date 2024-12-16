namespace CapaPresentación
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.btnContactosTelefono = new System.Windows.Forms.Button();
            this.txtIdContacto = new System.Windows.Forms.TextBox();
            this.btnTelefonosContacto = new System.Windows.Forms.Button();
            this.btnTodosContactos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(58, 28);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(679, 38);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(61, 78);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.Size = new System.Drawing.Size(676, 301);
            this.dgvContactos.TabIndex = 6;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(656, 402);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(65, 20);
            this.txtNumeroTelefono.TabIndex = 16;
            this.txtNumeroTelefono.Text = "611111111";
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Location = new System.Drawing.Point(478, 396);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(143, 33);
            this.btnContactosTelefono.TabIndex = 15;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(369, 402);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(42, 20);
            this.txtIdContacto.TabIndex = 14;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdContacto.TextChanged += new System.EventHandler(this.txtIdContacto_TextChanged);
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Location = new System.Drawing.Point(213, 394);
            this.btnTelefonosContacto.Name = "btnTelefonosContacto";
            this.btnTelefonosContacto.Size = new System.Drawing.Size(138, 37);
            this.btnTelefonosContacto.TabIndex = 13;
            this.btnTelefonosContacto.Text = "Teléfonos de contacto";
            this.btnTelefonosContacto.UseVisualStyleBackColor = true;
            this.btnTelefonosContacto.Click += new System.EventHandler(this.btnTelefonosContacto_Click);
            // 
            // btnTodosContactos
            // 
            this.btnTodosContactos.Location = new System.Drawing.Point(75, 395);
            this.btnTodosContactos.Name = "btnTodosContactos";
            this.btnTodosContactos.Size = new System.Drawing.Size(120, 33);
            this.btnTodosContactos.TabIndex = 17;
            this.btnTodosContactos.Text = "Todos los contactos";
            this.btnTodosContactos.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTodosContactos);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.btnContactosTelefono);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.btnTelefonosContacto);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.lblMensaje);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Button btnContactosTelefono;
        private System.Windows.Forms.TextBox txtIdContacto;
        private System.Windows.Forms.Button btnTelefonosContacto;
        private System.Windows.Forms.Button btnTodosContactos;
    }
}

