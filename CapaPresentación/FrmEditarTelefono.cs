using Entidades;
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
            var errores = "";
            if (cbxNumeros.SelectedIndex == -1)
            {
                MessageBox.Show("El campo 'Numeros' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Telefono telActual = cbxNumeros.SelectedItem as Telefono;
            gestion.EditarTelefono(txtTelefono.Text, txtDescripcion.Text, out errores);
            if (errores != null)
            {
                MessageBox.Show(errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Teléfono modificado con éxito");
            }
            cbxNumeros.SelectedIndex = -1;

        }

        private void cbxNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Telefono telActual = cbxNumeros.SelectedItem as Telefono;
            if (telActual != null)
            {
                txtTelefono.Text = telActual.Numero.ToString();
                txtDescripcion.Text = telActual.Descripcion.ToString();
            }
        }
    }
}
