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
    public partial class FrmDatosContacto : Form
    {
        private int idContacto;
        Gestion gestion;
        public FrmDatosContacto(Contacto contacto, Gestion gestion)
        {
            InitializeComponent();
            this.gestion = gestion;

            idContacto = contacto.IdContacto;
            lblTextNombre.Text = contacto.Nombre;
            lblTextEmail.Text = contacto.Email;
            lblTextNombreGrupo.Text = contacto.Grupos == null ? "" : contacto.Grupos.NombreGrupo;
            //lblTextNumero.Text = String.Join(", ", contacto.Telefonos);

            int xLabel = 210;
            int yLabel = 130;

            int xValor = 322;
            int yValor = 130;

            foreach (Telefono cadaTelefono in contacto.Telefonos)
            {
                Label lblNumero = new Label();
                lblNumero.Text = "Número:";
                lblNumero.Location = new Point(xLabel, yLabel += 30);
                this.Controls.Add(lblNumero);

                Label lblTextNumero = new Label();
                lblTextNumero.Text = cadaTelefono.Numero;
                lblTextNumero.Size = new Size(93, 23);
                lblTextNumero.TextAlign = ContentAlignment.MiddleLeft;
                lblTextNumero.BackColor = Color.Orange;
                lblTextNumero.Location = new Point(xValor, yValor += 30);
                this.Controls.Add(lblTextNumero);

                Label lblNumeroDesc = new Label();
                lblNumeroDesc.Text = "Descripción:";
                lblNumeroDesc.Location = new Point(xLabel, yLabel += 30);
                this.Controls.Add(lblNumeroDesc);

                Label lblTextNumeroDesc = new Label();
                lblTextNumeroDesc.Text = cadaTelefono.Descripcion;
                lblTextNumeroDesc.Size = new Size(93, 23);
                lblTextNumeroDesc.TextAlign = ContentAlignment.MiddleLeft;
                lblTextNumeroDesc.BackColor = Color.Orange;
                lblTextNumeroDesc.Location = new Point(xValor, yValor += 30);
                this.Controls.Add(lblTextNumeroDesc);
            }

        }

        private void btnEliminarContaco_Click(object sender, EventArgs e)
        {
            string mensaje = "";//Vuelvo a inicializar esta variable como vacia porque en el caso de dar a cancel del messagebox, me imprimira el valor de mensaje que salio de la funcion ContactosAlfPorNombre

            DialogResult avisoEliminarResultado = MessageBox.Show($"Estas seguro de eliminar este contacto?", "", MessageBoxButtons.OKCancel);

            if (avisoEliminarResultado == DialogResult.OK)
            {
                gestion.BorrarContacto(idContacto, out mensaje);
                MessageBox.Show(mensaje);
            }
            else if (!String.IsNullOrWhiteSpace(mensaje))
            {
                MessageBox.Show(mensaje);
            }
        }
    }
}
