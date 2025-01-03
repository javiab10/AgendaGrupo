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
            List<Contacto> contactosID = new List<Contacto>();
            if (!int.TryParse(txtIdContacto.Text, out int id))
            {
                MessageBox.Show("Tienes que introducir un número entero");
                return;
            }

            var contactoID = gestion.DevolverContactoPorId(id);
            
            if (contactoID == null)
            {
                MessageBox.Show("El id de contacto " + id + " no existe.");
            }

            contactosID.Add(contactoID);

            var newContactosID = (from contact in contactosID
                                select new
                                {
                                    contact.IdContacto,
                                    contact.Nombre,
                                    Email = contact.Email == null || contact.Email == "" ? "..." : contact.Email,
                                    NombreGrupo = contact.Grupos == null ? "..." : contact.Grupos.NombreGrupo,
                                    Teléfonos = contact.Telefonos == null || contact.Telefonos.Count == 0 ? "..." : String.Join(", ", contact.Telefonos)
                                }).ToList();

            dgvContactos.DataSource = "";
            dgvContactos.DataSource = newContactosID;
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
                                    Email = contact.Email == null || contact.Email == "" ? "..." : contact.Email,
                                    NombreGrupo = contact.Grupos == null ? "..." : contact.Grupos.NombreGrupo,
                                    Teléfonos = contact.Telefonos == null || contact.Telefonos.Count == 0 ? "..." : String.Join(", ", contact.Telefonos)
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

        private void agregarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearContacto frmCrearContacto = new FrmCrearContacto(gestion);
            frmCrearContacto.ShowDialog();
        }
    }
}
