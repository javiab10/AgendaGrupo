﻿using Entidades;
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
        public FrmMain(Gestion gestion , String errores)
        {
           
            this.gestion = gestion;

            if (errores != "")
            {
                MessageBox.Show(errores);
                return;
            }

            InitializeComponent();
        }

        private void txtIdContacto_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int idSeleccionado = (int)dgvContactos.Rows[e.RowIndex].Cells["IdContacto"].Value;

                FrmDatosContacto frmDatosContacto = new FrmDatosContacto(gestion.ContactoById(idSeleccionado, out mensaje), gestion);
                
                frmDatosContacto.FormClosed += btnTodosContactos_Click;
                frmDatosContacto.ShowDialog();
            }

        }

        private void btnTelefonosContacto_Click(object sender, EventArgs e)
        {
            List<Contacto> contactosID = new List<Contacto>();
            if (!int.TryParse(txtIdContacto.Text, out int id))
            {
                MessageBox.Show("Tienes que introducir un número entero");
                dgvContactos.DataSource = "";
                return;
            }

            var contactoID = gestion.DevolverContactoPorId(id,out string errores);

            if (errores != "")
            {
                MessageBox.Show(errores);
                return;
            }

            if (contactoID == null)
            {
                MessageBox.Show("No existe ningún contacto con identificador '" + id + "'");
                return;
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

            if(newContactosID != null)
            {
                lblMensaje.Text = "Telefonos del contacto: '" + newContactosID[0].Nombre + "' del grupo: '"+ newContactosID[0].NombreGrupo + "'";
                dgvContactos.DataSource = "";
                dgvContactos.DataSource = newContactosID;
            }

        }

        private void agregarTelefonoAContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAnadirTelefonoContacto form = new FrmAnadirTelefonoContacto(gestion);
            form.ShowDialog();
        }

        private void btnTodosContactos_Click(object sender, EventArgs e)
        {
            var contactos = gestion.DevolverContactosPorNombre(out string erroresBD );
            if (erroresBD != "")
            {
                MessageBox.Show(erroresBD);
                return;
            }   
            var newContactos = (from contact in contactos
                                select new
                                {
                                    contact.IdContacto,
                                    contact.Nombre,
                                    Email = contact.Email == null || contact.Email == "" ? "..." : contact.Email,
                                    NombreGrupo = contact.Grupos == null ? "..." : contact.Grupos.NombreGrupo,
                                    Teléfonos = contact.Telefonos == null || contact.Telefonos.Count == 0 ? "..." : String.Join(", ", contact.Telefonos)
                                }).ToList();

            if(newContactos != null)
            {
                lblMensaje.Text = "Todos los contactos con su nombre de grupo, cantidad de teléfonos y teléfonos.";
                dgvContactos.DataSource = "";
                dgvContactos.DataSource = newContactos;
            }
            else
            {
                lblMensaje.Text = "No hay contactos que mostrar.";
                dgvContactos.DataSource = "";
            }

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

        private void editarGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarGrupo frmEditar = new FrmEditarGrupo(gestion);
            frmEditar.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnContactosTelefono_Click(object sender, EventArgs e)
        {
            dgvContactos.DataSource = "";

            var contactosPorTelefono = gestion.DevolverContactosPorTelefono(txtNumeroTelefono.Text,out String errores);
            if (errores != "")
            {
                MessageBox.Show(errores);
                return;
            }

            if (contactosPorTelefono == null || contactosPorTelefono.Count == 0)
            {
                lblMensaje.Text = ("No hay contactos con el teléfono " + txtNumeroTelefono.Text);
                return;
            }
            var newContactosPorTelefono = (from contact in contactosPorTelefono
                                           select new
                                           {
                                               IdContacto = contact.IdContacto,
                                               contact.Nombre,
                                               CantTeléfonos = contact.Telefonos.Count,
                                               NombreGrupo = contact.Grupos == null ? "..." : contact.Grupos.NombreGrupo
                                           }).ToList();

            dgvContactos.DataSource = newContactosPorTelefono;
            dgvContactos.Columns["IdContacto"].Visible = false;
            lblMensaje.Text = "Contactos con el teléfono " + txtNumeroTelefono.Text;

        }

        private void mENUToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarTeléfonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarTelefono frmEditarTelef = new FrmEditarTelefono(gestion);
            frmEditarTelef.ShowDialog();
        }
    }
}
