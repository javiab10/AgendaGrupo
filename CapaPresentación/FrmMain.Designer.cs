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
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(87, 43);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(1018, 58);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(92, 120);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 62;
            this.dgvContactos.Size = new System.Drawing.Size(1014, 463);
            this.dgvContactos.TabIndex = 6;
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(984, 618);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroTelefono.MaxLength = 9;
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(96, 26);
            this.txtNumeroTelefono.TabIndex = 16;
            this.txtNumeroTelefono.Text = "611111111";
            // 
            // btnContactosTelefono
            // 
            this.btnContactosTelefono.Location = new System.Drawing.Point(717, 609);
            this.btnContactosTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContactosTelefono.Name = "btnContactosTelefono";
            this.btnContactosTelefono.Size = new System.Drawing.Size(214, 51);
            this.btnContactosTelefono.TabIndex = 15;
            this.btnContactosTelefono.Text = "Contactos de un teléfono";
            this.btnContactosTelefono.UseVisualStyleBackColor = true;
            // 
            // txtIdContacto
            // 
            this.txtIdContacto.Location = new System.Drawing.Point(554, 618);
            this.txtIdContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdContacto.Name = "txtIdContacto";
            this.txtIdContacto.Size = new System.Drawing.Size(61, 26);
            this.txtIdContacto.TabIndex = 14;
            this.txtIdContacto.Text = "14";
            this.txtIdContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIdContacto.TextChanged += new System.EventHandler(this.txtIdContacto_TextChanged);
            // 
            // btnTelefonosContacto
            // 
            this.btnTelefonosContacto.Location = new System.Drawing.Point(320, 606);
            this.btnTelefonosContacto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTelefonosContacto.Name = "btnTelefonosContacto";
            this.btnTelefonosContacto.Size = new System.Drawing.Size(207, 57);
            this.btnTelefonosContacto.TabIndex = 13;
            this.btnTelefonosContacto.Text = "Teléfonos de contacto";
            this.btnTelefonosContacto.UseVisualStyleBackColor = true;
            this.btnTelefonosContacto.Click += new System.EventHandler(this.btnTelefonosContacto_Click);
            // 
            // btnTodosContactos
            // 
            this.btnTodosContactos.Location = new System.Drawing.Point(112, 608);
            this.btnTodosContactos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTodosContactos.Name = "btnTodosContactos";
            this.btnTodosContactos.Size = new System.Drawing.Size(180, 51);
            this.btnTodosContactos.TabIndex = 17;
            this.btnTodosContactos.Text = "Todos los contactos";
            this.btnTodosContactos.UseVisualStyleBackColor = true;
            this.btnTodosContactos.Click += new System.EventHandler(this.btnTodosContactos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 35);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarGrupoToolStripMenuItem,
            this.agregarContactoToolStripMenuItem,
            this.agregarTelefonoAContactoToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // agregarGrupoToolStripMenuItem
            // 
            this.agregarGrupoToolStripMenuItem.Name = "agregarGrupoToolStripMenuItem";
            this.agregarGrupoToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.agregarGrupoToolStripMenuItem.Text = "Agregar Grupo";
            // 
            // agregarContactoToolStripMenuItem
            // 
            this.agregarContactoToolStripMenuItem.Name = "agregarContactoToolStripMenuItem";
            this.agregarContactoToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.agregarContactoToolStripMenuItem.Text = "Agregar Contacto";
            // 
            // agregarTelefonoAContactoToolStripMenuItem
            // 
            this.agregarTelefonoAContactoToolStripMenuItem.Name = "agregarTelefonoAContactoToolStripMenuItem";
            this.agregarTelefonoAContactoToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.agregarTelefonoAContactoToolStripMenuItem.Text = "Agregar Telefono A Contacto";
            this.agregarTelefonoAContactoToolStripMenuItem.Click += new System.EventHandler(this.agregarTelefonoAContactoToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnTodosContactos);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.btnContactosTelefono);
            this.Controls.Add(this.txtIdContacto);
            this.Controls.Add(this.btnTelefonosContacto);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
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
    }
}

