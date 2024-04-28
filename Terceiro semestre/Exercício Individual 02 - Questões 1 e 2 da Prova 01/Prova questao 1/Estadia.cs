using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questoes_da_prova
{
    internal class Estadia
    {
        private static int identificacao2 = 0;
        private Quarto quarto;
        private Hospede hospede;
        private int identificacaoEstadia = identificacao2;

        public Estadia(Quarto quarto, Hospede hospede)
        {
            this.quarto = quarto;
            this.hospede = hospede;
            identificacao2++;

        }

        public Quarto getQuarto() { return quarto; }
        public Hospede getHospede() { return hospede; }
        public int getIdentificacaoEstadia() {  return identificacaoEstadia; }

        public override string ToString()
        {
            return "Estadia N" + identificacaoEstadia + "\nQuarto: " + quarto.getIdentificacaoQuarto() + "\nHóspede: " + hospede.getNome();
        }
    }
}
