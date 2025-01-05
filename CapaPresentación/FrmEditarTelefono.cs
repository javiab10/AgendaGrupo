using GestionAgenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FrmEditarTelefono : Form
    {
        Gestion gestion;
        public FrmEditarTelefono(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void FrmEditarTelefono_Load(object sender, EventArgs e)
        {
            cbxNumeros.Items.Clear();
            cbxNumeros.Items.AddRange(gestion.DevolverListaTelefonos().ToArray());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbxNumeros.SelectedIndex == -1)
            {
                MessageBox.Show("El campo 'ID Contacto' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
