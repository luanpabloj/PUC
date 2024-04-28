using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questoes_da_prova
{
    internal class Hotel
    {
        private static List<Quarto> quartos = new List<Quarto>(30);
        private static List<Estadia> estadias = new List<Estadia>(30);
        
        
        public Hotel()
        {
        }


        public void checkIn()
        {
            Console.Write("Digite o nome do hospede: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF: ");
            int cpf = int.Parse(Console.ReadLine());
            Console.Write("Digite o endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Digite o telefone: ");
            int telefone = int.Parse(Console.ReadLine());
            Console.Write("Digite o tipo do quarto: ");
            string tipo = Console.ReadLine();


            Hospede hospede = new Hospede(nome, cpf, endereco, telefone);
            Quarto quarto = new Quarto(tipo, nome);
            Estadia estadia = new Estadia(quarto, hospede);

            quartos.Add(quarto);
            estadias.Add(estadia);


            Console.WriteLine("\nCheck-IN realizado\n");
        }

        public void checkOut()
        {
            if (estadias.Count != 0)
            {
                Console.WriteLine("Digite a identificação da estadia para realizar o check-Out: ");
                int identificacao = int.Parse(Console.ReadLine());
                int auxiliar = 0;

                foreach (Estadia estadia in estadias)
                {
                    if (estadia.getIdentificacaoEstadia() == identificacao)
                    {
                        auxiliar = estadia.getQuarto().getIdentificacaoQuarto();
                        estadias.Remove(estadia);
                        break;
                    }
                }
                foreach (Quarto quarto in quartos)
                {
                    if (quarto.getIdentificacaoQuarto() == auxiliar)
                    {
                        quartos.Remove(quarto);
                        break;
                    }
                }
                Console.WriteLine("\nCheck-Out realizado\n");
            }
            else
            {
                Console.WriteLine("\nNenhuma estadia cadastrada\n");
            }
        }

        public void mostrarQuartos()
        {
            if (quartos.Count == 0)
            {
                Console.WriteLine("Nenhum quarto registrado\n");
            }
            else
            {
                foreach (Quarto q in quartos)
                {
                    Console.WriteLine(q.ToString());
                }
            }
        }

        public void mostrarEstadias()
        {
            if(estadias.Count == 0)
            {
                Console.WriteLine("Nenhuma estadia cadastrado\n");
            }
            else
            {
                foreach(Estadia estadia in estadias)
                {
                    Console.WriteLine(estadia.ToString());
                }
            }
        }

        public void dadosexemplares()
        {
            Hospede hospede1 = new Hospede("Luan", 098321321, "R PUC - Beagá", 31313123);
            Quarto quarto1 = new Quarto("solteiro", "Luan");
            Estadia estadia1 = new Estadia(quarto1, hospede1);

            Hospede hospede2 = new Hospede("João", 123456, "Rua A, 123", 1234 - 5678);
            Quarto quarto2 = new Quarto("Solteiro", "Joao");
            Estadia estadia2 = new Estadia(quarto2, hospede2);

            Hospede hospede3 = new Hospede("Maria", 98654, "Rua B, 456", 9876 - 3112);
            Quarto quarto3 = new Quarto("Duplo", "Maria");
            Estadia estadia3 = new Estadia(quarto3, hospede3);

            Hospede hospede4 = new Hospede("Pedro", 11122300, "Rua C, 789", 3333 - 3333);
            Quarto quarto4 = new Quarto("Luxo", "Pedro");
            Estadia estadia4 = new Estadia(quarto4, hospede4);

            Hospede hospede5 = new Hospede("Ana", 444555666, "Rua D, 321", 5555 - 4444);
            Quarto quarto5 = new Quarto("Familiar", "Ana");
            Estadia estadia5 = new Estadia(quarto5, hospede5);


            Hospede hospede6 = new Hospede("Carlos", 777888, "Rua E, 654", 9999 - 8888);
            Quarto quarto6 = new Quarto("Presidencial", "Carlos");
            Estadia estadia6 = new Estadia(quarto6, hospede6);

            //quartos.Add(quarto);
            //estadias.Add(estadia);
            quartos.Add(quarto1);
            estadias.Add(estadia1);
            quartos.Add(quarto2);
            estadias.Add(estadia2);
            quartos.Add(quarto3);
            estadias.Add(estadia3);
            quartos.Add(quarto4);
            estadias.Add(estadia4);
            quartos.Add(quarto5);
            estadias.Add(estadia5);
            quartos.Add(quarto6);
            estadias.Add(estadia6);
        }
    }
}
