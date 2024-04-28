using System.Diagnostics;

namespace LojaVendeTudo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Regras: 
             * Considere que o preço do produto seja definido usando a fórmula do Markup
             * Referências: https://www.serasa.com.br/blog/como-precificar-um-produto/
             * Parâmetros:
             *  - Custo Fixo: 20%
             *  - Custo Variável: 10%
             *  - Percentual Lucro 20% (varia de acordo com produto)
             */

            Produto produto;

            //--------------------------------
            // Gerencia Produtos
            //--------------------------------

            /*
             * Regras: 
             * - Percentual Lucro: 20%
             * - Implementar todos os métodos que contenham o seguinte código: "throw new NotImplementedException();"
             * - Regras de cada um dos métodos estão especificadas no comentário sobre o cabeçalho dos mesmos.
             */

            produto = new Produto("Cadeira", "CA-01", 10, 300);
            Debug.Assert(produto.obterPrecoVenda() == 600);
            Console.WriteLine(produto.ToString());

            produto.AdicionarEstoque(10);
            Debug.Assert(produto.quantidadeEstoque == 20);
            Debug.Assert(produto.CalcularValorTotalEstoque() == 12000);

            produto.RemoverEstoque(25);
            Debug.Assert(produto.quantidadeEstoque == 20);
            Debug.Assert(produto.CalcularValorTotalEstoque() == 12000);

            produto.RemoverEstoque(5);
            Debug.Assert(produto.quantidadeEstoque == 15);
            Debug.Assert(produto.CalcularValorTotalEstoque() == 9000);
            produto.RemoverEstoque(-5);
            Debug.Assert(produto.quantidadeEstoque == 15);
            Debug.Assert(produto.CalcularValorTotalEstoque() == 9000);

            //--------------------------------
            // Gerencia Vestuário
            //--------------------------------

            /*
             * Regras: 
             * - Percentual Lucro Populares: 5%
             * - Percentual Lucro Luxo: 30%
             * - Percentual Lucro Alta Costura: 50%
             * - Implementar todos os métodos que contenham o seguinte código: "throw new NotImplementedException();" 
             * - Sobrescrever métodos, se necessário.
             */

            // Vestuário
            produto = new Vestuario("Camisa", "CM-01", 5, 100, "G",
                "Branca", TipoVestuario.POPULAR);
            Debug.Assert(Math.Ceiling(produto.obterPrecoVenda()) == 154);
            Console.WriteLine(produto.ToString());

            produto = new Vestuario("Moletom", "MT-01", 10, 500, "M", "Azul", TipoVestuario.ALTA_COSTURA);
            Debug.Assert(Math.Ceiling(produto.obterPrecoVenda()) == 2500);
            Console.WriteLine(produto.ToString());

            //--------------------------------
            // Gerencia Alimento
            //--------------------------------

            /*
            * Regras: 
            * - Percentual Lucro: 30%
            * - Implementar todos os métodos que contenham o seguinte código: "throw new NotImplementedException();" 
            * - Sobrescrever métodos, se necessário.
            */

            produto = new Alimento("Arroz", "AR-01", 30, 10, DateTime.Now.AddYears(1));
            Debug.Assert(produto.obterPrecoVenda() == 20);
            Console.WriteLine(produto.ToString());


            //--------------------------------
            // Gerencia Eletrônicos
            //--------------------------------

            /*
            * Regras: 
            * - Percentual Lucro: 10%
            * - Percentual Lucro Apple: 20%
            * - Implementar todos os métodos que contenham o seguinte código: "throw new NotImplementedException();" 
            * - Sobrescrever métodos, se necessário.
            */

            produto = new Eletronico("Apple Watch", "AP-01", 10, 1000,
                MarcaEletronico.APPLE, "Apple Watch 1234");
            Debug.Assert(produto.obterPrecoVenda() == 2000);
            Console.WriteLine(produto.ToString());

            Eletronico xbox = new Eletronico("Xbox One", "XB-01", 3, 1800,
                MarcaEletronico.MICROSOFT, "Xbox One 1234");
            Debug.Assert(xbox.obterPrecoVenda() == 3000);
            Console.WriteLine(xbox.ToString());

            Eletronico galaxy_s24 = new Eletronico("Galaxy S24 ", "GS-01", 5, 3000,
                MarcaEletronico.SAMSUNG, "Galaxy S24 256GB");
            Debug.Assert(galaxy_s24.obterPrecoVenda() == 5000);
            Console.WriteLine(galaxy_s24.ToString());
        }
    }
}
