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
            if (cbxIdContacto.SelectedIndex == -1)
            {
                MessageBox.Show("El campo 'Contacto' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbxNumTelf.SelectedIndex == -1)
            {
                MessageBox.Show("El campo 'Número de Teléfono' no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Contacto contActual = cbxIdContacto.SelectedItem as Contacto;
            string resultado = gestion.BorrarTelefono(contActual.IdContacto, cbxNumTelf.SelectedItem.ToString());

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cbxNumTelf.SelectedIndex = -1;
            cbxIdContacto.SelectedIndex = -1;
        }

        private void FrmBorrarTelefono_Load(object sender, EventArgs e)
        {
            cbxIdContacto.Items.Clear();
            var listaContactos = gestion.DevolverContactosPorNombre(out string erroresBD);
            if (erroresBD != "")
            {
                MessageBox.Show(erroresBD);
                return;
            }   
            cbxIdContacto.Items.AddRange(listaContactos.ToArray());
        }

        private void cbxIdContacto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxNumTelf.Items.Clear();
            if (cbxIdContacto.SelectedItem != null)
            {
                Contacto contActual = cbxIdContacto.SelectedItem as Contacto;
                cbxNumTelf.Items.AddRange(contActual.Telefonos.ToArray());
            }

            
        }

        private void cbxNumTelf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
