namespace questao_3;

class Livro{

    private String titulo;
    private String autor;
    private String genero;


    public Livro(String titulo, String autor, String genero){
        this.titulo = titulo;
        this.autor = autor;
        this.genero = genero;
    }

    public void imprimir(){
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Autor: " + autor);
        Console.WriteLine("Gênero: " + genero);
    }

    public bool verificacao(){
        if(genero == "ficcao"){
            return true;
        }
        else{
            return false;
        }
    }


}


class Program
{
    static void Main(string[] args)
    {
        String titulo = "", autor = "", genero = "";

        Console.Write("Digite o título: ");
        titulo = Console.ReadLine();
        Console.Write("Digite o autor: ");
        autor = Console.ReadLine();
        Console.Write("Digite o gênero: ");
        genero = Console.ReadLine();

        Livro livro = new Livro(titulo, autor, genero);


        livro.imprimir();
        Console.WriteLine("O livro é de ficção: " + livro.verificacao());


    }
}
