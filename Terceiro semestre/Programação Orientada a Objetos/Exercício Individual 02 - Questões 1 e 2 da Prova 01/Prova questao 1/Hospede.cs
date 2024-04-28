using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questoes_da_prova
{
    internal class Hospede
    {
        private string nome;
        private float cpf;
        private string endereco;
        private int telefone;

        public Hospede(string nome, float cpf, string endereco, int telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        
        public string getNome() { return nome; }
        public float getCpf() { return cpf;}
        public string getEndereco() {  return endereco; }
        public void setEndereco(string endereco) {  this.endereco = endereco;}
        public int getTelefone() {  return telefone;}
        public void setTelefone(int telefone) { this.telefone = telefone; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

}
