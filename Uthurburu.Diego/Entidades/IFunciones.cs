using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WheelsHub.Logica;
using System.Windows.Forms;

namespace Entidades
{
    internal interface IFunciones
    {
        public bool TextVacio(TextBox text);
        public List<T> ObtenerLista<T>(List<T> vehiculo);
    }
}
