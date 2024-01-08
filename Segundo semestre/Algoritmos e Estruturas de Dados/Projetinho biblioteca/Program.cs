using System.Diagnostics.Contracts;
using System.Net;

namespace Projetinho_biblioteca;
class Livro{
    private String titulo;
    private String autor;
    private int anoPub;
    private int numPag;
    private String status;

    public Livro(String titulo, String autor, int anoPub, int numPag, String status){
        this.titulo = titulo;
        this.autor = autor;
        this.anoPub = anoPub;
        this.numPag = numPag;
        this.status = status;
    }


    public void emprestadoLivro(){
        status = "emprestado";
    }
    public void devolverLivro(){
        status = "disponível";
    }


    public void descricao(){
        Console.Write("Titulo: " + titulo);
        Console.Write("\nAutor: " + autor);
        Console.Write("\nAno de publicação: " + anoPub);
        Console.Write("\nNúmero de página: " + numPag);
        Console.Write("\nStatus: " + status);
    }

    public String obterTitulo(){
        return titulo;
    }

    public String obterStatus(){
        return status;
    }

}

class Cliente{

    private String nomeCliente;
    private int matricula;
    private Livro[] livros;


    public Cliente(String nomeCliente, int matricula){
        this.nomeCliente = nomeCliente;
        this.matricula = matricula;
        livros = new Livro[5];
    }

    public void emprestado(Livro l1){
        if(l1 != null){
            for(int i = 0; i < 5; i++){
                livros[i] = l1;
                livros[i].emprestadoLivro();
            }
        }
    }

    public void devolver(Livro l1){
        for(int i = 0; i < 5; i++){
            if(livros[i] == l1)
            {
                livros[i] = null;
                livros[i].devolverLivro();
            }
        }
    }

    public void clienteStatus(Livro l1){
        Console.Write("Nome: " + nomeCliente);
        Console.Write("Matrícula: " + matricula);
        Console.Write("Livros emprestados: ");
        foreach (Livro l2 in livros){
            Console.WriteLine(l2.obterTitulo());
        }
    }

    public String obterNome(){
        return nomeCliente;
    }

    public int obterMatricula(){
        return matricula;
    }
}

class Biblioteca{
    
    private Livro[] l1;
    private Cliente[] c1;


    public Biblioteca(){
         l1 = new Livro[10];
         c1 = new Cliente[5];
    }


    public void addLivros(Livro livro){
        for(int i = 0; i < 5; i++){
            if(l1[i] == null){
            l1[i] = livro;
            break;
            }
        }
    }

    public void removLivros(int codigoLivro){
        for(int i = codigoLivro - 1; i < 5; i++){
            if(i == codigoLivro)
            l1[i-1] = null;
        }
    }

    public void addClient(Cliente cliente){
        for(int i = 0; i < 5; i++){
            if(c1[i] == null){
                c1[i] = cliente;
                break;
            }
        }
    }

    public void removClient(int matriculaExcluir, int[,] matriz){
       for(int i = 0; i < 10; i++){ 
            for(int j = 0; j < 5; j++){
                if(matriz[0, j] == matriculaExcluir || (c1[j] != null && c1[j].obterMatricula() == matriculaExcluir)){
                        matriz[0, j] = 0;
                        c1[j] = null;
                             if(matriz[i, 0] == i && l1[i] != null){
                                  l1[i].devolverLivro();
                                  matriz[i, 0] = 0;
                                    Console.WriteLine("Matrícula excluída e livro devolvido");
                                 }
                                else{
                                    Console.WriteLine("Matrícula excluída");
                                    break;
                                }
                     }
                 }
            }
     }

    public void exibirLivros(){
        int cont = 1;
        Console.WriteLine("Livros cadastrados: ");
        foreach(Livro l2 in l1){
            if(l2 != null)
                Console.WriteLine("3." + cont + " " + l2.obterTitulo());
                cont++;
        }
    }

    public void exibirClientes(){
        int cont = 1;
        Console.WriteLine("Clientes: ");
        foreach(Cliente client in c1){
            if(client != null)
            Console.WriteLine("4." + cont + " " + client.obterNome() + " matricula: " + client.obterMatricula());
            cont++;
        }
    }

    public void exibirDescricao(int x){
        if(l1[x-1] != null){
        l1[x-1].descricao();
        }
        else{
        Console.WriteLine("Livro não encontrado");
        }
    }

    public void emprestarLivro(int[,] matriz, int codigoEmprestar, int codigoLivro){
        for(int i = 0; i < 10; i++){
            for(int j = 0; j < 5; j++){
                if(matriz[i, j] == 0){
                    matriz[i, 0] = codigoLivro;
                    matriz[0, j] = codigoEmprestar;
                    if(l1[codigoLivro - 1].obterStatus() == "disponível"){
                        l1[codigoLivro - 1].emprestadoLivro();
                        Console.WriteLine("Livro emprestado para o usuário: " + c1[codigoLivro - 1].obterNome());
                    break;
                    }
                }

            }
        }
    }

    public void devolverLivroEmprestado(int codigoLivroDevolver, int[,] matriz){
              for(int i = 0; i < 10; i++){ 
                             if(matriz[i, 0] == i && l1[i] != null || l1[i].obterStatus() == "emprestado"){
                                  l1[i].devolverLivro();
                                  matriz[i, 0] = 0;
                                    Console.WriteLine("Livro devolvido");
                                    break;
                                 }
                                else{
                                    Console.WriteLine("O livro não está emprestado");
                                    break;
                                }
                     }
    }

}


class Program
{
    public static void Main(string[] args)
    {
        Biblioteca bi1 = new Biblioteca();
        bool trueOrfalse = true;
        Livro cadastrarLivro;
        Cliente cliente;
        Biblioteca biblioteca = new Biblioteca();
        int[,] matriz = new int[10, 5];
        do{
            Console.WriteLine("\nBem-vindo ao sistema de biblioteca");
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Cadastrar Livro\n2 - Cadastrar Cliente\n3 - Exibir livros cadastrados\n4 - Exibir clientes\n5 - Remover Livro\n6 - Remover Cliente\n7 - Emprestar livro\n8 - Devolver livro");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha){
                case 1:
                Console.Write("Nome do livro: ");
                String nomeDoLivro = Console.ReadLine();
                Console.Write("Autor do livro: ");
                String autorDoLivro = Console.ReadLine();
                Console.Write("Ano de publicação: ");
                int anoDePub = int.Parse(Console.ReadLine());
                Console.Write("Número de páginas: ");
                int numDePag = int.Parse(Console.ReadLine());
                String status = "disponível";
                cadastrarLivro = new Livro(nomeDoLivro, autorDoLivro, anoDePub, numDePag, status);
                biblioteca.addLivros(cadastrarLivro);
                Console.ReadLine();
                break;
                
                case 2:
                    Console.Write("Nome do cliente: ");
                    String nomeCliente = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    int matricula = int.Parse(Console.ReadLine());
                    cliente = new Cliente(nomeCliente, matricula);
                    biblioteca.addClient(cliente);
                    Console.ReadLine();
                break;

                case 3:
                    biblioteca.exibirLivros();
                    Console.Write("Deseja ter mais detalhes sobre um livro? (s/n) ");
                    string sn = Console.ReadLine();
                    if(sn == "s"){
                    Console.Write("Digite o código do livro informado após o segundo ponto:  (2.1.x) ");
                    int x = 0;
                    x = int.Parse(Console.ReadLine());
                    if(x != 0){
                        biblioteca.exibirDescricao(x);
                        }
                    }
                    Console.ReadLine();
                break;
                
                case 4:
                    biblioteca.exibirClientes();
                    Console.ReadLine();
                break;
                
                case 5:
                    Console.Write("Dos livros disponíveis, digite o segundo número apresentado após o ponto: (3.x) ");
                    int codigoLivro = int.Parse(Console.ReadLine());
                    biblioteca.removLivros(codigoLivro);
                    Console.ReadLine();
                break;

                case 6:
                    Console.Write("Digite a matrícula do usuário a ser excluído: ");
                    int matriculaExcluir = int.Parse(Console.ReadLine());
                    biblioteca.removClient(matriculaExcluir, matriz);
                    Console.ReadLine();
                break;

                case 7:
                    Console.Write("Digite a matrícula do cliente: ");
                    int matriculaEmprestar = int.Parse(Console.ReadLine());
                    Console.Write("Digite o código do livro a ser emprestado: (3.x)");
                    int codigoEmprestar = int.Parse(Console.ReadLine());
                    biblioteca.emprestarLivro(matriz, codigoEmprestar, matriculaEmprestar);
                    Console.ReadLine();
                break;

                case 8:
                    Console.Write("Digite o código do livro a ser devolvido: ");
                    int codigoLivroDevolver = int.Parse(Console.ReadLine());
                    biblioteca.devolverLivroEmprestado(codigoLivroDevolver, matriz);
                    Console.ReadLine();
                break;
                default: 
                Console.WriteLine("Fim do programa");
                trueOrfalse = false;
                break;
            }
        }
        while(trueOrfalse != false);
    }
}

