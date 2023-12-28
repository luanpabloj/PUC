namespace questao3;
using System.Collections.Generic;

class Contato{
    public string nome {get; set;}
    public int telefone {get; set;}
    public string email {get; set;}

    public Contato(string nome, int telefone, string email){
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
    }
}

class Agenda{

    Contato contato;
    private List<Contato> list = new List<Contato>();

    public void adicionar(string nome, int telefone, string email){
           contato = new Contato(nome, telefone, email);
           list.Add(contato);
           Console.WriteLine("Contato adicionado");
    }

    public void atualizar(string nome, int telefone, string email){
        bool trueFalse = false;

        foreach(Contato i in list){
            if(contato.nome == nome){
                contato.telefone = telefone;
                contato.email = email;
                Console.WriteLine("Contato atualizado");
                break;
            }
        }

        if(trueFalse == false){
            Console.WriteLine("Contato não encontrado");
        }
    }
    

    public void excluir(string nome){
        int auxiliar = -1;
        for(int i = 0; i < list.Count; i++){
            if(list[i].nome == nome){
                auxiliar = i;
                break;
            }
        }

        if(auxiliar >= 0){
            list.RemoveAt(auxiliar);
            Console.WriteLine("Contato excluido");
        }
        else if(auxiliar < 0){
            Console.WriteLine("Contato não encontrado");
        }
        
    }

    public void listar(){
        foreach(Contato i in list){
            Console.WriteLine($"Nome: {contato.nome}, Telefone: {contato.telefone}, Email: {contato.email}");
        }
    }



}
class Program
{
    static void Main(string[] args)
    {
        Contato contato;
        Agenda agenda = new Agenda();
        int n = 0, opcao = 0;

        do{
            Console.WriteLine("1 - Adicionar um novo contato com nome, telefone e e-mail\n2 - Atualizar informações de um contato existente\n3 - Excluir um contato da agenda\n4 - Listar todos os contatos na agenda\n5 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                Console.Write("Digite um nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o telefone: ");
                int telefone = int.Parse(Console.ReadLine());
                Console.Write("Digite o e-mail: ");
                string email = Console.ReadLine();

                agenda.adicionar(nome, telefone, email);
                Console.WriteLine(" ");
                break;

                case 2:
                Console.Write("Digite o nome do contato a ser atualizado: ");
                nome = Console.ReadLine();
                Console.Write("Digite o telefone atual ou o novo telefone: ");
                telefone = int.Parse(Console.ReadLine());
                Console.Write("Digite o e-mail atual ou o novo e-mail: ");
                email = Console.ReadLine();
                agenda.atualizar(nome, telefone, email);
                Console.WriteLine(" ");
                break;

                case 3:
                Console.Write("Digite o nome contato a ser excluido: ");
                nome = Console.ReadLine();
                agenda.excluir(nome);
                Console.WriteLine(" ");
                break;

                case 4:
                agenda.listar();
                Console.WriteLine(" ");
                break;
            }
        }while(opcao != 5);
    }
}
