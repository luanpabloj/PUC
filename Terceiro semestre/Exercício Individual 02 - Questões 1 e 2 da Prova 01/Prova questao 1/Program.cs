namespace questoes_da_prova
{
    internal class Program
    {
        public static Hotel hotel = new Hotel();
        static void Main(string[] args)
        {
          hotel.dadosexemplares();
          menu();

        }

        static void menu()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine("Menu:\n1)Mostrar todos os quartos indisponíveis\n2)Mostrar estadias\n3)Fazer check-In\n4)Fazer check-Out\n5)Sair");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        hotel.mostrarQuartos();
                        break;
                    case 2:
                        hotel.mostrarEstadias();
                        break;
                    case 3:
                        hotel.checkIn();
                        break;
                    case 4:
                        hotel.checkOut();
                        break;
                }
            } while (opcao != 5 && opcao < 5 && opcao > 0);
        }
    }
}
