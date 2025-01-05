﻿using GestionAgenda;
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
    public partial class FrmEditarTelefono : Form
    {
        Gestion gestion;
        public FrmEditarTelefono(Gestion gestion)
        {
            this.gestion = gestion;
            InitializeComponent();
        }

        private void FrmEditarTelefono_Load(object sender, EventArgs e)
        {
            cbxNumeros.Items.Clear();
            cbxNumeros.Items.AddRange(gestion.DevolverListaTelefonos().ToArray());
        }
    }
}
