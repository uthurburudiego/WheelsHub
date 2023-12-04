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
    public partial class FormVerUsuarios : Form
    {
        #region Atributos
        List<Usuario> listaUsuarios;
        ManejadorArchivos<List<Usuario>> serializadoraUsuarios = new ManejadorArchivos<List<Usuario>>();
        #endregion

        #region Constructor
        public FormVerUsuarios()
        {
            InitializeComponent();
            this.Enabled = true;    
        }
        #endregion

        #region Metodos
        private void FormVerUsuarios_Load(object sender, EventArgs e)
        {
            string path = ManejadorArchivos<string>.ObtenerPath(@"..\..\..\..\Datos\MOCK_DATA.json");
            listaUsuarios = serializadoraUsuarios.Deserializar(path);
            foreach (Usuario usuario in listaUsuarios)
            {
                ltsUsuarios.Items.Add(usuario.ToString());
            }

        }
        #endregion
    }
}
