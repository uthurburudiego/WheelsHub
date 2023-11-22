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
        List<Usuario> listaUsuarios;
        public FormVerUsuarios()
        {
            InitializeComponent();
            this.Enabled = true;    
        }
        private void FormVerUsuarios_Load(object sender, EventArgs e)
        {
            string rutaRelativa = ManejadorArchivos.ObtenerPath(@"..\..\..\..\Datos\MOCK_DATA.json");
            listaUsuarios = ManejadorArchivos.DeserilizarUsuarios(rutaRelativa);
            foreach (Usuario usuario in listaUsuarios)
            {
                ltsUsuarios.Items.Add(usuario.ToString());
            }

        }
    }
}
