using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionArchivos : Exception
    {

        Object objetoError;
        public ExcepcionArchivos(string msj, object objetoError) : base(msj)
        {
            this.objetoError = objetoError;
        }

        public object ObjetoError { get => this.objetoError; }
    }
}
