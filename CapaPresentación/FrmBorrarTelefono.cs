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

    public partial class FrmBorrarTelefono : Form
    {
        Gestion gestion;
        public FrmBorrarTelefono(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void BtnAceptarNumTel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdContacto.Text))
            {
                MessageBox.Show("El campo 'ID Contacto' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumTelef.Text))
            {
                MessageBox.Show("El campo 'Número de Teléfono' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdContacto.Text, out int idContacto))
            {
                MessageBox.Show("El 'ID Contacto' debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = gestion.BorrarTelefono(idContacto, txtNumTelef.Text);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
