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
using System.Windows.Forms.VisualStyles;

namespace CapaPresentación
{
    public partial class FrmAnadirTelefonoContacto : Form
    {

        Gestion gestion;
        public FrmAnadirTelefonoContacto(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void AnadirTelefonoContacto_Load(object sender, EventArgs e)
        {
            cmbContactos.Items.Clear();
            var listaContactos = gestion.DevolverTodosLosContactos(out string erroresBD);
            if (erroresBD != "")
            {
                MessageBox.Show(erroresBD);
                return;
            }
            cmbContactos.Items.AddRange(listaContactos.ToArray());
            cmbContactos.DisplayMember = "Nombre";
            
        }

        private void cmbContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (cmbContactos.SelectedIndex == -1)
            {
                MessageBox.Show("TIENES QUE ELEGIR UN CONTACTO");
                return;
            }

            if (String.IsNullOrWhiteSpace(txtDescripcion.Text) && String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("LOS CAMPOS NO PUEDEN ESTAR VACIOS");
                return;
            }

            if (!int.TryParse(txtTelefono.Text,out int telefono))
            {
                MessageBox.Show("TIENE QUE SER UN TELEFONO NUMERICO");
                return;
            }

            if (txtTelefono.Text.Length <3)
            {
                MessageBox.Show("EL NUMERO DE TELEFONO TIENE QUE SER DE 3 O MAS DIGITOS");
                return;
            }



            gestion.AnadirTelefonoAContacto(txtTelefono.Text, txtDescripcion.Text, cmbContactos.SelectedItem as Contacto, out string errores);
            if (errores == "")
            {
                MessageBox.Show("Se ha creado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show(errores);
                txtDescripcion.Text = "";
                txtTelefono.Text = "";
                cmbContactos.SelectedIndex = -1;
            }
        }
    }
}
