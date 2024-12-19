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
        Gestion gestion;
        public FrmDarAltaGrupo(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

     

        private void btnDarAltaGrupo_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(txtNombreGrupo.Text))
            {
                MessageBox.Show("No has introducido ningún nombre de Grupo");
                return;
            }


            string resultado = gestion.AgregarGrupo(txtNombreGrupo.Text);
            MessageBox.Show(resultado);
   
          
        }
    }
}
