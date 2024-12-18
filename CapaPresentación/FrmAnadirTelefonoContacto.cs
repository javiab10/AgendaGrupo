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
            cmbContactos.Items.AddRange(gestion.DevolverTodosLosContactos().ToArray());
            cmbContactos.DisplayMember = "Nombre";
            
        }

        private void cmbContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Contacto test = cmbContactos.SelectedItem as Contacto;
            gestion.AnadirTelefonoAContacto(txtTelefono.Text, txtDescripcion.Text, test,out string errores);
        }
    }
}
