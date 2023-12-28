namespace questao_5;

class Animal{
    private string nome;
    private int idade;
    private string classificacao;

    public Animal(string nome, int idade, string classificacao){
        this.nome = nome;
        this.idade = idade;
        this.classificacao = classificacao;
    }


    public string sons(){
        if(classificacao == "vaca"){
            return "MUUUUUUUUUUUUUUU";
        }
        else if(classificacao == "cachorro"){
            return "AUAUAUAUAUUAUAUAU";
        }
        else if(classificacao == "galinha"){
            return "COCORICOOOOOO";
        }
        else if(classificacao == "gato"){
            return "MIAUUUUUUUUU MIAUUUUUUUU";
        }
        else{
            return "animal não encontrado";
        }

    }


}


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());
        Console.Write("Digite a classificação (vaca, cachorro, galinha ou gato): ");
        string classificacao = Console.ReadLine();

        Animal animal = new Animal (nome, idade, classificacao);

        Console.WriteLine(animal.sons());
    }
}
