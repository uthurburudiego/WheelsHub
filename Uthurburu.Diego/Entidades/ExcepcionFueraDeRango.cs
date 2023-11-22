using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionFueraDeRango : Exception
    {
        public ExcepcionFueraDeRango(string msj) : base(msj) { }
    }
}
