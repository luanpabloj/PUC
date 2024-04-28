using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questoes_da_prova
{
    internal class Quarto
    {
        private double preco;
        private string limpeza = "limpo";
        private string tipo;
        private static int identificacao = 0;
        private string disponibilidade = "disponível";
        private string hospede = "não há hospede no quarto";
        private int identificacaoQuarto = identificacao;

        public Quarto(string tipo, string hospede)
        {
            this.preco = 200;
            this.limpeza = "sujo";
            this.tipo = tipo;
            identificacao++;
            this.disponibilidade = "indisponível";
            this.hospede = hospede;
        }

        public double getPreco() { return preco; }
        public string getLimpeza() {  return limpeza; }
        public void setLimpeza(string limpeza) { this.limpeza = limpeza; }
        public string getTipo() {  return tipo; }
        public void setTipo(string tipo) {  this.tipo = tipo; }
        public int getIdentificacaoQuarto() {  return identificacaoQuarto; }
        public string getDisponibilidade() {  return disponibilidade; }
        public void setDisponibilidade(string disponibilidade) { this.disponibilidade = disponibilidade; }

        public override string ToString()
        {
            if(hospede != "não há hospede no quarto")
            {
                return "Quarto ID: " + identificacaoQuarto + "\nDisponibilidade: " + disponibilidade + "\nHóspede: " + hospede;
            }
            return "Quarto ID: " + identificacaoQuarto + "\nDisponibilidade: " + disponibilidade;
        }
    }
}
