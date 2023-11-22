using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ExcepcionArchivos : Exception
    {

        public ExcepcionArchivos(string mnj):base(mnj) { }  
    }
}
