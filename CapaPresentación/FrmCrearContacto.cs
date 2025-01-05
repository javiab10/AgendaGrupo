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
    public partial class FrmCrearContacto : Form
    {
        private Gestion gestion;
        public FrmCrearContacto(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FrmCrearContacto_Load(object sender, EventArgs e)
        {
            cmbGrupo.Items.AddRange(gestion.DevolverListaGrupos().ToArray());

        }

        private void btnAñadirTelefono_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("TIENE QUE SER UN TELEFONO NUMERICO");
                return;
            }

            if (txtTelefono.Text.Length < 3)
            {
                MessageBox.Show("EL NUMERO DE TELEFONO TIENE QUE SER DE 3 O MAS DIGITOS");
                return;
            }


            lstBoxTelefonos.Items.Add(new Telefono(txtTelefono.Text, txtDescripcion.Text));

            txtDescripcion.Text = "";
            txtTelefono.Text = "";

        }

        private void btnBorrarTelefono_Click(object sender, EventArgs e)
        {
            lstBoxTelefonos.Items.Remove(lstBoxTelefonos.SelectedItem);
        }



        private void btnCrearContacto_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("EL NOMBRE NO PUEDE ESTAR VACIO");
                return;
            }

            Grupos grupoSeleccionado = cmbGrupo.SelectedIndex == -1 ? null : cmbGrupo.SelectedItem as Grupos;


            Contacto contactoACrear = new Contacto(txtNombre.Text, txtEmail.Text, grupoSeleccionado == null ? (int?) null : grupoSeleccionado.IdGrupo, grupoSeleccionado, lstBoxTelefonos.Items.Count == 0 ? new List<Telefono>() : lstBoxTelefonos.Items.Cast<Telefono>().ToList());


            gestion.CrearContacto(contactoACrear, out string errores);

            if (errores == "")
            {
                MessageBox.Show("EL CONTACTO SE HA CREADO CORRECTAMENTE");
                this.Close();

            }
            else
            {
                MessageBox.Show(errores);
                txtDescripcion.Text = "";
                txtTelefono.Text = "";
                txtNombre.Text = "";
                txtEmail.Text = "";
                cmbGrupo.SelectedIndex = -1;
                lstBoxTelefonos.Items.Clear();



            }

        }
    }
}
