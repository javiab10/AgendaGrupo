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
    public partial class FrmDarAltaGrupo : Form
    {
        public FrmDarAltaGrupo()
        {
            InitializeComponent();
        }

        private void btnDarDeAltaGrupo_Click(object sender, EventArgs e)
        {
            Gestion repo = new Gestion(out string error);
            if (error == "")
            {
                string resultado = repo.AgregarGrupo(txtNombreGrupo.Text);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine(error);
            }

        }
    }
}
