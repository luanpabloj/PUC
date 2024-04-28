using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVendeTudo
{
    class Produto
    {
        private string nome { get; }
        private string codigo { get; }
        public int quantidadeEstoque { get; private set; }
        protected double precoCompra { get; }

        public Produto(string nome, string codigo, int quantidadeEstoque, double precoCompra)
        {
            this.nome = nome;
            this.codigo = codigo;
            this.quantidadeEstoque = quantidadeEstoque;
            this.precoCompra = precoCompra;
        }

        /// <summary>Implementa o cálculo do Markup.</summary>
        /// <param name="percentual_lucro">Percentual de lucro usada na fórmula do Markup.</param>
        /// <returns>Índice de comercialização, que deve ser multiplicado pelo preço de compra do produto.</returns>
        public virtual double IndiceComercializacao()
        {
            return 100 / (100 - (20 + 20 + 10));
        }

        /// <summary>Adiciona uma quantidade de produtos ao estoque.</summary>
        /// <param name="quantidade">Quantidade a ser adicionada ao estoque.</param>
        public void AdicionarEstoque(int quantidade)
        {
            quantidadeEstoque += quantidade;
        }

        /// <summary>Remove uma quantidade de produtos ao estoque.</summary>
        /// <param name="quantidade">Quantidade a ser removida do estoque.</param>
        /// <returns>><c>true</c> se a quantidade foi removida do estoque; para outros casos, <c>false</c>.</returns>
        public bool RemoverEstoque(int quantidade)
        {
            if(quantidade > quantidadeEstoque || quantidade < 0){
                return false;
            }
            else{
                quantidadeEstoque -= quantidade;
                return true;
            }
        }

        /// <summary>Método para cálculo de estoque.</summary>
        /// <returns>Valor correspondente ao preço de compra, multiplicado pelo índice de comercialização.</returns>
        public virtual double obterPrecoVenda()
        {
            return precoCompra * IndiceComercializacao();
        }

        /// <summary>Método para cálculo do valor total em estoque.</summary>
        /// <returns>Valor correspondente à quantidade em estoque multiplicado pelo preço de venda.</returns>
        public double CalcularValorTotalEstoque()
        {
            return obterPrecoVenda() * quantidadeEstoque;
        }

        /// <summary>Sobrescrita do método ToString().</summary>
        public override string ToString()
        {
            return $"Nome: {this.nome}\n" +
                   $"Código: {this.codigo}\n" +
                   $"Quantidade em Estoque: {this.quantidadeEstoque}\n" +
                   $"Preço de Compra: R$ {this.precoCompra:F2}\n" +
                   $"Preço de Venda: R$ {this.obterPrecoVenda():F2}\n";
        }
    }
}
