namespace CapaPresentación
{
    partial class FrmDarAltaGrupo
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
            this.btnDarAltaGrupo = new System.Windows.Forms.Button();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDarAltaGrupo
            // 
            this.btnDarAltaGrupo.Location = new System.Drawing.Point(221, 206);
            this.btnDarAltaGrupo.Name = "btnDarAltaGrupo";
            this.btnDarAltaGrupo.Size = new System.Drawing.Size(75, 23);
            this.btnDarAltaGrupo.TabIndex = 0;
            this.btnDarAltaGrupo.Text = "Aceptar";
            this.btnDarAltaGrupo.UseVisualStyleBackColor = true;
            this.btnDarAltaGrupo.Click += new System.EventHandler(this.btnDarAltaGrupo_Click);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(112, 75);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(96, 16);
            this.lblNombreGrupo.TabIndex = 1;
            this.lblNombreGrupo.Text = "Nombre Grupo";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(289, 72);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtNombreGrupo.TabIndex = 2;
            // 
            // FrmDarAltaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.btnDarAltaGrupo);
            this.Name = "FrmDarAltaGrupo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDarAltaGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.TextBox txtNombreGrupo;
    }
}