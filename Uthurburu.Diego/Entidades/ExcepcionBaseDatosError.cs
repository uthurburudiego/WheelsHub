using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionBaseDatosError: Exception
    {
        Object objetoError;
        public ExcepcionBaseDatosError(string msj, object objetoError) : base(msj) 
        {
            this.objetoError = objetoError;
        }  
        public object ObjetoError{ get => this.objetoError; }
    }
}
