﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WheelsHub;

namespace Interfaces
{
    public partial class FormRegistroConexion : Form
    {
        List<string> listaRegistros;
        public FormRegistroConexion()
        {
            InitializeComponent();
            listaRegistros = new List<string>();
        }

        private void FormRegistroConexion_Load(object sender, EventArgs e)
        {
            string rutaRelativa = ManejadorArchivos.ObtenerPath(@"..\..\..\..\Datos\usuarios_log.json");
            this.listaRegistros = ManejadorArchivos.DeserilizarRegistro(rutaRelativa);

            foreach (string registro in this.listaRegistros)
            {
                ltsRegistros.Items.Add(registro);
            }

        }
    }
}
