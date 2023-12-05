using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IValidar
    {
        public bool ValidarEmail(string correo);
        bool validarNumero<T>(string valorIngresado, out T valorSalida);
    }
}
