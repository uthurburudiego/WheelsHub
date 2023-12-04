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
using WheelsHub;

namespace Interfaces
{
    public partial class FormRegistroConexion : Form
    {
        #region Atributos
        List<string> listaRegistros;
        ManejadorArchivos<List<string>> serializadoraRegistros = new ManejadorArchivos<List<string>>();
        #endregion

        #region Constructor
        public FormRegistroConexion()
        {
            InitializeComponent();
            listaRegistros = new List<string>();
        }
        #endregion

        #region Botones
        private void FormRegistroConexion_Load(object sender, EventArgs e)
        {
            string path= ManejadorArchivos<string>.ObtenerPath(@"..\..\..\..\Datos\usuarios_log.json");
            this.listaRegistros = serializadoraRegistros.Deserializar(path);
         

            foreach (string registro in this.listaRegistros)
            {
                ltsRegistros.Items.Add(registro);
            }
        }
        #endregion
    }
}
