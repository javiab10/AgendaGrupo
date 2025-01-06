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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace CapaPresentación
{
    public partial class FrmDatosContacto : Form
    {
        Contacto contactoRecibido;
        Gestion gestion;
        public FrmDatosContacto(Contacto contacto, Gestion gestion)
        {
            InitializeComponent();
            this.gestion = gestion;
            this.contactoRecibido = contacto;

            txtNombre.Text = contacto.Nombre;
            txtEmail.Text = contacto.Email;
            txtNombreGrupo.Text = contacto.Grupos == null ? "" : contacto.Grupos.NombreGrupo;


            int xLabel = 210;
            int yLabel = 140;

            int xValor = 315;
            int yValor = 140;

            if (contacto.Telefonos != null && contacto.Telefonos.Any())
            {
                foreach (Telefono cadaTelefono in contacto.Telefonos)
                {
                    Label lblNumero = new Label();
                    lblNumero.Text = "Número:";
                    lblNumero.Location = new Point(xLabel, yLabel += 30);
                    this.Controls.Add(lblNumero);

                    TextBox txtNumeroTel = new TextBox();
                    txtNumeroTel.Name = $"numeroTel";
                    txtNumeroTel.Text = cadaTelefono.Numero;
                    txtNumeroTel.ReadOnly = true;
                    txtNumeroTel.BorderStyle = BorderStyle.None;
                    txtNumeroTel.BackColor = Color.Orange;
                    txtNumeroTel.Location = new Point(xValor, yValor += 30);
                    this.Controls.Add(txtNumeroTel);

                    Button btnEliminarTelefono = new Button();
                    btnEliminarTelefono.Visible = false;
                    btnEliminarTelefono.Location = new Point(xValor + 110, yValor - 1);
                    btnEliminarTelefono.Width = 130;
                    btnEliminarTelefono.Text = "Eliminar este teléfono";
                    btnEliminarTelefono.Click += (sender, e) => btnEliminarTelefono_Click(contactoRecibido.IdContacto, cadaTelefono.Numero);
                    this.Controls.Add(btnEliminarTelefono);

                    Label lblNumeroDesc = new Label();
                    lblNumeroDesc.Text = "Descripción:";
                    lblNumeroDesc.Location = new Point(xLabel, yLabel += 30);
                    this.Controls.Add(lblNumeroDesc);

                    TextBox txtNumeroDescTel = new TextBox();
                    txtNumeroDescTel.Name = $"descripcionTel";
                    txtNumeroDescTel.Text = cadaTelefono.Descripcion;
                    txtNumeroDescTel.ReadOnly = true;
                    txtNumeroDescTel.BorderStyle = BorderStyle.None;
                    txtNumeroDescTel.BackColor = Color.Orange;
                    txtNumeroDescTel.Location = new Point(xValor, yValor += 30);
                    this.Controls.Add(txtNumeroDescTel);
                }
            }
        }

        private void btnEliminarContaco_Click(object sender, EventArgs e)
        {
            string mensaje = "";//Vuelvo a inicializar esta variable como vacia porque en el caso de dar a cancel del messagebox, me imprimira el valor de mensaje que salio de la funcion ContactosAlfPorNombre

            DialogResult avisoEliminarResultado = MessageBox.Show($"Estas seguro de eliminar este contacto?", "", MessageBoxButtons.OKCancel);

            if (avisoEliminarResultado == DialogResult.OK)
            {
                gestion.BorrarContacto(contactoRecibido.IdContacto, out mensaje);
                MessageBox.Show(mensaje);
            }
            else if (!String.IsNullOrWhiteSpace(mensaje))//TODO creo que esta mal
            {
                MessageBox.Show(mensaje);
            }
        }

        private void btnModificarContacto_Click(object sender, EventArgs e)
        {

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.ReadOnly = false;
                    textBox.BorderStyle = BorderStyle.Fixed3D;
                }

                if (control is Button button && button.Visible == false)//TODO no es si es buena practica
                {
                    button.Visible = true;
                }
            }

            btnModificarContacto.Click -= btnModificarContacto_Click;
            btnModificarContacto.Text = "Guardar";
            btnModificarContacto.Click += btnModificar_Click;
        }

        public void btnModificar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo nombre no puede estar vacío.");
                return;
            }

            contactoRecibido.Nombre = txtNombre.Text;
            contactoRecibido.Email = txtEmail.Text == ""? null: txtEmail.Text;
            

            Telefono telefonoActualizado = new Telefono();
            contactoRecibido.Telefonos.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox txtTel)
                {

                    if (txtTel.Name.StartsWith("numeroTel"))
                    {
                        telefonoActualizado = new Telefono();
                        telefonoActualizado.Numero = txtTel.Text;
                    }
                    else if (txtTel.Name.StartsWith("descripcionTel"))
                    {
                        telefonoActualizado.Descripcion = txtTel.Text;
                        contactoRecibido.Telefonos.Add(telefonoActualizado);
                    }

                }
            }

            if (gestion.MofidicarContacto(contactoRecibido) == true)
            {
                MessageBox.Show("Contacto modificado con éxito!");
                Close();
            }
            else
            {
                MessageBox.Show("Hubo un error.");
            }

        }


        public void btnEliminarTelefono_Click(int idContacto, string numeroTelefono)
        {
            DialogResult avisoEliminarResultado = MessageBox.Show("¿Estás seguro de que quieres borrar este teléfono?", "", MessageBoxButtons.OKCancel);

            if (avisoEliminarResultado == DialogResult.OK)
            {
                MessageBox.Show(gestion.BorrarTelefono(idContacto, numeroTelefono));
            }
        }



    }
}
