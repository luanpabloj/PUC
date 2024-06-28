using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal abstract class Porta
    {
        public abstract bool PodeAbrir(TipoUsuario tipoUsuario);

        public void Abrir(TipoUsuario tipoUsuario)
        {
            if (PodeAbrir(tipoUsuario))
            {
                Console.WriteLine($"{GetType().Name} aberta por {tipoUsuario}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} não pode ser aberta por {tipoUsuario}");
            }
        }
    }
}
