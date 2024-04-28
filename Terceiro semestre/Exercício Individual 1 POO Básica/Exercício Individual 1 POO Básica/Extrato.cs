using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Individual_1_POO_Básica
{
    internal class Extrato
    {
        private Stack<string> stack;

        public Extrato()
        {
            this.stack = new Stack<string>();
        }

        public Stack<string> getStack()
        {
            return this.stack;
        }
        public void adicionar(string aux)
        {
            stack.Push(aux);
        }

        public void ultimaMovimentacao()
        {
            Console.WriteLine("\nÚltima movimentação: " + stack.Peek());
        }
    }
}
