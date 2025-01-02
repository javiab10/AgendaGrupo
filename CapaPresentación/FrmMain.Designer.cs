namespace CapaPresentación
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTelefonoAContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTeléfonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(58, 28);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(679, 37);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(62, 78);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 62;
            this.dgvContactos.Size = new System.Drawing.Size(676, 301);
            this.dgvContactos.TabIndex = 6;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(656, 401);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(66, 20);
            this.txtNumeroTelefono.TabIndex = 16;
            this.txtNumeroTelefono.Text = "611111111";
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Location = new System.Drawing.Point(478, 396);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(142, 33);
            this.btnContactosTelefono.TabIndex = 15;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(369, 401);
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
            this.btnTodosContactos.Click += new System.EventHandler(this.btnTodosContactos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarGrupoToolStripMenuItem,
            this.agregarContactoToolStripMenuItem,
            this.agregarTelefonoAContactoToolStripMenuItem,
            this.borrarTeléfonoToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // agregarGrupoToolStripMenuItem
            // 
            this.agregarGrupoToolStripMenuItem.Name = "agregarGrupoToolStripMenuItem";
            this.agregarGrupoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarGrupoToolStripMenuItem.Text = "Agregar Grupo";
            this.agregarGrupoToolStripMenuItem.Click += new System.EventHandler(this.agregarGrupoToolStripMenuItem_Click);
            // 
            // agregarContactoToolStripMenuItem
            // 
            this.agregarContactoToolStripMenuItem.Name = "agregarContactoToolStripMenuItem";
            this.agregarContactoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarContactoToolStripMenuItem.Text = "Agregar Contacto";
            this.agregarContactoToolStripMenuItem.Click += new System.EventHandler(this.agregarContactoToolStripMenuItem_Click);
            // 
            // agregarTelefonoAContactoToolStripMenuItem
            // 
            this.agregarTelefonoAContactoToolStripMenuItem.Name = "agregarTelefonoAContactoToolStripMenuItem";
            this.agregarTelefonoAContactoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarTelefonoAContactoToolStripMenuItem.Text = "Agregar Telefono A Contacto";
            this.agregarTelefonoAContactoToolStripMenuItem.Click += new System.EventHandler(this.agregarTelefonoAContactoToolStripMenuItem_Click);
            // 
            // borrarTeléfonoToolStripMenuItem
            // 
            this.borrarTeléfonoToolStripMenuItem.Name = "borrarTeléfonoToolStripMenuItem";
            this.borrarTeléfonoToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.borrarTeléfonoToolStripMenuItem.Text = "Borrar Teléfono";
            this.borrarTeléfonoToolStripMenuItem.Click += new System.EventHandler(this.borrarTeléfonoToolStripMenuItem_Click);
            // 
            // FrmMain
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTelefonoAContactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarTeléfonoToolStripMenuItem;
    }
}

