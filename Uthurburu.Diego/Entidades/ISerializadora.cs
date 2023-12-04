using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISerializadora<T>
    {
        void Serializar(T datos, string path);
         T Deserializar(string path);
    }
}
