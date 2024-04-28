using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVendeTudo
{
    internal class Eletronico : Produto
    {
        private MarcaEletronico marca;
        private string modelo;

        //propriedades
        public MarcaEletronico Marca { get => marca; }
        public string Modelo { get => modelo; }

        public Eletronico(string nome, string codigo, int quantidadeEstoque, double precoCompra, MarcaEletronico marca, string modelo)
            : base(nome, codigo, quantidadeEstoque, precoCompra)
        {
            this.marca = marca;
            this.modelo = modelo;
        }

        public override double IndiceComercializacao()
        {
            if(marca == MarcaEletronico.APPLE){
                return (float) 100 / (100 - (20 + 20 + 10));
            }

            else{
                return (float) 100 / (100 - (10 + 20 + 10));
            }
            
        }

        public override double obterPrecoVenda()
        {   
            return Math.Ceiling(precoCompra * IndiceComercializacao());
        }

        public override string ToString()
        {
            return base.ToString() +
                   $"Marca: {this.marca}\n" +
                   $"Modelo: {this.modelo}\n";
        }
    }
}
