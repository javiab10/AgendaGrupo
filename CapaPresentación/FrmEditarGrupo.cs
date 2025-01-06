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
    public partial class FrmEditarGrupo : Form
    {

        private Gestion gestion;
        public FrmEditarGrupo(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmEditarGrupo_Load(object sender, EventArgs e)
        {
            var listaGrupos = gestion.DevolverTodosLosGrupos(out string errores);
            if (errores !="")
            {
                MessageBox.Show(errores);
                return;
            }
            cmbSeleccionarGrupo.Items.AddRange(listaGrupos.ToArray());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (cmbSeleccionarGrupo.SelectedIndex == -1)
            {
                MessageBox.Show("TIENES QUE ELEGIR UN GRUPO");
                return;
            }

            if (String.IsNullOrWhiteSpace(txtNuevoNombre.Text))
            {
                MessageBox.Show("EL CAMPO NO PUEDE ESTAR VACIO");
                return;
            }   


            var grupo = (Grupos)cmbSeleccionarGrupo.SelectedItem;
            gestion.EditarGrupo(grupo.IdGrupo, txtNuevoNombre.Text,out string errores);

            if (errores != "")
            {
                MessageBox.Show(errores);
                return;
            }
            else
            {
                MessageBox.Show("Se ha cambiado el nombre correctamente");
                this.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (cmbSeleccionarGrupo.SelectedIndex == -1)
            {
                MessageBox.Show("TIENES QUE ELEGIR UN GRUPO");
                return;
            }   

            DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que quieres borrar el grupo seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) {
                return;
            }

            var grupo = (Grupos)cmbSeleccionarGrupo.SelectedItem;
            gestion.BorrarGrupo(grupo.IdGrupo, out string errores);

            if (errores != "")
            {
                MessageBox.Show(errores);
                return;
            }
            else
            {
                MessageBox.Show("Se ha borrado el grupo correctamente");
                this.Close();
            }

        }
    }
}
