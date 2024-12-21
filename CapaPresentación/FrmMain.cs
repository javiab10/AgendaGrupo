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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentación
{
    public partial class FrmMain : Form
    {

        Gestion gestion;
        public FrmMain(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void txtIdContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTelefonosContacto_Click(object sender, EventArgs e)
        {

        }

        private void agregarTelefonoAContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnadirTelefonoContacto form = new FrmAnadirTelefonoContacto(gestion);
            form.ShowDialog();
        }

        private void btnTodosContactos_Click(object sender, EventArgs e)
        {
            var contactos = gestion.DevolverContactosPorNombre();
            var newContactos = (from contact in contactos
                                select new
                                {
                                    contact.IdContacto,
                                    contact.Nombre,
                                    contact.Email,
                                    NombreGrupo = contact.Grupos,
                                    Teléfonos = String.Join(", ", contact.Telefonos)
                                }).ToList();


            dgvContactos.DataSource = null;
            dgvContactos.DataSource = newContactos;

        }

        private void agregarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDarAltaGrupo formDarAltaGrupo = new FrmDarAltaGrupo(gestion);
            formDarAltaGrupo.ShowDialog();
        }

        private void borrarTeléfonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBorrarTelefono frmBorrarTelefono = new FrmBorrarTelefono(gestion);
            frmBorrarTelefono.ShowDialog();
        }
    }
}
