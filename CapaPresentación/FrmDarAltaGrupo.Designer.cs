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
            this.btnDarAltaGrupo.Location = new System.Drawing.Point(166, 167);
            this.btnDarAltaGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDarAltaGrupo.Name = "btnDarAltaGrupo";
            this.btnDarAltaGrupo.Size = new System.Drawing.Size(56, 19);
            this.btnDarAltaGrupo.TabIndex = 0;
            this.btnDarAltaGrupo.Text = "Aceptar";
            this.btnDarAltaGrupo.UseVisualStyleBackColor = true;
            this.btnDarAltaGrupo.Click += new System.EventHandler(this.btnDarAltaGrupo_Click);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(84, 61);
            this.lblNombreGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(76, 13);
            this.lblNombreGrupo.TabIndex = 1;
            this.lblNombreGrupo.Text = "Nombre Grupo";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(217, 58);
            this.txtNombreGrupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(76, 20);
            this.txtNombreGrupo.TabIndex = 2;
            // 
            // FrmDarAltaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 366);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.btnDarAltaGrupo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDarAltaGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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