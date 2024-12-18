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
    public partial class AnadirTelefonoContacto : Form
    {

        Gestion gestion;
        public AnadirTelefonoContacto(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void AnadirTelefonoContacto_Load(object sender, EventArgs e)
        {
            cmbContactos.Items.Clear();
            cmbContactos.Items.AddRange(gestion.DevolverTodosLosContactos().ToArray());
            
        }
    }
}
