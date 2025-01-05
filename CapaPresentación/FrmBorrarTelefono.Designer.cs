namespace CapaPresentación
{
    partial class FrmBorrarTelefono
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
            this.BtnAceptarNumTel = new System.Windows.Forms.Button();
            this.lblIdContacto = new System.Windows.Forms.Label();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.cbxIdContacto = new System.Windows.Forms.ComboBox();
            this.cbxNumTelf = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnAceptarNumTel
            // 
            this.BtnAceptarNumTel.Location = new System.Drawing.Point(136, 221);
            this.BtnAceptarNumTel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptarNumTel.Name = "BtnAceptarNumTel";
            this.BtnAceptarNumTel.Size = new System.Drawing.Size(56, 19);
            this.BtnAceptarNumTel.TabIndex = 0;
            this.BtnAceptarNumTel.Text = "Aceptar";
            this.BtnAceptarNumTel.UseVisualStyleBackColor = true;
            this.BtnAceptarNumTel.Click += new System.EventHandler(this.BtnAceptarNumTel_Click);
            // 
            // lblIdContacto
            // 
            this.lblIdContacto.AutoSize = true;
            this.lblIdContacto.Location = new System.Drawing.Point(69, 62);
            this.lblIdContacto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdContacto.Name = "lblIdContacto";
            this.lblIdContacto.Size = new System.Drawing.Size(50, 13);
            this.lblIdContacto.TabIndex = 1;
            this.lblIdContacto.Text = "Contacto";
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(69, 117);
            this.lblNumTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(49, 13);
            this.lblNumTel.TabIndex = 2;
            this.lblNumTel.Text = "Teléfono";
            // 
            // cbxIdContacto
            // 
            this.cbxIdContacto.FormattingEnabled = true;
            this.cbxIdContacto.Location = new System.Drawing.Point(148, 62);
            this.cbxIdContacto.Margin = new System.Windows.Forms.Padding(2);
            this.cbxIdContacto.Name = "cbxIdContacto";
            this.cbxIdContacto.Size = new System.Drawing.Size(92, 21);
            this.cbxIdContacto.TabIndex = 5;
            this.cbxIdContacto.SelectedIndexChanged += new System.EventHandler(this.cbxIdContacto_SelectedIndexChanged);
            // 
            // cbxNumTelf
            // 
            this.cbxNumTelf.FormattingEnabled = true;
            this.cbxNumTelf.Location = new System.Drawing.Point(148, 117);
            this.cbxNumTelf.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNumTelf.Name = "cbxNumTelf";
            this.cbxNumTelf.Size = new System.Drawing.Size(92, 21);
            this.cbxNumTelf.TabIndex = 6;
            this.cbxNumTelf.SelectedIndexChanged += new System.EventHandler(this.cbxNumTelf_SelectedIndexChanged);
            // 
            // FrmBorrarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 314);
            this.Controls.Add(this.cbxNumTelf);
            this.Controls.Add(this.cbxIdContacto);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.lblIdContacto);
            this.Controls.Add(this.BtnAceptarNumTel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBorrarTelefono";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBorrarTelefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptarNumTel;
        private System.Windows.Forms.Label lblIdContacto;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.ComboBox cbxIdContacto;
        private System.Windows.Forms.ComboBox cbxNumTelf;
    }
}