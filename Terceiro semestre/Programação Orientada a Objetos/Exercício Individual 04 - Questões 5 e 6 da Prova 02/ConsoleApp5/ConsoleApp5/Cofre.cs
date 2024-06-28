using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Cofre : Porta
    {
        private DateTime horaSolicitacao;

        public override bool PodeAbrir(TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == TipoUsuario.GerenteGeral)
            {
                if (horaSolicitacao == DateTime.MinValue)
                {
                    horaSolicitacao = DateTime.Now;
                    Console.WriteLine("Solicitação de abertura registrada. Aguarde 1 hora.");
                    return false;
                }
                else if ((DateTime.Now - horaSolicitacao).TotalHours >= 1)
                {
                    horaSolicitacao = DateTime.MinValue;
                    return true;
                }
                else
                {
                    Console.WriteLine("Aguarde o tempo restante para abrir a porta do cofre.");
                    return false;
                }
            }
            return false;
        }
    }
}
