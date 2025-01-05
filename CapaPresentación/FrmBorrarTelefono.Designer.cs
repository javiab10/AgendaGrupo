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
            this.BtnAceptarNumTel.Location = new System.Drawing.Point(182, 272);
            this.BtnAceptarNumTel.Name = "BtnAceptarNumTel";
            this.BtnAceptarNumTel.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptarNumTel.TabIndex = 0;
            this.BtnAceptarNumTel.Text = "Aceptar";
            this.BtnAceptarNumTel.UseVisualStyleBackColor = true;
            this.BtnAceptarNumTel.Click += new System.EventHandler(this.BtnAceptarNumTel_Click);
            // 
            // lblIdContacto
            // 
            this.lblIdContacto.AutoSize = true;
            this.lblIdContacto.Location = new System.Drawing.Point(92, 76);
            this.lblIdContacto.Name = "lblIdContacto";
            this.lblIdContacto.Size = new System.Drawing.Size(74, 16);
            this.lblIdContacto.TabIndex = 1;
            this.lblIdContacto.Text = "Id Contacto";
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.Location = new System.Drawing.Point(92, 144);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(61, 16);
            this.lblNumTel.TabIndex = 2;
            this.lblNumTel.Text = "Teléfono";
            // 
            // cbxIdContacto
            // 
            this.cbxIdContacto.FormattingEnabled = true;
            this.cbxIdContacto.Location = new System.Drawing.Point(197, 76);
            this.cbxIdContacto.Name = "cbxIdContacto";
            this.cbxIdContacto.Size = new System.Drawing.Size(121, 24);
            this.cbxIdContacto.TabIndex = 5;
            this.cbxIdContacto.SelectedIndexChanged += new System.EventHandler(this.cbxIdContacto_SelectedIndexChanged);
            // 
            // cbxNumTelf
            // 
            this.cbxNumTelf.FormattingEnabled = true;
            this.cbxNumTelf.Location = new System.Drawing.Point(197, 144);
            this.cbxNumTelf.Name = "cbxNumTelf";
            this.cbxNumTelf.Size = new System.Drawing.Size(121, 24);
            this.cbxNumTelf.TabIndex = 6;
            // 
            // FrmBorrarTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 387);
            this.Controls.Add(this.cbxNumTelf);
            this.Controls.Add(this.cbxIdContacto);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.lblIdContacto);
            this.Controls.Add(this.BtnAceptarNumTel);
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