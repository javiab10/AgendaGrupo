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
    public partial class FormMain : Form
    {

        Gestion gestion;
        public FormMain(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void txtIdContacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTelefonosContacto_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtIdContacto.Text.ToString());
            var person = gestion.ContactoById(id);
            dgvContactos.DataSource = new List<Contacto> { person };
        }
    }
}
