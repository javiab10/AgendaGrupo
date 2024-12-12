using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using GestionAgenda;

namespace CapaPresentacion
{
    public partial class FrmConsultas : Form
    {
        Gestion gestion;
        public FrmConsultas(Gestion gestion)
        {
            this.gestion = gestion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnTelefonosContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnTodosContactos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnContactosTelefono_Click(object sender, EventArgs e)
        {
        }

        // NO BORRAR
        private void btnAltaContactos_Click(object sender, EventArgs e)
        {
            
        }

    }
}
