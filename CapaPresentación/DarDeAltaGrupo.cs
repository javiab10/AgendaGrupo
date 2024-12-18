using GestionAgenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    
    public partial class DarDeAltaGrupo : Form
    {
        
        public DarDeAltaGrupo()
        {
            InitializeComponent();
        }
        
        private void btnDarDeAltaGrupo_Click(object sender, EventArgs e)
        {
            Gestion repo = new Gestion(out string error);
            if (error == ""){
                string resultado = repo.AgregarGrupo(txtBoxNombreGrupo.Text);
                Console.WriteLine(resultado);
            }else{
                Console.WriteLine(error);
            }
            
        }
    }
}
