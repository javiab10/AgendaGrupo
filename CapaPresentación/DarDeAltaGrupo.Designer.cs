namespace CapaPresentación
{
    partial class DarDeAltaGrupo
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
            this.btnDarDeAltaGrupo = new System.Windows.Forms.Button();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.txtBoxNombreGrupo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDarDeAltaGrupo
            // 
            this.btnDarDeAltaGrupo.Location = new System.Drawing.Point(149, 231);
            this.btnDarDeAltaGrupo.Name = "btnDarDeAltaGrupo";
            this.btnDarDeAltaGrupo.Size = new System.Drawing.Size(132, 41);
            this.btnDarDeAltaGrupo.TabIndex = 0;
            this.btnDarDeAltaGrupo.Text = "Dar de Alta";
            this.btnDarDeAltaGrupo.UseVisualStyleBackColor = true;
            this.btnDarDeAltaGrupo.Click += new System.EventHandler(this.btnDarDeAltaGrupo_Click);
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Location = new System.Drawing.Point(99, 135);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(96, 16);
            this.lblNombreGrupo.TabIndex = 2;
            this.lblNombreGrupo.Text = "Nombre Grupo";
            // 
            // txtBoxNombreGrupo
            // 
            this.txtBoxNombreGrupo.Location = new System.Drawing.Point(221, 135);
            this.txtBoxNombreGrupo.Name = "txtBoxNombreGrupo";
            this.txtBoxNombreGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtBoxNombreGrupo.TabIndex = 4;
            // 
            // DarDeAltaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 352);
            this.Controls.Add(this.txtBoxNombreGrupo);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.btnDarDeAltaGrupo);
            this.Name = "DarDeAltaGrupo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDarDeAltaGrupo;
        private System.Windows.Forms.Label lblNombreGrupo;
        private System.Windows.Forms.TextBox txtBoxNombreGrupo;
    }
}