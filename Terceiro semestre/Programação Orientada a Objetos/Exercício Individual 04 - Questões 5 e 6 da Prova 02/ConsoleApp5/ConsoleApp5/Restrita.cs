using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Restrita : Porta
    {
        public override bool PodeAbrir(TipoUsuario tipoUsuario)
        {
            return tipoUsuario == TipoUsuario.Segurança || tipoUsuario == TipoUsuario.Funcionario;
        }
    }
}
